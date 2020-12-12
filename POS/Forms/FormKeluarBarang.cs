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
    public partial class FormKeluarBarang : Form
    {
        Konfigurasi konfigurasi;
        public FormKeluarBarang()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void FormKeluarBarang_Load(object sender, EventArgs e)
        {
            try
            {
                adapterBarangKeluarBarang.Fill(datasetPOS.tbl_barang_keluar_barang);
                adapterBarang.Fill(datasetPOS.tbl_barang);
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
                if (txtBarangKeluarID.Text == "")
                {
                    Int32 barangKeluarID = incrementLastIDFromTable(datasetPOS.tbl_barang_keluar_barang, "barang_keluar_id");
                    DataRow row = datasetPOS.tbl_barang_keluar_barang.NewRow();
                    row["barang_keluar_id"] = barangKeluarID;
                    row["tanggal_keluar"] = dtpTanggalKeluar.Value;
                    row["barang_id"] = cmbNamaBarang.SelectedValue;
                    row["nama_barang"] = cmbNamaBarang.Text;
                    row["qty"] = numQty.Value;
                    row["keterangan"] = txtKeterangan.Text;
                    Int32 stok = Convert.ToInt32(adapterStok.getStokFromBarangID(Convert.ToInt32(row["barang_id"])));
                    stok -= Convert.ToInt32(numQty.Value);
                    adapterStok.UpdateQueryByBarangID(stok, Convert.ToInt32(cmbNamaBarang.SelectedValue));
                    adapterBarangKeluar.Insert(barangKeluarID, dtpTanggalKeluar.Value, Convert.ToInt32(cmbNamaBarang.SelectedValue), Convert.ToInt32(numQty.Value), txtKeterangan.Text);
                    datasetPOS.tbl_barang_keluar_barang.Rows.Add(row);
                }
                else
                {
                    Int32 barangKeluarID = Convert.ToInt32(txtBarangKeluarID.Text);
                    DataRowView rowView = (DataRowView)bsBarangKeluar.Current;
                    //rowView["barang_keluar_id"] = barangKeluarID;

                    //stok
                    //Int32 stokLama = Convert.ToInt32(adapterStok.getStokFromBarangID(Convert.ToInt32(cmbNamaBarang.SelectedValue)));
                    Int32 stokLama = Convert.ToInt32(rowView.Row["qty"]);
                    Int32 stokBaru = Convert.ToInt32(numQty.Value);
                    Int32 stok = Convert.ToInt32(adapterStok.getStokFromBarangID(Convert.ToInt32(cmbNamaBarang.SelectedValue)));
                    Int32 tempStok = stokBaru - stokLama;
                    stok -= tempStok;
                    adapterStok.UpdateQueryByBarangID(stok, Convert.ToInt32(cmbNamaBarang.SelectedValue));

                    rowView.Row["tanggal_keluar"] = dtpTanggalKeluar.Value;
                    rowView.Row["barang_id"] = cmbNamaBarang.SelectedValue;
                    rowView.Row["nama_barang"] = cmbNamaBarang.Text;
                    rowView.Row["qty"] = numQty.Value;
                    rowView.Row["keterangan"] = txtKeterangan.Text;

                    
                    adapterBarangKeluar.UpdateQueryByBarangKeluarID(barangKeluarID, dtpTanggalKeluar.Value, Convert.ToInt32(cmbNamaBarang.SelectedValue), Convert.ToInt32(numQty.Value), txtKeterangan.Text);
                    
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int32 barangKeluarID;
                DataRowView rowView = (DataRowView)bsBarangKeluar.Current;
                barangKeluarID = Convert.ToInt32(rowView["barang_keluar_id"]);
                txtBarangKeluarID.Text = barangKeluarID.ToString();
                dtpTanggalKeluar.Value = Convert.ToDateTime(rowView["tanggal_keluar"]);
                cmbNamaBarang.SelectedValue = Convert.ToInt32(rowView["barang_id"]);
                numQty.Value = Convert.ToInt32(rowView["qty"]);
                txtKeterangan.Text = rowView["keterangan"].ToString();
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
                String barangKeluarID = txtBarangKeluarID.Text;
                if (barangKeluarID != "")
                {
                    var result = MessageBox.Show("Peringatan: Data yang dihapus tidak dapat dikembalikan lagi!\nApakah yakin akan menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Int32 stok = Convert.ToInt32(adapterStok.getStokFromBarangID(Convert.ToInt32(cmbNamaBarang.SelectedValue)));
                        stok += Convert.ToInt32(numQty.Value);
                        adapterStok.UpdateQueryByBarangID(stok, Convert.ToInt32(cmbNamaBarang.SelectedValue));

                        adapterBarangKeluar.DeleteQueryByBarangKeluarID(Convert.ToInt32(barangKeluarID));
                        bsBarangKeluar.RemoveCurrent();
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

        private void tsbReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtBarangKeluarID.Text = "";
                dtpTanggalKeluar.Value = DateTime.Now;
                cmbNamaBarang.Text = "";
                cmbNamaBarang.SelectedIndex = 0;
                numQty.Value = 0;
                txtKeterangan.Text = "";
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
