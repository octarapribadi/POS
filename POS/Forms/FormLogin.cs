using POS.Forms;
using System;
using System.Windows.Forms;

namespace POS
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if(username=="octarapribadi" && password == "stmiktime")
            {
                FormHome frmHome = (FormHome)this.MdiParent;
                frmHome.setLogin(new Akun("Octara Pribadi", "octarapribadi", true));
                this.Close();
            }
            
        }
    }
}
