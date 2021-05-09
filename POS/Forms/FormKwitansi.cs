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
                Double marginLeft, marginRight, marginTop, marginBottom, paperHeight, paperWidth;
                Int32 marginLeft_, marginRight_, marginTop_, marginBottom_, paperHeight_, paperWidth_;

                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                printerName = (String)reg.GetValue("printerName");
                marginTop = Convert.ToDouble(reg.GetValue("printerMarginTop"));
                marginBottom = Convert.ToDouble(reg.GetValue("printerMarginBottom"));
                marginLeft = Convert.ToDouble(reg.GetValue("printerMarginLeft"));
                marginRight = Convert.ToDouble(reg.GetValue("printerMarginRight"));
                paperHeight = Convert.ToDouble(reg.GetValue("paperHeight"));
                paperWidth = Convert.ToDouble(reg.GetValue("paperWidth"));

                marginLeft_ = Convert.ToInt32(Math.Round(marginLeft / 0.0264583333, 0));
                marginRight_ = Convert.ToInt32(Math.Round(marginRight / 0.0264583333, 0));
                marginTop_ = Convert.ToInt32(Math.Round(marginTop / 0.0264583333, 0));
                marginBottom_ = Convert.ToInt32(Math.Round(marginBottom / 0.0264583333, 0));

                Margins margin = new Margins(marginLeft_, marginRight_, marginTop_, marginBottom_);
                paperHeight_ = Convert.ToInt32(Math.Round(paperHeight / 0.0264583333,0));
                paperWidth_ = Convert.ToInt32(Math.Round(paperWidth / 0.0264583333, 0));

                printDocument1.PrinterSettings.PrinterName = printerName;
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("custom", paperWidth_, paperHeight_);
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
