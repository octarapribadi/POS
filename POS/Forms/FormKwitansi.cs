using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace POS.Forms
{
    public partial class FormKwitansi : Form
    {
        public FormKwitansi()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<Control> controls = tableLayoutPanel1.Controls.OfType<Label>().Cast<Control>().ToList();
            foreach(Control c in controls)
            {
                e.Graphics.DrawString(c.Text, c.Font, new SolidBrush(Color.Black), c.Left, c.Top);
            }
            //e.Graphics.DrawString(label1.Text, new Font("Courier New", 10), new SolidBrush(Color.Black), label1.Left, label1.Top);
        }

        private void FormKwitansi_Load(object sender, EventArgs e)
        {
            Margins margin = new Margins(0, 0, 0, 0);
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pos", 228, 1000);
            printDocument1.DefaultPageSettings.Margins = margin;
            printDocument1.OriginAtMargins = true;
            printDocument1.Print();
        }
        public void print(String data, String total)
        {
            labelList.Text = data;
            labelTotal.Text = total;
            lblTanggalKwitansi.Text = "tgl: ";
            lblTanggalKwitansi.Text += DateTime.Now.Date.ToString("dd MMMM yyyy");
            lblTanggalKwitansi.Text += "\n";
            Margins margin = new Margins(0, 0, 0, 0);
            
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pos", 188, 1000);
            printDocument1.DefaultPageSettings.Margins = margin;
            printDocument1.OriginAtMargins = true;
            printDocument1.Print();
        }
    }
}
