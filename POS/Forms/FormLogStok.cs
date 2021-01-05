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
    public partial class FormLogStok : Form
    {
        Konfigurasi konfigurasi;
        public FormLogStok()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggalAwal, tanggalAkhir;
                tanggalAwal = dtpTanggalAwal.Value;
                tanggalAkhir = dtpTanggalAkhir.Value;
                adapterLogStok.FillByTanggal(datasetPOS.tbl_log_stok, tanggalAwal, tanggalAkhir);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    bsLog.Filter = txtFilter.Text;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFilter.Text == "Tekan 'Enter' setelah memasukan filter")
                txtFilter.Text = "";
        }

        private void txtFilter_MouseHover(object sender, EventArgs e)
        {
            if(txtFilter.Text=="")
                txtFilter.Text = "Tekan 'Enter' setelah memasukan filter";
        }

        private void txtFilter_MouseLeave(object sender, EventArgs e)
        {
            if(txtFilter.Text == "Tekan 'Enter' setelah memasukan filter")
                txtFilter.Text = "";
        }

        private void FormLogStok_Load(object sender, EventArgs e)
        {
            try
            {
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
