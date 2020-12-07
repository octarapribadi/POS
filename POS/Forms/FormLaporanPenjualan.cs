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
    public partial class FormLaporanPenjualan : Form
    {
        Konfigurasi konfigurasi;
        public FormLaporanPenjualan()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            try
            {
                adapterLaporanPenjualan.FillByTanggal(datasetPOS.tbl_laporan_penjualan, dtpTanggalAwal.Value, dtpTanggalAkhir.Value);
                reportPenjualan1.SetDataSource(datasetPOS);
                
                crystalReportViewer1.ReportSource = reportPenjualan1;
                crystalReportViewer1.Refresh();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
