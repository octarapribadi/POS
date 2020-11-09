using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POS.Forms
{
    public partial class FormRestok : Form
    {
        Konfigurasi konfigurasi = new Konfigurasi();
        AksesKontrol aksesKontrol = new AksesKontrol();
        private String user;
        public FormRestok()
        {
            InitializeComponent();
            this.splitContainer1.Orientation = konfigurasi.getSplitContainerOrientation();
            this.splitContainer1.SplitterDistance = konfigurasi.splitterDistance;
            user = user;
        }

        private void FormRestok_Load(object sender, EventArgs e)
        {
            if (aksesKontrol.getAkses(user, "tbl_restok", "select"))
            {
                if (aksesKontrol.getAkses(user, "tbl_barang", "select"))
                {
                    if (aksesKontrol.getAkses(user, "tbl_kategori", "select"))
                    {
                        if (aksesKontrol.getAkses(user, "tbl_supplier", "select"))
                        {
                            if (aksesKontrol.getAkses(user, "tbl_satuan", "select"))
                            {
                                if (aksesKontrol.getAkses(user, "tbl_stok", "select"))
                                {
                                    try
                                    {
                                        adapterFormRestok.Fill(this.datasetPOS1.tbl_formrestok);
                                        adapterRestok.Fill(datasetPOS1.tbl_restok);
                                        adapterbarang.Fill(datasetPOS1.tbl_barang);
                                        adapterKategori.Fill(datasetPOS1.tbl_kategori);
                                        adapterSupplier.Fill(datasetPOS1.tbl_supplier);
                                        adapterSatuan.Fill(datasetPOS1.tbl_satuan);
                                        adapterStok.Fill(datasetPOS1.tbl_stok);

                                        //testing data
                                        /*
                                        DataRow row;
                                        row = datasetPOS1.tbl_barang.NewRow();
                                        row["barang_id"] = 1;
                                        row["nama_barang"] = "apel";
                                        datasetPOS1.tbl_barang.Rows.Add(row);

                                        row = datasetPOS1.tbl_barang.NewRow();
                                        row["barang_id"] = 2;
                                        row["nama_barang"] = "Berry";
                                        datasetPOS1.tbl_barang.Rows.Add(row);

                                        row = datasetPOS1.tbl_barang.NewRow();
                                        row["barang_id"] = 3;
                                        row["nama_barang"] = "Cerry";
                                        datasetPOS1.tbl_barang.Rows.Add(row);
                                        */
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error, harap hubungi administrator\n" + ex.Message);
                                    }
                                }
                                else MessageBox.Show(aksesKontrol.tampilkanPesanAksesDitolak(user, "tbl_stok", "select"));
                            }
                            else MessageBox.Show(aksesKontrol.tampilkanPesanAksesDitolak(user, "tbl_satuan", "select"));
                        }
                        else MessageBox.Show(aksesKontrol.tampilkanPesanAksesDitolak(user, "tbl_supplier", "select"));
                    }
                    else MessageBox.Show(aksesKontrol.tampilkanPesanAksesDitolak(user, "tbl_kategori", "select"));
                }
                else MessageBox.Show(aksesKontrol.tampilkanPesanAksesDitolak(user, "tbl_barang", "select"));
            }
            else MessageBox.Show(aksesKontrol.tampilkanPesanAksesDitolak(user, "tbl_restok", "select"));
        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            Boolean newBarang=false;
            int index = -1;
            //cmdbarang
            index = bsBarang.Find("barang_id", cmbNamaBarang.SelectedValue);
            tstCari.Text = index.ToString();
            if (index == -1) newBarang = true;

            //cek hak akses
            if (aksesKontrol.getAkses(user, "tbl_barang", "insert"))
            {
                try
                {
                    if (newBarang)
                    {
                        DataRow row = datasetPOS1.tbl_barang.NewRow();
                        row["nama_barang"] = cmbNamaBarang.Text;
                        datasetPOS1.tbl_barang.Rows.Add(row);
                        adapterbarang.Insert(row["nama_barang"].ToString(), null, null, null, null, null, null, null);
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error, harap hubungi administrator\n" + ex.Message);
                }
                finally
                {
                    clearform();
                }
            }
            else
            {
                MessageBox.Show(aksesKontrol.tampilkanPesanAksesDitolak(user, "tbl_barang", "insert"));
            }         
        }

        private void clearform()
        {
            bsBarang.Position = -1;
            cmbNamaBarang.Text = "";
        }


        private void tsbReset_Click(object sender, EventArgs e)
        {
            tstCari.Text = cmbNamaBarang.SelectedValue.ToString();
        }
    }
}
