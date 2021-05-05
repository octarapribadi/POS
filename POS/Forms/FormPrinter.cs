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
    public partial class FormPrinter : Form
    {
        Konfigurasi konfigurasi = new Konfigurasi();
        String printerName;
        Int32 marginLeft, marginRight, marginTop, marginBottom, paperHeight, paperWidth;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                printerName = cmbPrinterName.Text;
                marginTop = Convert.ToInt32(numMarginAtas.Value);
                marginBottom = Convert.ToInt32(numMarginBawah.Value);
                marginLeft = Convert.ToInt32(numMarginKiri.Value);
                marginRight = Convert.ToInt32(numMarginKanan.Value);
                paperHeight = Convert.ToInt32(numPaperHeight.Value);
                paperWidth = Convert.ToInt32(numPaperWidth.Value);

                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                reg.SetValue("printerName", printerName);
                reg.SetValue("printerMarginBottom", marginBottom);
                reg.SetValue("printerMarginTop", marginTop);
                reg.SetValue("printerMarginLeft", marginLeft);
                reg.SetValue("printerMarginRight", marginRight);
                reg.SetValue("paperHeight", paperHeight);
                reg.SetValue("paperWidth", paperWidth);
                MessageBox.Show("Konfigurasi printer berhasil disimpan");
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        public FormPrinter()
        {
            InitializeComponent();
           
        }

        private void FormPrinter_Load(object sender, EventArgs e)
        {
            try
            {
                this.Font = konfigurasi.getFont();
                this.BackColor = konfigurasi.getBackColor();
                this.ForeColor = konfigurasi.getFontColor();
                PrinterSettings.StringCollection printers = PrinterSettings.InstalledPrinters;
                foreach (String printer in printers)
                    cmbPrinterName.Items.Add(printer);

                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS", true);
                printerName = (String)reg.GetValue("printerName");
                marginTop = (Int32)reg.GetValue("printerMarginTop");
                marginBottom = (Int32)reg.GetValue("printerMarginBottom");
                marginLeft = (Int32)reg.GetValue("printerMarginLeft");
                marginRight = (Int32)reg.GetValue("printerMarginRight");
                paperHeight = (Int32)reg.GetValue("paperHeight");
                paperWidth = (Int32)reg.GetValue("paperWidth");
                cmbPrinterName.Text = printerName;
                numMarginAtas.Value = marginTop;
                numMarginBawah.Value = marginBottom;
                numMarginKiri.Value = marginLeft;
                numMarginKanan.Value = marginRight;
                numPaperHeight.Value = paperHeight;
                numPaperWidth.Value = paperWidth;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
        }
    }
}
