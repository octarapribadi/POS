using System;
using System.Data;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class FormBarang : Form
    {
        Konfigurasi konfigurasi = new Konfigurasi();
        
        int bsBarangViewPosition = -1;
        public FormBarang()
        {
            InitializeComponent();
        }


        private void FormBarang_Load(object sender, EventArgs e)
        {
            try
            {
                this.Font = konfigurasi.getFont();
                this.ForeColor = konfigurasi.getFontColor();
                this.BackColor = konfigurasi.getBackColor();

                adapterSatuan.Connection = konfigurasi.getKoneksi();
                adapterHarga.Connection = konfigurasi.getKoneksi();
                adapterStok.Connection = konfigurasi.getKoneksi();
                adapterKategori.Connection = konfigurasi.getKoneksi();
                adapterBarangView.Connection = konfigurasi.getKoneksi();
                adapterBarang.Connection = konfigurasi.getKoneksi();
                adapterSupplier.Connection = konfigurasi.getKoneksi();

                adapterBarangView.FillByDefaultHarga(datasetPOS1.tbl_barang_view);
                adapterKategori.Fill(datasetPOS1.tbl_kategori);
                adapterSatuan.Fill(datasetPOS1.tbl_satuan);
                adapterSupplier.Fill(datasetPOS1.tbl_supplier);
                adapterHarga.Fill(datasetPOS1.tbl_harga);
                adapterStok.Fill(datasetPOS1.tbl_stok);
                tsbReset_Click(sender, e);
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtBarcode.Text = "";
                cmbNamaBarang.Text = "";
                cmbNamaBarang.SelectedIndex = -1;
                cmbSatuan.Text = "";
                cmbSatuan.SelectedIndex = -1;
                cmbKategori.Text = "";
                cmbKategori.SelectedIndex = -1;
                cmbSupplier.Text = "";
                cmbSupplier.SelectedIndex = -1;
                txtKeterangan.Text = "";
                numHargaModal.Value = 0;
                numHargaJual.Value = 0;
                txtKodeBarang.Text = "";
                chkAktif.Checked = true;
                numStok.Value = 0;
                bsBarangView.Position = -1;
                cmbNamaBarang.Focus();
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void bsBarangView_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                bsBarangViewPosition = bsBarangView.Position;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private DataRowView getDataRowViewFromBS(BindingSource bs)
        {
            DataRowView rowView = (DataRowView)bs.Current;
            return rowView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView rowView = getDataRowViewFromBS(bsBarangView);
                txtKodeBarang.Text = rowView.Row["barang_id"].ToString();
                cmbNamaBarang.Text = rowView.Row["nama_barang"].ToString();
                cmbKategori.Text = rowView.Row["kategori"].ToString();
                chkAktif.Checked = (Boolean)rowView["aktif"];
                cmbSatuan.Text = rowView.Row["satuan"].ToString();
                cmbSupplier.Text = rowView.Row["nama_supplier"].ToString();
                txtBarcode.Text = rowView.Row["kode_barcode"].ToString();
                numHargaModal.Value = Convert.ToDecimal(rowView.Row["harga_model"]);
                numHargaJual.Value = Convert.ToDecimal(rowView.Row["harga_jual"]);

                numStok.Value = Convert.ToDecimal(rowView.Row["stok"]);

            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
        }

        private void txtCari_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    bsBarangView.Filter = tstCari.Text;
                }
            }
            catch (Exception ex)
            {
                konfigurasi.showError(ex);
            }

        }

        private void tsbSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKodeBarang.Text == "")
                {
                    if (cmbNamaBarang.Text == "")
                    {
                        MessageBox.Show("Silahkan masukan nama barang!");
                        tsbReset_Click(sender, e);
                    }
                    else
                    {

                        DataRow row, rowSupplier, rowKategori, rowSatuan, rowHarga, rowStok;
                        Int32 barangID=-1, stokID=-1, hargaID=-1, kategoriID=-1, satuanID=-1, supplierID=-1;

                        //validasi data kategori
                        if (cmbKategori.SelectedValue == null)
                        {
                            if (cmbKategori.Text.Trim() == "")
                            {
                                cmbKategori.SelectedIndex=0;
                                kategoriID = (Int32)cmbKategori.SelectedValue;
                            }
                            else
                            {
                                kategoriID = incrementLastIDFromTable(datasetPOS1.tbl_kategori, "kategori_id");
                                rowKategori = datasetPOS1.tbl_kategori.NewRow();
                                rowKategori["kategori"] = cmbKategori.Text;
                                datasetPOS1.tbl_kategori.Rows.Add(rowKategori);
                                adapterKategori.Insert(kategoriID,rowKategori["kategori"].ToString(), null, true);
                            }
                        }
                        else
                        {
                            kategoriID = (Int32)cmbKategori.SelectedValue;
                        }

                        //validasi data satuan
                        if (cmbSatuan.SelectedValue == null)
                        {
                            if (cmbSatuan.Text.Trim() == "")
                            {
                                cmbSatuan.SelectedIndex = 0;
                                satuanID = (Int32)cmbSatuan.SelectedValue;
                            }
                            else
                            {
                                satuanID = incrementLastIDFromTable(datasetPOS1.tbl_satuan, "satuan_id");
                                rowSatuan = datasetPOS1.tbl_satuan.NewRow();
                                rowSatuan["satuan"] = cmbSatuan.Text;
                                datasetPOS1.tbl_satuan.Rows.Add(rowSatuan);
                               adapterSatuan.Insert(satuanID,rowSatuan["satuan"].ToString(), true, null);
                            }
                        }
                        else
                        {
                            satuanID = (Int32)cmbSatuan.SelectedValue;
                        }

                        //validasi data supplier
                        if (cmbSupplier.SelectedValue == null)
                        {
                            if (cmbSupplier.Text.Trim() == "")
                            {

                                cmbSupplier.SelectedIndex = 0;
                                supplierID = (Int32)cmbSupplier.SelectedValue;
                            }
                            else
                            {
                                supplierID = incrementLastIDFromTable(datasetPOS1.tbl_supplier, "supplier_id");
                                rowSupplier = datasetPOS1.tbl_supplier.NewRow();
                                rowSupplier["nama_supplier"] = cmbSupplier.Text;
                                datasetPOS1.tbl_supplier.Rows.Add(rowSupplier);
                                adapterSupplier.Insert(supplierID, rowSupplier["nama_supplier"].ToString(), null, null, null, true, null);
                            }
                        }
                        else
                        {
                            supplierID = (Int32)cmbSupplier.SelectedValue;
                        }

                        //validasi data barang
                        barangID = incrementLastIDFromTable(datasetPOS1.tbl_barang_view, "barang_id");
                        row = datasetPOS1.tbl_barang_view.NewRow();
                        row["nama_barang"] = cmbNamaBarang.Text;
                        row["kode_barcode"] = txtBarcode.Text;
                        row["aktif"] = chkAktif.Checked;
                        row["keterangan"] = txtKeterangan.Text;
                        row["kategori"] = cmbKategori.Text;
                        row["satuan"] = cmbSatuan.Text;
                        row["stok"] = numStok.Value;
                        row["nama_supplier"] = cmbSupplier.Text;
                        row["harga_model"] = numHargaModal.Value;
                        row["harga_jual"] = numHargaJual.Value;
                        datasetPOS1.tbl_barang_view.Rows.Add(row);

                        //validasi stok
                        stokID = incrementLastIDFromTable(datasetPOS1.tbl_stok, "stok_id");
                        rowStok = datasetPOS1.tbl_stok.NewRow();
                        rowStok["barang_id"] = barangID;
                        rowStok["stok"] = numStok.Value;
                        datasetPOS1.tbl_stok.Rows.Add(rowStok);

                        //validasi data harga
                        hargaID = incrementLastIDFromTable(datasetPOS1.tbl_harga, "harga_id");
                        rowHarga = datasetPOS1.tbl_harga.NewRow();
                        rowHarga["harga_model"] = numHargaModal.Value;
                        rowHarga["harga_jual"] = numHargaJual.Value;
                        rowHarga["barang_id"] = barangID;
                        rowHarga["supplier_id"] = supplierID;
                        rowHarga["aktif"] = true;
                        rowHarga["_default_"] = true;
                        rowHarga["keterangan"] = txtKeterangan.Text;
                        datasetPOS1.tbl_harga.Rows.Add(rowHarga);

                        //tambahkan data barang
                        adapterBarang.Insert(barangID,row["nama_barang"].ToString(), kategoriID, txtBarcode.Text, supplierID, satuanID, hargaID, true, null);
                        
                        //tambahkan data harga DAN stok setelah data barang, karena FK harga tergantung pada kode barang
                        adapterHarga.Insert(hargaID,barangID, supplierID, numHargaModal.Value, numHargaJual.Value, true, true, null);
                        adapterStok.Insert(stokID, barangID, (Int32)rowStok["stok"], null);

                        tsbReset_Click(sender, e);
                    }

                }
                else
                {
                    Int32 kategoriID, satuanID, supplierID;
                    DataRow rowKategori, rowSatuan, rowSupplier;

                    //validasi data kategori
                    if (cmbKategori.SelectedValue == null)
                    {
                        if (cmbKategori.Text.Trim() == "")
                        {
                            cmbKategori.SelectedIndex = 0;
                            kategoriID = (Int32)cmbKategori.SelectedValue;
                        }
                        else
                        {
                            kategoriID = incrementLastIDFromTable(datasetPOS1.tbl_kategori, "kategori_id");
                            rowKategori = datasetPOS1.tbl_kategori.NewRow();
                            rowKategori["kategori"] = cmbKategori.Text;
                            datasetPOS1.tbl_kategori.Rows.Add(rowKategori);
                            adapterKategori.Insert(kategoriID, rowKategori["kategori"].ToString(), null, true);
                        }
                    }
                    else
                    {
                        kategoriID = (Int32)cmbKategori.SelectedValue;
                    }

                    //validasi data satuan
                    if (cmbSatuan.SelectedValue == null)
                    {
                        if (cmbSatuan.Text.Trim() == "")
                        {
                            cmbSatuan.SelectedIndex = 0;
                            satuanID = (Int32)cmbSatuan.SelectedValue;
                        }
                        else
                        {
                            satuanID = incrementLastIDFromTable(datasetPOS1.tbl_satuan, "satuan_id");
                            rowSatuan = datasetPOS1.tbl_satuan.NewRow();
                            rowSatuan["satuan"] = cmbSatuan.Text;
                            datasetPOS1.tbl_satuan.Rows.Add(rowSatuan);
                            adapterSatuan.Insert(satuanID, rowSatuan["satuan"].ToString(), true, null);
                        }
                    }
                    else
                    {
                        satuanID = (Int32)cmbSatuan.SelectedValue;
                    }

                    //validasi data supplier
                    if (cmbSupplier.SelectedValue == null)
                    {
                        if (cmbSupplier.Text.Trim() == "")
                        {

                            cmbSupplier.SelectedIndex = 0;
                            supplierID = (Int32)cmbSupplier.SelectedValue;
                        }
                        else
                        {
                            supplierID = incrementLastIDFromTable(datasetPOS1.tbl_supplier, "supplier_id");
                            rowSupplier = datasetPOS1.tbl_supplier.NewRow();
                            rowSupplier["nama_supplier"] = cmbSupplier.Text;
                            datasetPOS1.tbl_supplier.Rows.Add(rowSupplier);
                            adapterSupplier.Insert(supplierID, rowSupplier["nama_supplier"].ToString(), null, null, null, true, null);
                        }
                    }
                    else
                    {
                        supplierID = (Int32)cmbSupplier.SelectedValue;
                    }

                    //validasi data barang
                    DataRowView rowView = (DataRowView)bsBarangView.Current;
                    rowView["nama_barang"] = cmbNamaBarang.Text;
                    rowView["kode_barcode"] = txtBarcode.Text;
                    rowView["aktif"] = chkAktif.Checked;
                    rowView["keterangan"] = txtKeterangan.Text;
                    rowView["harga_model"] = numHargaModal.Value;
                    rowView["harga_jual"] = numHargaJual.Value;
                    rowView["kategori"] = cmbKategori.Text;
                    rowView["satuan"] = cmbSatuan.Text;
                    rowView["stok"] = numStok.Value;
                    rowView["nama_supplier"] = cmbSupplier.Text;
                    bsBarangView.EndEdit();

                    adapterBarang.UpdateQueryByBarangID(cmbNamaBarang.Text, kategoriID,txtBarcode.Text, 
                        supplierID, satuanID, chkAktif.Checked, txtKeterangan.Text==null?null:txtKeterangan.Text
                        ,Convert.ToInt32(txtKodeBarang.Text));

                    adapterHarga.UpdateQueryByBarangID(supplierID, numHargaModal.Value, numHargaJual.Value, Convert.ToInt32(txtKodeBarang.Text));

                    adapterStok.UpdateQueryByBarangID((Int32)numStok.Value, Convert.ToInt32(txtKodeBarang.Text));
                    //tsbReset_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
        }

        private void cmbNamaBarang_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dataGridView1_CellClick(sender, null);
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            */
        }

        private void cmbKategori_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbKategori.SelectedValue != null)
                        MessageBox.Show(cmbKategori.SelectedValue.ToString());
                    else
                        MessageBox.Show("null");
                }
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            
        }

        private void tsbCari_Click(object sender, EventArgs e)
        {
            try
            {
                bsBarangView.Filter = tstCari.Text;
            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
        }

        private void tsbHapus_Click(object sender, EventArgs e)
        {
            try
            {
                String barangID = txtKodeBarang.Text;
                if (barangID != "")
                {
                    var result = MessageBox.Show("Peringatan: Data yang dihapus tidak dapat dikembalikan lagi!\nApakah yakin akan menghapus data?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        DataRow[] rowHarga = datasetPOS1.tbl_harga.Select(String.Format("barang_id = {0}",barangID));
                        DataRow[] rowStok = datasetPOS1.tbl_stok.Select(String.Format("barang_id = {0}", barangID));
                        DataRow[] rowBarang = datasetPOS1.tbl_barang_view.Select(String.Format("barang_id = {0}", barangID));

                        foreach(DataRow dr in rowHarga){
                            datasetPOS1.tbl_harga.Rows.Remove(dr);
                        }

                        foreach (DataRow dr in rowStok)
                        {
                            datasetPOS1.tbl_stok.Rows.Remove(dr);
                        }
                        
                        foreach (DataRow dr in rowBarang)
                        {
                            datasetPOS1.tbl_barang_view.Rows.Remove(dr);
                            //bsBarangView.Remove(rowBarang);
                        }
                        
                        
                        adapterHarga.DeleteQueryByBarangID(Convert.ToInt32(barangID));
                        adapterStok.DeleteQueryByBarangID(Convert.ToInt32(barangID));
                        adapterBarang.DeleteQueryByBarangID(Convert.ToInt32(barangID));
                    }
                }
                else
                {
                    MessageBox.Show("Pilih terlebih dahulu data yang akan dihapus!");
                }

            }
            catch(Exception ex)
            {
                konfigurasi.showError(ex);
            }
            finally
            {
                tsbReset_Click(sender, e);
            }
        }

        private Int32 incrementLastIDFromTable(DataTable table, String ID)
        {
            if (table.Rows.Count == 0)
                return 1;
            else
            {
                Int32 max = 0;
                foreach (DataRow row in table.Rows)
                {
                    Int32 data = (Int32)row[ID];
                    max = Math.Max(data, max);
                }
                return max + 1;
            }
        }

        private void splitContainer1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (splitContainer1.Orientation == Orientation.Horizontal)
                splitContainer1.Orientation = Orientation.Vertical;
            else
                splitContainer1.Orientation = Orientation.Horizontal;
        }
    }
}
