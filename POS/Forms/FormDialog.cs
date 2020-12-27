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
    public partial class FormDialog : Form
    {
        public String form;
        public Form parent;
        public FormDialog()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            String password = "sukses99";
            
            if(txtPassword.Text == password)
            {
                if (form == "penjualan")
                {
                    FormLaporanPenjualan frmLaporanPenjualan = null;
                    frmLaporanPenjualan = new FormLaporanPenjualan();
                    frmLaporanPenjualan.MdiParent = parent;
                    frmLaporanPenjualan.Show();
                    this.Close();
                }
                if (form == "stok")
                {
                    FormStok frmStok = null;
                    frmStok = new FormStok();
                    frmStok.MdiParent = parent;
                    frmStok.Show();
                    this.Close();
                }
                if(form == "log_stok")
                {
                    FormLogStok frmLogStok = null;
                    frmLogStok = new FormLogStok();
                    frmLogStok.MdiParent = parent;
                    frmLogStok.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Password Salah", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
