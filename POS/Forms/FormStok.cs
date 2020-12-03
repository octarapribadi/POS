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
    public partial class FormStok : Form
    {
        Konfigurasi konfigurasi;
        public FormStok()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
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

        private void FormStok_Load(object sender, EventArgs e)
        {
            try
            {
                adapterStokBarang.Fill(datasetPOS.tbl_stok_barang);
                adapterBarang.Fill(datasetPOS.tbl_barang);
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 stokID;
                DataRowView rowView = (DataRowView)bsStok.Current;
                stokID = Convert.ToInt32(rowView["stok_id"]);
                rowView.Row["stok"] = numStok.Value;
                rowView.Row["keterangan"] = txtKeterangan.Text;
                adapterStokBarang.UpdateQueryByStokID(Convert.ToInt32(numStok.Value), txtKeterangan.Text, stokID);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
