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
    public partial class FormRestok : Form
    {
        Konfigurasi konfigurasi;
        POSLog log;
        public FormRestok()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
            log = new POSLog();
        }

        private void FormRestok_Load(object sender, EventArgs e)
        {
            try
            {
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();

                adapterRestokBarangSupplier.Connection = konfigurasi.getKoneksi();
                adapterBarang.Connection = konfigurasi.getKoneksi();
                adapterSupplier.Connection= konfigurasi.getKoneksi();
                adapterHargaBarangSupplier.Connection = konfigurasi.getKoneksi();
                adapterRestok.Connection = konfigurasi.getKoneksi();
                adapterStok.Connection = konfigurasi.getKoneksi();

                adapterRestokBarangSupplier.Fill(datasetPOS.tbl_restok_barang_supplier);
                adapterBarang.Fill(datasetPOS.tbl_barang);
                adapterSupplier.Fill(datasetPOS.tbl_supplier);
                tsbReset_Click(sender, e);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void cmbNamaBarang_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if(cmbNamaBarang.SelectedValue!=null)
                        adapterHargaBarangSupplier.FillByBarangID(datasetPOS.tbl_harga_barang_supplier, Convert.ToInt32(cmbNamaBarang.SelectedValue));
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void cmbNamaBarang_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (cmbNamaBarang.SelectedValue != null)
                    adapterHargaBarangSupplier.FillByBarangID(datasetPOS.tbl_harga_barang_supplier, Convert.ToInt32(cmbNamaBarang.SelectedValue));

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
                if (txtRestokID.Text == "")
                {
                    if (cmbNamaBarang.SelectedValue != null && cmbSupplier.SelectedValue != null)
                    {
                        Int64 restokID = incrementLastIDFromTable(datasetPOS.tbl_restok_barang_supplier, "restok_id");
                        DataRow row = datasetPOS.tbl_restok_barang_supplier.NewRow();

                        //log
                        log.setLogStok(String.Format("[insert] tbl_restok, item: {0} ({1} -> {2}) -=[{3}]=-",
                            cmbNamaBarang.Text, row["qty"], numQty.Value,
                            "Penambahan Stok"));
                        //----

                        row["restok_id"] = restokID;
                        row["tanggal_restok"] = dtpTanggalRestok.Value;
                        row["barang_id"] = cmbNamaBarang.SelectedValue;
                        row["nama_barang"] = cmbNamaBarang.Text;
                        row["supplier_id"] = cmbSupplier.SelectedValue;
                        row["nama_supplier"] = cmbSupplier.Text;
                        row["qty"] = numQty.Value;
                        row["keterangan"] = txtKeterangan.Text;
                        //datasetPOS.tbl_restok_barang_supplier.Rows.Add(row);
                        datasetPOS.tbl_restok_barang_supplier.Rows.InsertAt(row, 0);
                        adapterRestok.Insert(restokID, dtpTanggalRestok.Value, Convert.ToInt32(cmbNamaBarang.SelectedValue), Convert.ToInt32(cmbSupplier.SelectedValue), Convert.ToInt32(numQty.Value), txtKeterangan.Text);
                        //update stok
                        adapterStok.FillByBarangID(datasetPOS.tbl_stok, Convert.ToInt32(row["barang_id"]));
                        Int32 stok = Convert.ToInt32(datasetPOS.tbl_stok.Rows[0]["stok"]);
                        Int32 barangID = Convert.ToInt32(datasetPOS.tbl_stok.Rows[0]["barang_id"]);
                        stok += Convert.ToInt32(row["qty"]);
                        adapterStok.UpdateQueryByBarangID(stok, barangID);
                        //--update stok---
                        bsRestokBarangSupplier.Position = 0;
                    }
                    else
                    {
                        MessageBox.Show("Pilih nama barang yang benar!");
                    }
                }
                else
                {
                    DataRowView rowView = (DataRowView)bsRestokBarangSupplier.Current;

                    //log
                    log.setLogStok(String.Format("[update] tbl_restok, item: {0} ({1} -> {2}) -=[{3}]=-",
                        cmbNamaBarang.Text, rowView["qty"], numQty.Value,
                        numQty.Value - Convert.ToDecimal(rowView["qty"]) > 0 ? "Penambahan Stok" : "Pengurangan Stok"));
                    //----

                    Int64 restokID = (Int64)rowView["restok_id"];
                    rowView.Row["tanggal_restok"] = dtpTanggalRestok.Value;
                    rowView.Row["barang_id"] = cmbNamaBarang.SelectedValue;
                    rowView.Row["nama_barang"] = cmbNamaBarang.Text;
                    rowView.Row["supplier_id"] = cmbSupplier.SelectedValue;
                    rowView.Row["nama_supplier"] = cmbSupplier.Text;
                    rowView.Row["qty"] = numQty.Value;
                    rowView.Row["keterangan"] = txtKeterangan.Text;
                    adapterRestok.UpdateQueryByRestokID(dtpTanggalRestok.Value, Convert.ToInt32(cmbNamaBarang.SelectedValue), Convert.ToInt32(cmbSupplier.SelectedValue), Convert.ToInt32(numQty.Value), txtKeterangan.Text, restokID);
                    //update stok
                    adapterStok.FillByBarangID(datasetPOS.tbl_stok, Convert.ToInt32(rowView["barang_id"]));
                    Int32 barangID = Convert.ToInt32(datasetPOS.tbl_stok.Rows[0]["barang_id"]);
                    Int32 stokLama = Convert.ToInt32(datasetPOS.tbl_stok.Rows[0]["stok"]);
                    Int32 stokBaru = Convert.ToInt32(numQty.Value);
                    Int32 stok = stokBaru - stokLama;
                    stok += stokLama;
                    adapterStok.UpdateQueryByBarangID(stok, barangID);
                    //--update stok---
                }
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private Int64 incrementLastIDFromTable(DataTable table, String ID)
        {
            if (table.Rows.Count == 0)
                return 1;
            else
            {
                Int64 max = 0;
                foreach (DataRow row in table.Rows)
                {
                    Int64 data = (Int64)row[ID];
                    max = Math.Max(data, max);
                }
                return max+1;
            }
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            txtRestokID.Text = "";
            txtKeterangan.Text = "";
            cmbNamaBarang.SelectedIndex = -1;
            cmbNamaBarang.Text = "";
            cmbSupplier.SelectedIndex = -1;
            cmbSupplier.Text = "";
            numQty.Value = 0;
            dtpTanggalRestok.Value = DateTime.Now;
            bsRestokBarangSupplier.Position = 0;
            cmbNamaBarang.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView rowView = (DataRowView)bsRestokBarangSupplier.Current;
                txtRestokID.Text =  rowView["restok_id"].ToString();
                dtpTanggalRestok.Value = Convert.ToDateTime(rowView["tanggal_restok"]);
                cmbNamaBarang.SelectedValue = rowView["barang_id"];
                adapterHargaBarangSupplier.FillByBarangID(datasetPOS.tbl_harga_barang_supplier, Convert.ToInt32(cmbNamaBarang.SelectedValue));
                cmbSupplier.SelectedValue = rowView["supplier_id"];
                numQty.Value = Convert.ToDecimal(rowView["qty"]);
                txtKeterangan.Text = rowView["keterangan"].ToString();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tstCari_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void tstCari_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    bsRestokBarangSupplier.Filter = tstCari.Text;
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbCari_Click(object sender, EventArgs e)
        {

            try
            {
                bsRestokBarangSupplier.Filter = tstCari.Text;
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbHapus_Click(object sender, EventArgs e)
        {
            try
            {
                String restokID = txtRestokID.Text;
                if (restokID != "")
                {
                    var result = MessageBox.Show("Peringatan: Data yang dihapus tidak dapat dikembalikan lagi!\nApakah yakin akan menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        //log
                        log.setLogStok(String.Format("[delete] tbl_restok, item: {0} ({1} -> {2}) -=[{3}]=-",
                            cmbNamaBarang.Text, numQty.Value, "~",
                            "Pengurangan Stok"));
                        //----

                        adapterRestok.DeleteQueryByRestokID(Convert.ToInt64(restokID));
                        //update stok
                        adapterStok.FillByBarangID(datasetPOS.tbl_stok, Convert.ToInt32(cmbNamaBarang.SelectedValue));
                        Int32 barangID = Convert.ToInt32(datasetPOS.tbl_stok.Rows[0]["barang_id"]);
                        Int32 stok = Convert.ToInt32(datasetPOS.tbl_stok.Rows[0]["stok"]);
                        stok -= Convert.ToInt32(numQty.Value);
                        adapterStok.UpdateQueryByBarangID(stok, barangID);
                        //--update stok---
                        bsRestokBarangSupplier.RemoveCurrent();
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

        private void FormRestok_DoubleClick(object sender, EventArgs e)
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
