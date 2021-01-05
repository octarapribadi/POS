using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Microsoft.Win32;

namespace POS.Forms
{
    public partial class FormTampilan : Form
    {
        Konfigurasi konfigurasi;

        public FormTampilan()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void FormTampilan_Load(object sender, EventArgs e)
        {
            try
            {

                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();

                InstalledFontCollection fontCollection = new InstalledFontCollection();
                foreach (FontFamily f in fontCollection.Families)
                {
                    cmbJenisTulisan.Items.Add(f.Name);
                }

                foreach(KnownColor color in Enum.GetValues(typeof(KnownColor))){
                    cmbWarnaTulisan.Items.Add(color.ToString());
                }

                foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
                {
                    cmbWarnaForm.Items.Add(color.ToString());
                }

                cmbJenisTulisan.Text = konfigurasi.getRegistryValue("fontFamily").ToString();
                cmbJenisTulisan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbJenisTulisan.AutoCompleteSource = AutoCompleteSource.ListItems;

                cmbWarnaTulisan.Text = konfigurasi.getRegistryValue("fontColor").ToString();
                cmbWarnaTulisan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbWarnaTulisan.AutoCompleteSource = AutoCompleteSource.ListItems;

                cmbWarnaForm.Text = konfigurasi.getRegistryValue("backColor").ToString();
                cmbWarnaForm.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbWarnaForm.AutoCompleteSource = AutoCompleteSource.ListItems;

                numUkuranTulisan.Value = Convert.ToDecimal(konfigurasi.getRegistryValue("fontSize"));

            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\POS",true);
                reg.SetValue("fontFamily",cmbJenisTulisan.Text);
                reg.SetValue("fontSize", numUkuranTulisan.Value);
                reg.SetValue("fontColor", cmbWarnaTulisan.Text);
                reg.SetValue("backColor", cmbWarnaForm.Text);
                MessageBox.Show("Tampilan berhasil disimpan");
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();
                
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }
    }
}
