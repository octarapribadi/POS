using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POS.Forms
{
    public partial class FormRestok : Form
    {
        Konfigurasi konfigurasi = new Konfigurasi();
        Boolean newBarang = false;
        Boolean newSatuan = false;
        Boolean newKategori = false;
        Boolean newSupplier = false;
        Boolean newHarga = false;

        public FormRestok()
        {
            InitializeComponent();
            this.splitContainer1.Orientation = konfigurasi.getSplitContainerOrientation();
            this.splitContainer1.SplitterDistance = konfigurasi.splitterDistance;
        }

        private void FormRestok_Load(object sender, EventArgs e)
        {
            clearform();
            try
            {
                adapterFormRestok.Fill(datasetPOS1.tbl_formrestok);
                adapterRestok.Fill(datasetPOS1.tbl_restok);
                adapterBarang.Fill(datasetPOS1.tbl_barang);
                adapterKategori.Fill(datasetPOS1.tbl_kategori);
                adapterSupplier.Fill(datasetPOS1.tbl_supplier);
                adapterSatuan.Fill(datasetPOS1.tbl_satuan);
                adapterStok.Fill(datasetPOS1.tbl_stok);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, harap hubungi administrator\n" + ex.Message);
            }
            clearform();                 
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {

            try
            {
                newBarang = apakahObjekAda("barang_id", bsBarang, cmbNamaBarang.SelectedValue);
                newSatuan = apakahObjekAda("satuan_id", bsSatuan, cmbSatuan.SelectedValue);
                newKategori = apakahObjekAda("kategori_id", bsKategori, cmbKategori.SelectedValue);
                newSupplier = apakahObjekAda("supplier_id", bsSupplier, cmbSupplier.SelectedValue);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, harap hubungi administrator\n" + ex.Message);
            }

            try
            {
                
                if (!newBarang)
                {
                    DataRow row = datasetPOS1.tbl_barang.NewRow();
                    row["nama_barang"] = cmbNamaBarang.Text;
                    datasetPOS1.tbl_barang.Rows.Add(row);
                    adapterBarang.Insert(row["nama_barang"].ToString(), null, null, null, null, null, null, null);
                }
                
                if (!newSatuan)
                {
                    DataRow row = datasetPOS1.tbl_satuan.NewRow();
                    row["satuan"] = cmbSatuan.Text;
                    datasetPOS1.tbl_satuan.Rows.Add(row);
                    adapterSatuan.Insert(row["satuan"].ToString(), true, null);
                }
                
                if (!newKategori)
                {
                    DataRow row = datasetPOS1.tbl_kategori.NewRow();
                    row["kategori"] = cmbKategori.Text;
                    datasetPOS1.tbl_kategori.Rows.Add(row);
                    adapterKategori.Insert(row["kategori"].ToString(), null, true);
                }

                if (!newSupplier)
                {
                    DataRow row = datasetPOS1.tbl_supplier.NewRow();
                    row["nama_supplier"] = cmbSupplier.Text;
                    datasetPOS1.tbl_supplier.Rows.Add(row);
                    adapterSupplier.Insert(row["nama_supplier"].ToString(),null,null,null,true,null);
                }
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error, harap hubungi administrator\n" + ex.Message);
            }
            finally
            {
                clearform();
            }
            
      
        }

        private void clearform()
        {
            bsBarang.Position = -1;
            cmbNamaBarang.Text = "";
            bsSatuan.Position = -1;
            cmbSatuan.Text = "";
            bsKategori.Position = -1;
            cmbKategori.Text = "";
            bsSupplier.Position = -1;
            cmbSupplier.Text = "";
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            tstCari.Text = cmbNamaBarang.SelectedValue.ToString();
        }

        private bool apakahObjekAda(string query, BindingSource bs, Object obj)
        {
            int index = -1;
            index = bs.Find(query, obj);
            if (index == -1)
                return false;
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsHarga.Filter = String.Format("barang_id = {0} and supplier_id = {1}", cmbNamaBarang.SelectedValue, cmbSupplier.SelectedValue);
            
        }

        private void txtHargaModal_Leave(object sender, EventArgs e)
        {

            txtHargaModal.Tag = txtHargaModal.Value;
            
        }

        private void txtHargaModal_Enter(object sender, EventArgs e)
        {

        }

        private object getCurrentBindingSourceItem(BindingSource bs, String colName)
        {
            DataRowView rowView = (DataRowView)bs.Current;
            return rowView.Row[colName];
        }

        private void cmbNamaBarang_Leave(object sender, EventArgs e)
        {
            newBarang = apakahObjekAda("barang_id", bsBarang, cmbNamaBarang.SelectedValue);
            if (newBarang)
            {
                cmbSatuan.SelectedValue = getCurrentBindingSourceItem(bsBarang, "satuan_id");
                cmbSupplier.SelectedValue = getCurrentBindingSourceItem(bsBarang, "supplier_id");
                cmbKategori.SelectedValue = getCurrentBindingSourceItem(bsBarang, "kategori_id");

                adapterHarga.FillByBarangID(datasetPOS1.tbl_harga,Convert.ToInt32(cmbNamaBarang.SelectedValue));

            }

        }

        private void tes(object sender, EventArgs e)
        {
            
            MessageBox.Show("tes");
        }

        private void cmbNamaBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cmbNamaBarang_Leave(sender, e);
            }
        }
    }
}
