using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using POS.Properties;

namespace POS.Forms
{

    public partial class FormHome : Form
    {
        Konfigurasi konfigurasi = new Konfigurasi();
        Akun akun;
        Boolean login = false;

        public void setLogin(Akun akun)
        {
            this.akun = akun;
            tssUser.Text = akun.getUsername();
            login = true;
            tssUser.BackColor = Color.Green;
            lOGINToolStripMenuItem.Text = "LOGOUT";
            lOGINToolStripMenuItem.Image = Resources.arrow_right_from_bracket;
        }

        public Akun getAkun()
        {
            return akun;
        }

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
            try
            {
                tssVersi.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                this.Icon = POS.Properties.Resources.icon;
                konfigurasi.createRegistryBaseDir();
                //this.Font = new Font(konfigurasi.getRegistryValue("fontFamily").ToString(), Convert.ToSingle(konfigurasi.getRegistryValue("fontSize")), FontStyle.Regular);
                this.Font = new Font("arial", 8);
                //MessageBox.Show("tes");
                menuStrip1.Font = konfigurasi.getFont();
                menuStrip1.ForeColor = konfigurasi.getFontColor();
                menuStrip1.BackColor = konfigurasi.getBackColor();

                statusStrip1.Font = konfigurasi.getFont();
                statusStrip1.ForeColor = konfigurasi.getFontColor();
                statusStrip1.BackColor = konfigurasi.getBackColor();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
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

        private void stokToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FormDialog frmDialog = new FormDialog();
            frmDialog.MdiParent = this;
            frmDialog.form = "log_stok";
            frmDialog.parent = this;
            frmDialog.Show();
        }

        private void tAMPILANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTampilan frmTampilan = null;
            frmTampilan = new FormTampilan();
            frmTampilan.MdiParent = this;
            frmTampilan.Show();
        }

        public void setTampilanCallBack()
        {
            menuStrip1.Font = konfigurasi.getFont();
            menuStrip1.ForeColor = konfigurasi.getFontColor();
            menuStrip1.BackColor = konfigurasi.getBackColor();
        }

        private void dATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatabase frmDatabase = null;
            frmDatabase = new FormDatabase();
            frmDatabase.MdiParent = this;
            frmDatabase.Show();
        }

        private void pRINTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrinter frmPrinter = null;
            frmPrinter = new FormPrinter();
            frmPrinter.MdiParent = this;
            frmPrinter.Show();
        }

        private void vERIFIKASIDATABASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseVerification dv = new DatabaseVerification();
            if (dv.verify())
                MessageBox.Show("Database berhasil diverifikasi");
            else
                MessageBox.Show("Database gagal diverifikasi, hubungi administrator");
        }

        private void lOGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDialog frmDialog = new FormDialog();
            frmDialog.MdiParent = this;
            frmDialog.form = "log_stok";
            frmDialog.parent = this;
            frmDialog.Show();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == false)
            {
                FormLogin frmLogin = new FormLogin();
                frmLogin.MdiParent = this;
                frmLogin.Show();
            }
            else
            {
                login = false;
                tssUser.Text = "[belum login]";
                tssUser.BackColor = Color.Red;
                lOGINToolStripMenuItem.Text = "LOGIN";
                lOGINToolStripMenuItem.Image = Resources.arrow_right_to_bracket;
            }
        }

        private void pENGGUNAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPengguna frmPengguna = new FormPengguna();
            frmPengguna.MdiParent = this;
            frmPengguna.Show();
        }

        private void hAKAKSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHakAkses frmHakAkses = new FormHakAkses();
            frmHakAkses.MdiParent = this;
            frmHakAkses.Show();
        }
    }
}
