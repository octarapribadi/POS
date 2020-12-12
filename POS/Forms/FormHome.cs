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
    public partial class FormHome : Form
    {
        public Boolean val=false;
        public FormHome()
        {
            InitializeComponent();
        }

        private void kELUARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kATEGORIToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormKategori frmKategori;
            frmKategori = new FormKategori();
            frmKategori.MdiParent = this;
            frmKategori.Show();
            

        }

        private void dATABARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang frmBarang = null;
            frmBarang = new FormBarang();
            frmBarang.MdiParent = this;
            frmBarang.Show();
        }

        private void sUPPLIERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier frmSupplier = null;
            frmSupplier = new FormSupplier();
            frmSupplier.MdiParent = this;
            frmSupplier.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            this.Icon = POS.Properties.Resources.icon;
        }

        private void hARGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHarga frmHarga = null;
            frmHarga = new FormHarga();
            frmHarga.MdiParent = this;
            frmHarga.Show();
        }

        private void sTOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            FormStok frmStok = new FormStok();
            frmStok.MdiParent = this;
            frmStok.Show();
            */
            FormDialog frmDialog = new Forms.FormDialog();
            frmDialog.MdiParent = this;
            frmDialog.form = "stok";
            frmDialog.parent = this;
            frmDialog.Show();
        }

        private void bARANGMASUKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRestok frmRestok = null;
            frmRestok = new FormRestok();
            frmRestok.MdiParent = this;
            frmRestok.Show();
        }

        private void pENJUALANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenjualan frmPenjualan = null;
            frmPenjualan = new FormPenjualan();
            frmPenjualan.MdiParent = this;
            frmPenjualan.Show();
        }

        private void pENJUALANToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDialog frmDialog = new FormDialog();
            frmDialog.MdiParent = this;
            frmDialog.form = "penjualan";
            frmDialog.parent = this;
            frmDialog.Show();
        }

        private void bARANGKELUARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeluarBarang frmKeluarBarang = null;
            frmKeluarBarang = new FormKeluarBarang();
            frmKeluarBarang.MdiParent = this;
            frmKeluarBarang.Show();
        }

        private void lAPORANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sTOKBARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanRestok frmLaporanRestok = null;
            frmLaporanRestok = new FormLaporanRestok();
            frmLaporanRestok.MdiParent = this;
            frmLaporanRestok.Show();
        }
    }
}
