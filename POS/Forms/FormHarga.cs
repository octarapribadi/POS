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
    public partial class FormHarga : Form
    {
        Konfigurasi konfigurasi;
        public FormHarga()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void FormHarga_Load(object sender, EventArgs e)
        {
            try
            {
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();

                adapterHargaBarangSupplier.Connection = konfigurasi.getKoneksi();
                adapterSupplier.Connection = konfigurasi.getKoneksi();
                adapterBarang.Connection = konfigurasi.getKoneksi();
                adapterHarga.Connection = konfigurasi.getKoneksi();

                adapterHargaBarangSupplier.Fill(datasetPOS.tbl_harga_barang_supplier);
                adapterSupplier.Fill(datasetPOS.tbl_supplier);
                adapterBarang.Fill(datasetPOS.tbl_barang);
                tsbReset_Click(sender, e);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void splitContainer1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (splitContainer1.Orientation == Orientation.Horizontal)
                    splitContainer1.Orientation = Orientation.Vertical;
                else
                    splitContainer1.Orientation = Orientation.Horizontal;
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
                DataRowView row = (DataRowView)bsHargaBarangSupplier.Current;
                cmbBarang.SelectedValue = row["barang_id"];
                txtHargaID.Text = row["harga_id"].ToString();
                cmbSupplier.SelectedValue = row["supplier_id"];
                numHargaModal.Value = Convert.ToDecimal(row["harga_model"]);
                numHargaJual.Value = Convert.ToDecimal(row["harga_jual"]);
                chkAktif.Checked = (Boolean)row["aktif"];
                chkDefault.Checked = (Boolean)row["_default_"];
                txtKeterangan.Text = row["keterangan"].ToString();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            try
            {
                bsHargaBarangSupplier.Position = -1;
                txtHargaID.Text = "";
                txtKeterangan.Text = "";
                cmbBarang.Text = "";
                cmbBarang.SelectedIndex = -1;
                cmbSupplier.Text = "";
                //cmbSupplier.SelectedIndex = -1;
                chkAktif.Checked = true;
                chkDefault.Checked = true;
                numHargaModal.Value = 0;
                numHargaJual.Value = 0;
                cmbBarang.Focus();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 hargaID;
                if (txtHargaID.Text == "")
                {
                    if (cmbBarang.Text != "")
                    {
                        DataRow rowHargaBarangSupplier = datasetPOS.tbl_harga_barang_supplier.NewRow();
                        hargaID = incrementLastIDFromTable(datasetPOS.tbl_harga_barang_supplier, "harga_id");
                        rowHargaBarangSupplier["harga_id"] = hargaID;
                        rowHargaBarangSupplier["barang_id"] = cmbBarang.SelectedValue;
                        rowHargaBarangSupplier["nama_barang"] = cmbBarang.Text;
                        //cek apakah supplier ada atau tidak
                        if(cmbSupplier.SelectedValue == null)
                        {
                            Int32 supplierID = incrementLastIDFromTable(datasetPOS.tbl_supplier, "supplier_id")+1;
                            DataRow row = datasetPOS.tbl_supplier.NewRow();
                            row["supplier_id"] = supplierID;
                            row["nama_supplier"] = cmbSupplier.Text;
                            rowHargaBarangSupplier["supplier_id"] = supplierID;
                            rowHargaBarangSupplier["nama_supplier"] = cmbSupplier.Text;
                            datasetPOS.tbl_supplier.Rows.Add(row);
                            adapterSupplier.Insert(supplierID, row["nama_supplier"].ToString(), "", "", "", true, "");
                        }
                        else
                        {
                            rowHargaBarangSupplier["supplier_id"] = cmbSupplier.SelectedValue;
                            rowHargaBarangSupplier["nama_supplier"] = cmbSupplier.Text;
                        }

                        rowHargaBarangSupplier["harga_model"] = numHargaModal.Value;
                        rowHargaBarangSupplier["harga_jual"] = numHargaJual.Value;
                        rowHargaBarangSupplier["aktif"] = chkAktif.Checked;
                        rowHargaBarangSupplier["_default_"] = chkDefault.Checked;
                        rowHargaBarangSupplier["keterangan"] = txtKeterangan.Text;
                        if(chkDefault.Checked == true)
                        {
                            DataRow[] rows = datasetPOS.tbl_harga_barang_supplier.Select(String.Format("barang_id = {0}",cmbBarang.SelectedValue));
                            foreach(DataRow row in rows)
                            {
                                row["_default_"] = false;
                            }
                        }
                        adapterHarga.Update_Default_ByBarangID(Convert.ToInt32(rowHargaBarangSupplier["barang_id"]));
                        adapterHarga.Insert(hargaID, Convert.ToInt32(cmbBarang.SelectedValue), Convert.ToInt32(rowHargaBarangSupplier["supplier_id"]), numHargaModal.Value, numHargaJual.Value, chkAktif.Checked, chkDefault.Checked, txtKeterangan.Text);

                        datasetPOS.tbl_harga_barang_supplier.Rows.Add(rowHargaBarangSupplier);

                    }
                    else
                    {
                        MessageBox.Show("Nama Barang Tidak Boleh Kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    hargaID = Convert.ToInt32(txtHargaID.Text);
                    DataRow[] row = datasetPOS.tbl_harga_barang_supplier.Select(String.Format("harga_id = {0}",hargaID));
                    row[0]["supplier_id"] = cmbSupplier.SelectedValue !=null ? cmbSupplier.SelectedValue : DBNull.Value;
                    row[0]["nama_supplier"] = cmbSupplier.Text;
                    row[0]["harga_model"] = numHargaModal.Value;
                    row[0]["harga_jual"] = numHargaJual.Value;
                    row[0]["aktif"] = chkAktif.Checked;
                    row[0]["_default_"] = chkDefault.Checked;
                    row[0]["keterangan"] = txtKeterangan.Text;
                    if (chkDefault.Checked == true)
                    {
                        DataRow[] rows = datasetPOS.tbl_harga_barang_supplier.Select(String.Format("barang_id = {0}", cmbBarang.SelectedValue));
                        foreach (DataRow r in rows)
                        {
                            r["_default_"] = false;
                        }
                        row[0]["_default_"] = true;
                    }
                    adapterHarga.Update_Default_ByBarangID(Convert.ToInt32(cmbBarang.SelectedValue));
                    adapterHarga.UpdateQueryByHargaID(Convert.ToInt32(cmbSupplier.SelectedValue), numHargaModal.Value, numHargaJual.Value, chkAktif.Checked, chkDefault.Checked, txtKeterangan.Text, hargaID);
                }
            }
            catch(Exception ex)
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

        private void tsbCari_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                bsHargaBarangSupplier.Filter = tstCari.Text;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            */
            try
            {
                if(cmbSupplier.SelectedValue == null)
                    MessageBox.Show("null");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void chkDefault_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("tes");
        }

        private void chkDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkDefault.Checked == false)
                {
                    DataRow[] rows = datasetPOS.tbl_harga_barang_supplier.Select(String.Format("barang_id = {0} AND _default_={1}", cmbBarang.SelectedValue, 1));
                    if (rows == null || rows.Length <= 1)
                    {
                        String message = String.Format("Kamu Tidak Memiliki _Default_ Harga Barang Untuk '{0}'\nPastikan Terdapat Minimal 1 _Default_ Harga Barang Agar Data Barang Tersedia Di Form Lainnya.",cmbBarang.Text);
                        MessageBox.Show(message, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tstCari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                tsbCari_Click(sender, e);
        }

        private void tsbHapus_Click(object sender, EventArgs e)
        {
            try
            {
                String hargaID = txtHargaID.Text;
                if (hargaID != "")
                {
                    DataRowView rowView = (DataRowView)bsHargaBarangSupplier.Current;
                    DataRow[] row = datasetPOS.tbl_harga_barang_supplier.Select(String.Format("barang_id = {0}", cmbBarang.SelectedValue));
                    if (row.Length <= 1 || (Boolean)rowView["_default_"])
                    {
                        MessageBox.Show("Record ini tidak bisa dihapus karena beberapa hal : \n1. Record satu-satunya yang terafiliasi dengan barang atau,\n2. Merupakan record _default_ (silahkan ubah _default_ke record lain terlebih dahulu)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var result = MessageBox.Show("Peringatan: Data yang dihapus tidak dapat dikembalikan lagi!\nApakah yakin akan menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            bsHargaBarangSupplier.RemoveCurrent();
                            adapterHarga.DeleteQueryByHargaID(Convert.ToInt32(hargaID));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pilih terlebih dahulu data yang akan dihapus!");
                }

            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
