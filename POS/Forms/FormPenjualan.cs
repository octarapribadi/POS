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
    public partial class FormPenjualan : Form
    {
        ID id;
        Konfigurasi konfigurasi;
        //barcode barang
        String mode = "barcode";
        Int64 penjualanID = 0;
        Decimal totalBelanja = 0;
        Decimal subTotalBelanja = 0;
        Decimal totalBayar = 0;
        Decimal totalKembalian = 0;
        public FormPenjualan()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
            id = new ID();
        }

        private void cmbBarang_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                
                if(e.KeyCode == Keys.F1)
                {
                    mode = "barang";
                    cmbBarang.DataSource = datasetPOS.tbl_barang;
                    cmbBarang.DisplayMember = "nama_barang";
                    cmbBarang.ValueMember = "barang_id";
                    cmbBarang.Text = "Masukan nama barang";
                    cmbBarang.Select(0, cmbBarang.Text.Length);

                }
                if(e.KeyCode == Keys.F2)
                {
                    mode = "barcode";
                    cmbBarang.DataSource = null;
                    cmbBarang.Text = "Masukan barcode";
                    cmbBarang.Select(0, cmbBarang.Text.Length);
                }
                if(e.KeyCode == Keys.Enter)
                {
                    
                    if (mode == "barang")
                    {
                        if (cmbBarang.SelectedValue == null)
                        {
                            MessageBox.Show("Barang yang kamu pilih tidak ada, silahkan pilih yang benar!");
                        }
                        else
                        {
                            DataRow row = datasetPOS.tbl_listpenjualan_barang.NewRow();
                            row["penjualan_id"] = penjualanID;
                            row["barang_id"] = cmbBarang.SelectedValue;
                            row["nama_barang"] = cmbBarang.Text;
                            row["quantity"] = 1;
                            row["harga_jual"] = adapterHarga.GetHargaJualByBarangIDDefault(Convert.ToInt32(row["barang_id"]));
                            datasetPOS.tbl_listpenjualan_barang.Rows.Add(row);
                            totalBelanja = getTotal();
                            lblTotal.Text = totalBelanja.ToString("C");
                            subTotalBelanja = getSubtotal();
                            txtSubtotal.Text = subTotalBelanja.ToString("C");
                            cmbBarang.SelectedIndex = -1;
                            cmbBarang.Text = "";
                            cmbBarang.Focus();
                        }
                    } 
                           
                    /*
                    {
                        DataRow[] row2 = datasetPOS.tbl_barang.Select(String.Format("kode_barcode = {0}",cmbBarang.Text));
                        row["barang_id"] = row2[0]["barang_id"];
                        row["nama_barang"] = row2[0]["nama_barang"];
                    }
                    */

                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void cmbBarang_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbBarang.Text == "Masukan nama barang" || cmbBarang.Text == "Masukan barcode")
                {
                    cmbBarang.Text = "";
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
         try
            {
                adapterBarang.Connection = konfigurasi.getKoneksi();
                adapterPenjualan.Connection = konfigurasi.getKoneksi();
                adapterListPenjualanBarang.Connection = konfigurasi.getKoneksi();
                adapterHarga.Connection = konfigurasi.getKoneksi();
                adapterLstPenjualan.Connection = konfigurasi.getKoneksi();
                adapterStok.Connection = konfigurasi.getKoneksi();


                adapterBarang.Fill(datasetPOS.tbl_barang);
                cmbBarang.Enabled = false;
                KeyPreview = true;
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();



            }   
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void FormPenjualan_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.F3)
                {
                    cmbBarang.Enabled = true;
                    if (mode == "barcode")
                    {
                        cmbBarang.DataSource = null;
                        cmbBarang.Text = "Masukan barcode";
                        cmbBarang.Select(0, cmbBarang.Text.Length);
                        cmbBarang.Focus();
                    }
                    else
                    {
                        cmbBarang.DataSource = datasetPOS.tbl_barang;
                        cmbBarang.DisplayMember = "nama_barang";
                        cmbBarang.ValueMember = "barang_id";
                        cmbBarang.Text = "Masukan nama barang";
                        cmbBarang.Select(0, cmbBarang.Text.Length);
                        cmbBarang.Focus();
                    }
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void btnFakturBaru_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(incrementID("tbl_idx_penjualan").ToString());
            
            try
            {
                
                
                cmbBarang.Enabled = true;
                //penjualanID = Convert.ToInt64(adapterPenjualan.getMaxPenjualanID())+1;
                penjualanID = incrementID("tbl_idx_penjualan");
                if(penjualanID == -1)
                {
                    MessageBox.Show("Nomor faktur bermasalah, hubungi administrator!");
                }
                else
                {
                    lblFaktur.Text = penjualanID.ToString("FK_0000000000");
                    if (mode == "barcode")
                    {
                        cmbBarang.DataSource = null;
                        cmbBarang.Select(0, cmbBarang.Text.Length);
                        cmbBarang.Text = "Masukan barcode";
                        cmbBarang.Focus();
                    }
                    else
                    {

                        cmbBarang.DataSource = datasetPOS.tbl_barang;
                        cmbBarang.DisplayMember = "nama_barang";
                        cmbBarang.ValueMember = "barang_id";
                        cmbBarang.Select(0, cmbBarang.Text.Length);
                        cmbBarang.SelectedIndex = -1;
                        cmbBarang.Text = "Masukan nama barang";
                        cmbBarang.Focus();
                    }
                }
                
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
        }

        private void btnHapusFaktur_Click(object sender, EventArgs e)
        {
            try
            {
                datasetPOS.tbl_listpenjualan_barang.Clear();
                cmbBarang.Text = "";
                cmbBarang.Enabled = false;
                cmbBarang.DataSource = null;
                lblFaktur.Text = "";
                subTotalBelanja = 0;
                txtSubtotal.Text = subTotalBelanja.ToString("C");
                totalBelanja = 0;
                lblTotal.Text = totalBelanja.ToString("C");
                totalBayar = 0;
                totalKembalian = 0;
                numPotongan.Value = 0;
                numTotalBayar.Value = 0;
                txtKeterangan.Text = "";
                txtKembalian.Text = "";

                btnFakturBaru.Focus();
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private Int64 incrementID(String tableName)
        {
            try
            {
                return id.getID(tableName);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
                return 0;
            }
            /*
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
                return max + 1;
            }
            */
        }

        private void dataGridView1_CellVluaeChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                totalBelanja = getTotal();
                //MessageBox.Show(totalBelanja.ToString());
                lblTotal.Text = totalBelanja.ToString("C");
                subTotalBelanja = getSubtotal();
                txtSubtotal.Text = subTotalBelanja.ToString("C");
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
        private Decimal getSubtotal()
        {
            if (datasetPOS.tbl_listpenjualan_barang.Rows.Count > 0)
            {
                //MessageBox.Show(datasetPOS.tbl_listpenjualan_barang.Rows.Count.ToString());
                Decimal totalPenjualan = 0;
                foreach (DataRow r in datasetPOS.tbl_listpenjualan_barang.Rows)
                {
                    Decimal diskon = 0;
                    if (r["diskon"] != DBNull.Value)
                    {
                        diskon = Convert.ToDecimal(r["diskon"]);
                    }
                    totalPenjualan += (Convert.ToDecimal(r["harga_jual"]) * Convert.ToInt32(r["quantity"])) - diskon * Convert.ToInt32(r["quantity"]);
                }
                return totalPenjualan;
            }
            else
                return 0;
            
        }
        private Decimal getTotal()
        {
                Decimal subtotal = getSubtotal();
                Decimal potongan = numPotongan.Value;
                return subtotal - potongan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (totalBayar >= totalBelanja)
                {
                    adapterPenjualan.Insert(penjualanID, DateTime.Now, txtKeterangan.Text, totalBelanja, numTotalBayar.Value, totalKembalian, numPotongan.Value);
                    foreach (DataRow row in datasetPOS.tbl_listpenjualan_barang.Rows)
                    {
                        Int32 barangID = Convert.ToInt32(row["barang_id"]);
                        Int32 quantity = Convert.ToInt32(row["quantity"]);
                        Decimal hargaJual;
                        Decimal diskon;
                        String keterangan = null;
                        if (row["harga_jual"] != DBNull.Value)
                            hargaJual = Convert.ToDecimal(row["harga_jual"]);
                        else
                            hargaJual = 0;
                        if (row["diskon"] != DBNull.Value)
                            diskon = Convert.ToDecimal(row["diskon"]);
                        else
                            diskon = 0;
                        keterangan = row["keterangan"].ToString();
                        adapterLstPenjualan.Insert(penjualanID, barangID, quantity, hargaJual, diskon, keterangan);
                        Int32 stk=0;
                        stk = Convert.ToInt32(adapterStok.getStokFromBarangID(barangID));
                        adapterStok.UpdateQueryByBarangID(stk - quantity, barangID);
                    }
                    //hapus faktur------------
                    btnHapusFaktur_Click(sender, e);
                    //------------------------
                }
                else
                {
                    MessageBox.Show("Jumlah Pembayaran kurang dari total belanja", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                totalBelanja = getTotal();
                lblTotal.Text = totalBelanja.ToString("C");
                subTotalBelanja = getSubtotal();
                txtSubtotal.Text = subTotalBelanja.ToString("C");
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void numPotongan_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                totalBelanja = getTotal();
                lblTotal.Text = totalBelanja.ToString("C");
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void numTotalBayar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                totalBayar = numTotalBayar.Value;
                if (totalBayar >= totalBelanja) {
                    totalKembalian = totalBayar - totalBelanja;
                    txtKembalian.Text = totalKembalian.ToString("C");
                }
                else
                {
                    MessageBox.Show("Jumlah Pembayaran kurang dari total belanja", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                if (totalBayar >= totalBelanja)
                {
                    FormKwitansi frmKwitansi = new FormKwitansi();
                    //generate data
                    String data = "";
                    String total = "";
                    Decimal diskon = 0;
                    Decimal hargaJual = 0;
                    UInt32 qty = 0;
                    foreach (DataRow row in datasetPOS.tbl_listpenjualan_barang)
                    {
                        //data = String.Concat(data, row["nama_barang"].ToString(), "\n ", row["quantity"].ToString(), " x @", String.Format("{0:N0}", row["harga_jual"]));

                        qty = Convert.ToUInt32(row["quantity"]);
                        hargaJual = Convert.ToDecimal(row["harga_jual"]);
                        diskon = row["diskon"] == DBNull.Value ? 0 : Convert.ToDecimal(row["diskon"]);
                        data = String.Concat(data, row["nama_barang"].ToString(), "\n ", qty.ToString(), " x @", String.Format("{0:N0}", hargaJual- diskon),"     : ",String.Format("{0:N0}",qty * (hargaJual - diskon)));
                        data = String.Concat(data, "\n");
                        /*
                        if (row["diskon"] == DBNull.Value)
                        {
                            Decimal totalSatuan = 0;
                            totalSatuan = Convert.ToDecimal(row["harga_jual"]) * Convert.ToDecimal(row["quantity"]);
                            data = String.Concat(data, " : ", String.Format("{0:N0}", totalSatuan), "\n");
                        }
                        else
                        {
                            Decimal totalSatuan = 0;
                            totalSatuan = (Convert.ToDecimal(row["harga_jual"]) * Convert.ToDecimal(row["quantity"]) - Convert.ToDecimal(row["diskon"]));
                            data = String.Concat(data, "\n disc ", String.Format("{0:N0}", row["diskon"]));
                            data = String.Concat(data, " : ", String.Format("{0:N0}", totalSatuan), "\n");
                        }
                        */
                    }

                    total = String.Concat(total, "SubTotal : ", String.Format("{0:C0}", subTotalBelanja), "\n");
                    total = String.Concat(total, "Potongan : ", String.Format("{0:C0}", numPotongan.Value), "\n");
                    total = String.Concat(total, "Tunai : ", String.Format("{0:C0}", numTotalBayar.Value), "\n");
                    total = String.Concat(total, "Kembalian : ", String.Format("{0:C0}", totalKembalian), "\n");

                    frmKwitansi.print(data, total);
                }
                    else
                {
                        MessageBox.Show("Jumlah Pembayaran kurang dari total belanja", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
