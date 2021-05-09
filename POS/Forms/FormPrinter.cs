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
        Decimal marginLeft, marginRight, marginTop, marginBottom, paperHeight, paperWidth;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                printerName = cmbPrinterName.Text;
                marginTop = numMarginAtas.Value;
                marginBottom = numMarginBawah.Value;
                marginLeft = numMarginKiri.Value;
                marginRight = numMarginKanan.Value;
                paperHeight = numPaperHeight.Value;
                paperWidth = numPaperWidth.Value;

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
                marginTop = Convert.ToDecimal(reg.GetValue("printerMarginTop"));
                marginBottom = Convert.ToDecimal(reg.GetValue("printerMarginBottom"));
                marginLeft = Convert.ToDecimal(reg.GetValue("printerMarginLeft"));
                marginRight = Convert.ToDecimal(reg.GetValue("printerMarginRight"));
                paperHeight = Convert.ToDecimal(reg.GetValue("paperHeight"));
                paperWidth = Convert.ToDecimal(reg.GetValue("paperWidth"));
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
