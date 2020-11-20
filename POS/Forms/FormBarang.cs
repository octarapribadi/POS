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
    public partial class FormBarang : Form
    {
        int bsBarangViewPosition = -1;
        public FormBarang()
        {
            InitializeComponent();
        }

        private void txtHargaModal_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetPOS1.tbl_barang_view' table. You can move, or remove it, as needed.
            this.tbl_barang_viewTableAdapter.Fill(this.datasetPOS1.tbl_barang_view);
            adapterBarangView.Fill(datasetPOS1.tbl_barang_view);
            adapterKategori.Fill(datasetPOS1.tbl_kategori);
            adapterSatuan.Fill(datasetPOS1.tbl_satuan);
            adapterSupplier.Fill(datasetPOS1.tbl_supplier);
            
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = "";
            cmbNamaBarang.Text = "";
            cmbNamaBarang.SelectedIndex = -1;
            cmbSatuan.Text = "";
            cmbSatuan.SelectedIndex = -1;
            cmbKategori.Text = "";
            cmbKategori.SelectedIndex = -1;
            cmbSupplier.Text = "";
            cmbSupplier.SelectedIndex = -1;
            txtKeterangan.Text = "";
            numHargaModal.Value = 0;
            numHargaJual.Value = 0;
            txtKodeBarang.Text = "";
            chkAktif.Checked = true;
            bsBarangView.Position = -1;
            cmbNamaBarang.Focus();
        }

        private void bsBarangView_PositionChanged(object sender, EventArgs e)
        {
            bsBarangViewPosition = bsBarangView.Position;
        }

        private DataRowView getDataRowViewFromBS(BindingSource bs)
        {
            DataRowView rowView = (DataRowView)bs.Current;
            return rowView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView rowView = getDataRowViewFromBS(bsBarangView);
            txtKodeBarang.Text = rowView.Row["barang_id"].ToString();
            cmbNamaBarang.Text = rowView.Row["nama_barang"].ToString();
            cmbKategori.Text = rowView.Row["kategori"].ToString();
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    bsBarangView.Filter = tstCari.Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error, harap hubungi administrator\n" + ex.Message);
                }
            }
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text == "")
            {
                Int32 kodeBarang;
                DataRow row = datasetPOS1.tbl_barang_view.NewRow();
                row["nama_barang"] = cmbNamaBarang.Text;
                datasetPOS1.tbl_barang_view.Rows.Add(row);
                kodeBarang = Convert.ToInt32(row["barang_id"]);
                MessageBox.Show(kodeBarang.ToString());
            }
            else
            {

            }
            
        }
    }
}
