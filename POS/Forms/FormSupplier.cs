using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class FormSupplier : Form
    {
        Konfigurasi konfigurasi;
        public FormSupplier()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();

                adapterSupplier.Fill(datasetPOS1.tbl_supplier);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)bsSupplier.Current;
                txtSupplierID.Text = row["supplier_id"].ToString();
                txtEmail.Text = row["email_supplier"].ToString();
                txtAlamat.Text = row["alamat_supplier"].ToString();
                txtKeterangan.Text = row["keterangan"].ToString();
                txtTelepon.Text = row["telepon_supplier"].ToString();
                cmbNamaSupplier.Text = row["nama_supplier"].ToString();
                chkAktif.Checked = (Boolean)row["aktif"];
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text == "")
                {
                    if (cmbNamaSupplier.Text != "")
                    {
                        Int32 supplierID = incrementLastIDFromTable(datasetPOS1.tbl_supplier, "supplier_id");
                        adapterSupplier.Insert(supplierID, cmbNamaSupplier.Text, txtAlamat.Text, txtEmail.Text, txtTelepon.Text, chkAktif.Checked, txtKeterangan.Text);
                        DataRow row = datasetPOS1.tbl_supplier.NewRow();
                        row["supplier_id"] = supplierID;
                        row["nama_supplier"] = cmbNamaSupplier.Text;
                        row["alamat_supplier"] = txtAlamat.Text;
                        row["email_supplier"] = txtEmail.Text;
                        row["telepon_supplier"] = txtTelepon.Text;
                        row["keterangan"] = txtKeterangan.Text;
                        row["aktif"] = (Boolean)chkAktif.Checked;
                        datasetPOS1.tbl_supplier.Rows.Add(row);
                        tsbReset_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Nama Supplier Tidak Boleh Kosong!","Perhatian",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    String supplierID = txtSupplierID.Text;
                    DataRow[] row = datasetPOS1.tbl_supplier.Select(String.Format("supplier_id = {0}", supplierID));
                    row[0]["nama_supplier"] = cmbNamaSupplier.Text;
                    row[0]["alamat_supplier"] = txtAlamat.Text;
                    row[0]["email_supplier"] = txtEmail.Text;
                    row[0]["telepon_supplier"] = txtTelepon.Text;
                    row[0]["keterangan"] = txtKeterangan.Text;
                    row[0]["aktif"] = (Boolean)chkAktif.Checked;
                    adapterSupplier.UpdateQueryBySupplierID(cmbNamaSupplier.Text, txtAlamat.Text, txtEmail.Text, txtTelepon.Text, chkAktif.Checked, txtKeterangan.Text, Convert.ToInt32(supplierID));
                }
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private Int32 incrementLastIDFromTable(DataTable table, String ID)
        {
            if (table.Rows.Count == 0)
                return 1;
            else
            {
                Int32 max = 0;
                foreach (DataRow row in table.Rows)
                {
                    Int32 data = (Int32)row[ID];
                    max = Math.Max(data, max);
                }
                return max + 1;
            }
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            try
            {
                bsSupplier.Position = -1;
                txtSupplierID.Text = "";
                cmbNamaSupplier.Text = "";
                cmbNamaSupplier.SelectedIndex = -1;
                txtAlamat.Text = "";
                txtEmail.Text = "";
                txtKeterangan.Text = "";
                txtTelepon.Text = "";
                chkAktif.Checked = true;
                cmbNamaSupplier.Focus();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbCari_Click(object sender, EventArgs e)
        {
            try
            {
                bsSupplier.Filter = tstCari.Text;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tstCari_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    tsbCari_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbHapus_Click(object sender, EventArgs e)
        {
            try
            {
                String supplierID = txtSupplierID.Text;
                if (supplierID != "")
                {
                    var result = MessageBox.Show("Peringatan: Data yang dihapus tidak dapat dikembalikan lagi!\nApakah yakin akan menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        adapterSupplier.DeleteQueryBySupplierID(Convert.ToInt32(supplierID));
                        bsSupplier.RemoveCurrent();
                    }
                }
                else
                {
                    MessageBox.Show("Pilih terlebih dahulu data yang akan dihapus!");
                }

            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
            finally
            {
                tsbReset_Click(sender, e);
            }
        }

        private void splitContainer1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (splitContainer1.Orientation == Orientation.Horizontal)
                    splitContainer1.Orientation = Orientation.Vertical;
                else
                    splitContainer1.Orientation = Orientation.Horizontal;
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
