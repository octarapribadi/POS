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
                    Int32 kategoriID = incrementLastIDFromTable(datasetPOS1.tbl_kategori,"kategori_id");
                    DataRow row = datasetPOS1.tbl_kategori.NewRow();
                    row["kategori_id"] = kategoriID;
                    row["kategori"] = cmbKategori.Text;
                    row["keterangan"] = txtKeterangan.Text;
                    row["aktif"] = (Boolean)chkAktif.Checked;
                    datasetPOS1.tbl_kategori.Rows.Add(row);
                    adapterKategori.Insert(kategoriID, cmbKategori.Text, txtKeterangan.Text, chkAktif.Checked);
                    tsbReset_Click(sender, e);
                }
                else
                {
                    Int32 kategoriID = (Int32)cmbKategori.SelectedValue;
                    DataRow[] row = datasetPOS1.tbl_kategori.Select(String.Format("kategori_id = {0}",kategoriID.ToString()));
                    row[0]["kategori"] = cmbKategori.Text;
                    row[0]["keterangan"] = txtKeterangan.Text;
                    row[0]["aktif"] = (Boolean)chkAktif.Checked;
                    adapterKategori.Update(row[0]);
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private Int32 incrementLastIDFromTable(DataTable table, String ID)
        {
            Int32 x = table.Rows.Count == 0 ? 1 : (Int32)table.Rows[table.Rows.Count - 1][ID] + 1;
            //MessageBox.Show(x.ToString());
            return x;
        }

    }

}
