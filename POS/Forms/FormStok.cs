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
    public partial class FormStok : Form
    {
        Konfigurasi konfigurasi;
        public FormStok()
        {
            InitializeComponent();
            konfigurasi = new Konfigurasi();
        }

        private void splitContainer1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (splitContainer1.Orientation == Orientation.Horizontal)
                    splitContainer1.Orientation = Orientation.Vertical;
                else
                    splitContainer1.Orientation = Orientation.Horizontal;
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void FormStok_Load(object sender, EventArgs e)
        {
            adapterStokBarang.Fill(datasetPOS.tbl_stok_barang);
        }
    }
}
