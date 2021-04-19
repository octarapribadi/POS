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
        POSLog log;
        public FormStok()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
            log = new POSLog();
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
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();

                adapterBarang.Connection = konfigurasi.getKoneksi();
                adapterStokBarang.Connection = konfigurasi.getKoneksi();

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

                //log
                log.setLogStok(String.Format("[update] tbl_stok, item: {0} ({1} -> {2}) -=[{3}]=-",
                    cmbNamaBarang.Text,rowView["stok"], numStok.Value, 
                    numStok.Value-Convert.ToDecimal(rowView["stok"])>0? "Penambahan Stok" : "Pengurangan Stok"));
                //----

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

        private void tsbCari_Click(object sender, EventArgs e)
        {
            try
            {
                bsStok.Filter = tstCari.Text;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tstCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbCari_Click(sender, e);
            }
        }
    }
}
