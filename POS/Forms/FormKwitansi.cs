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
using Microsoft.Win32;

namespace POS.Forms
{
    public partial class FormKwitansi : Form
    {
        Konfigurasi konfigurasi;
        public FormKwitansi()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
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
            /*
            try
            {
                String printerName;
                Int32 marginLeft, marginRight, marginTop, marginBottom, paperHeight, paperWidth;

                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                printerName = (String)reg.GetValue("printerName");
                marginTop = (Int32)reg.GetValue("printerMarginTop");
                marginBottom = (Int32)reg.GetValue("printerMarginBottom");
                marginLeft = (Int32)reg.GetValue("printerMarginLeft");
                marginRight = (Int32)reg.GetValue("printerMarginRight");
                paperHeight = (Int32)reg.GetValue("paperHeight");
                paperWidth = (Int32)reg.GetValue("paperWidth");

                Margins margin = new Margins(marginLeft, marginRight, marginTop, marginBottom);
                paperHeight = Convert.ToInt32(Math.Round(paperHeight * 0.0264583333, 0));
                paperWidth = Convert.ToInt32(Math.Round(paperWidth * 0.0264583333, 0));


                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize(printerName, paperWidth, paperHeight);
                printDocument1.DefaultPageSettings.Margins = margin;
                printDocument1.OriginAtMargins = true;
                printDocument1.Print();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            */
        }
        public void print(String data, String total)
        {
            try
            {
                labelList.Text = data;
                labelList.Font = new Font("Courier New", Convert.ToSingle(konfigurasi.getRegistryValue("kwitansiFontSize")));
                labelTotal.Text = total;
                labelTotal.Font = new Font("Courier New", Convert.ToSingle(konfigurasi.getRegistryValue("kwitansiFontSize")));
                lblTanggalKwitansi.Text = "tgl: ";
                lblTanggalKwitansi.Text += DateTime.Now.Date.ToString("dd MMMM yyyy") + "\n";
                lblTanggalKwitansi.Text += "\n";

                String printerName;
                Int32 marginLeft, marginRight, marginTop, marginBottom, paperHeight, paperWidth;

                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                printerName = (String)reg.GetValue("printerName");
                marginTop = (Int32)reg.GetValue("printerMarginTop");
                marginBottom = (Int32)reg.GetValue("printerMarginBottom");
                marginLeft = (Int32)reg.GetValue("printerMarginLeft");
                marginRight = (Int32)reg.GetValue("printerMarginRight");
                paperHeight = (Int32)reg.GetValue("paperHeight");
                paperWidth = (Int32)reg.GetValue("paperWidth");

                Margins margin = new Margins(marginLeft, marginRight, marginTop, marginBottom);
                paperHeight = Convert.ToInt32(Math.Round(paperHeight / 0.0264583333,0));
                paperWidth = Convert.ToInt32(Math.Round(paperWidth / 0.0264583333, 0));

                printDocument1.PrinterSettings.PrinterName = printerName;
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("custom", paperWidth, paperHeight);
                //printDocument1.DefaultPageSettings.PaperSize = new PaperSize("custom", 1000, 1000);
                printDocument1.DefaultPageSettings.Margins = margin;
                printDocument1.OriginAtMargins = true;
                printDocument1.Print();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
