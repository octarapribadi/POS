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
    public partial class FormLaporanRestok : Form
    {
        Konfigurasi konfigurasi;
        public FormLaporanRestok()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            try
            {
                adapterLaporanRestok.Connection = konfigurasi.getKoneksi();
                adapterLaporanRestok.FillByTanggalRestok(datasetPOS.tbl_laporan_restok, dtpTanggalAwal.Value, dtpTanggalAkhir.Value);
                reportReStok.SetDataSource((DataTable)datasetPOS.tbl_laporan_restok);
                reportReStok.SetParameterValue("tanggalAwal", dtpTanggalAwal.Value);
                reportReStok.SetParameterValue("tanggalAkhir", dtpTanggalAkhir.Value);
                crystalReportViewer1.ReportSource = reportReStok;
                
                crystalReportViewer1.Refresh();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void FormLaporanRestok_Load(object sender, EventArgs e)
        {
            this.Font = konfigurasi.getFont();
            this.ForeColor = konfigurasi.getFontColor();
            this.BackColor = konfigurasi.getBackColor();

            //adapterLaporanRestok.Connection = konfigurasi.getKoneksi();
        }
    }
}
