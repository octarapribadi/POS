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
        Konfigurasi konfigurasi;
        //barcode barang
        String mode = "barcode";
        public FormPenjualan()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void cmbBarang_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Int64 penjualanID = 0;
                Int64 listItemID = 0;
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
                    var maxPenjualanID = adapterPenjualan.getMaxPenjualanID();
                    if (maxPenjualanID == null)
                        penjualanID = 1;
                    else
                        penjualanID = Convert.ToInt64(maxPenjualanID);
                    lblFaktur.Text = penjualanID.ToString("FK_0000000000");

                    var maxListItemID = adapterLstPenjualan.getMaxListPenjualanID();
                    if (maxListItemID == null)
                        listItemID = 1;
                    else
                        listItemID = Convert.ToInt64(maxListItemID);

                    DataRow row = datasetPOS.tbl_listpenjualan_barang.NewRow();
                    
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
                adapterBarang.Fill(datasetPOS.tbl_barang);
                adapterPenjualan.Fill(datasetPOS.tbl_penjualan);
                cmbBarang.Enabled = false;
                KeyPreview = true;
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
            try
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
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void btnHapusFaktur_Click(object sender, EventArgs e)
        {
            try
            {
                cmbBarang.Enabled = false;
                cmbBarang.Text = "";
                cmbBarang.DataSource = null;
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                return max + 1;
            }
        }
    }
}
