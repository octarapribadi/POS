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
    public partial class FormKategori : Form
    {
        Konfigurasi konfigurasi;
        public FormKategori()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {
            try
            {
                adapterKategori.Fill(datasetPOS1.tbl_kategori);
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
                DataRowView rowView = (DataRowView)bsKategori.Current;
                txtKategoriID.Text = rowView["kategori_id"].ToString();
                cmbKategori.Text = rowView["kategori"].ToString();
                txtKeterangan.Text = rowView["keterangan"].ToString();
                chkAktif.Checked = (Boolean)rowView["aktif"];
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            try
            {
                bsKategori.Position = -1;
                txtKategoriID.Text = "";
                txtKeterangan.Text = "";
                cmbKategori.SelectedIndex = -1;
                cmbKategori.Text = "";
                chkAktif.Checked = true;
                cmbKategori.Focus();
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
                bsKategori.Filter = tstCari.Text;
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }

        }

        private void tstCari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tsbCari_Click(sender, e);
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKategoriID.Text == "")
                {
                    if (cmbKategori.Text != "")
                    {
                        Int32 kategoriID = incrementLastIDFromTable(datasetPOS1.tbl_kategori, "kategori_id");
                        adapterKategori.Insert(kategoriID, cmbKategori.Text, txtKeterangan.Text, chkAktif.Checked);
                        DataRow row = datasetPOS1.tbl_kategori.NewRow();
                        row["kategori_id"] = kategoriID;
                        row["kategori"] = cmbKategori.Text;
                        row["keterangan"] = txtKeterangan.Text;
                        row["aktif"] = (Boolean)chkAktif.Checked;
                        datasetPOS1.tbl_kategori.Rows.Add(row);
                        tsbReset_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Kategori Tidak Boleh Kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    String kategoriID = txtKategoriID.Text;
                    DataRow[] row = datasetPOS1.tbl_kategori.Select(String.Format("kategori_id = {0}",kategoriID));
                    row[0]["kategori"] = cmbKategori.Text;
                    row[0]["keterangan"] = txtKeterangan.Text;
                    row[0]["aktif"] = (Boolean)chkAktif.Checked;
                    adapterKategori.UpdateQueryByKategoriID(cmbKategori.Text, txtKeterangan.Text, chkAktif.Checked, Convert.ToInt32(kategoriID));
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

        private void tsbHapus_Click(object sender, EventArgs e)
        {
            try
            {
                String kategoriID = txtKategoriID.Text;
                if ( kategoriID != "")
                {
                    var result = MessageBox.Show("Peringatan: Data yang dihapus tidak dapat dikembalikan lagi!\nApakah yakin akan menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        adapterKategori.DeleteQueryByKategoriID(Convert.ToInt32(kategoriID));
                        bsKategori.RemoveCurrent();
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
    }

}
