namespace POS.Forms
{
    partial class FormRestok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestok));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbHapus = new System.Windows.Forms.ToolStripButton();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstCari = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbNamaBarang = new System.Windows.Forms.ComboBox();
            this.bsBarang = new System.Windows.Forms.BindingSource(this.components);
            this.datasetPOS1 = new POS.DatasetPOS();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.bsKategori = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.bsSupplier = new System.Windows.Forms.BindingSource(this.components);
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSatuan = new System.Windows.Forms.ComboBox();
            this.bsSatuan = new System.Windows.Forms.BindingSource(this.components);
            this.txtHargaModal = new System.Windows.Forms.NumericUpDown();
            this.txtHargaJual = new System.Windows.Forms.NumericUpDown();
            this.dgvTampil = new System.Windows.Forms.DataGridView();
            this.hargaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargamodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.defaultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHarga = new System.Windows.Forms.BindingSource(this.components);
            this.bsRestok = new System.Windows.Forms.BindingSource(this.components);
            this.adapterRestok = new POS.DatasetPOSTableAdapters.tbl_restokTableAdapter();
            this.adapterBarang = new POS.DatasetPOSTableAdapters.tbl_barangTableAdapter();
            this.adapterKategori = new POS.DatasetPOSTableAdapters.tbl_kategoriTableAdapter();
            this.adapterSupplier = new POS.DatasetPOSTableAdapters.tbl_supplierTableAdapter();
            this.adapterSatuan = new POS.DatasetPOSTableAdapters.tbl_satuanTableAdapter();
            this.adapterStok = new POS.DatasetPOSTableAdapters.tbl_stokTableAdapter();
            this.adapterFormRestok = new POS.DatasetPOSTableAdapters.tbl_formrestokTableAdapter();
            this.adapterHarga = new POS.DatasetPOSTableAdapters.tbl_hargaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSatuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaModal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaJual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRestok)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbSimpan,
            this.tsbHapus,
            this.tsbReset,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tstCari});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(964, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(68, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSimpan
            // 
            this.tsbSimpan.Image = global::POS.Properties.Resources.Save_48x;
            this.tsbSimpan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSimpan.Name = "tsbSimpan";
            this.tsbSimpan.Size = new System.Drawing.Size(88, 22);
            this.tsbSimpan.Text = "SIMPAN";
            this.tsbSimpan.Click += new System.EventHandler(this.tsbSimpan_Click);
            // 
            // tsbHapus
            // 
            this.tsbHapus.Image = global::POS.Properties.Resources.Cancel_48x;
            this.tsbHapus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHapus.Name = "tsbHapus";
            this.tsbHapus.Size = new System.Drawing.Size(78, 22);
            this.tsbHapus.Text = "HAPUS";
            // 
            // tsbReset
            // 
            this.tsbReset.Image = global::POS.Properties.Resources.i_resetallBlue_F12;
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(78, 22);
            this.tsbReset.Text = "RESET";
            this.tsbReset.Click += new System.EventHandler(this.tsbReset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::POS.Properties.Resources.Search_64x;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel1.Text = "PENCARIAN :";
            // 
            // tstCari
            // 
            this.tstCari.Name = "tstCari";
            this.tstCari.Size = new System.Drawing.Size(200, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTampil);
            this.splitContainer1.Size = new System.Drawing.Size(964, 483);
            this.splitContainer1.SplitterDistance = 527;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbNamaBarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numQty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbKategori, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbSupplier, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBarcode, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtKeterangan, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.dtpTanggal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbSatuan, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHargaModal, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtHargaJual, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "TANGGAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA BARANG*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUANTITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "KATEGORI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "SUPPLIER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "HARGA MODAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "HARGA JUAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "KODE BARCODE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "KETERANGAN";
            // 
            // cmbNamaBarang
            // 
            this.cmbNamaBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNamaBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNamaBarang.DataSource = this.bsBarang;
            this.cmbNamaBarang.DisplayMember = "nama_barang";
            this.cmbNamaBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbNamaBarang.FormattingEnabled = true;
            this.cmbNamaBarang.Location = new System.Drawing.Point(161, 35);
            this.cmbNamaBarang.Name = "cmbNamaBarang";
            this.cmbNamaBarang.Size = new System.Drawing.Size(363, 26);
            this.cmbNamaBarang.TabIndex = 8;
            this.cmbNamaBarang.ValueMember = "barang_id";
            this.cmbNamaBarang.DropDownClosed += new System.EventHandler(this.tes);
            this.cmbNamaBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNamaBarang_KeyDown);
            this.cmbNamaBarang.Leave += new System.EventHandler(this.cmbNamaBarang_Leave);
            // 
            // bsBarang
            // 
            this.bsBarang.DataMember = "tbl_barang";
            this.bsBarang.DataSource = this.datasetPOS1;
            // 
            // datasetPOS1
            // 
            this.datasetPOS1.DataSetName = "DatasetPOS";
            this.datasetPOS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numQty
            // 
            this.numQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.numQty.Location = new System.Drawing.Point(161, 67);
            this.numQty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(363, 26);
            this.numQty.TabIndex = 9;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.ThousandsSeparator = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKategori.DataSource = this.bsKategori;
            this.cmbKategori.DisplayMember = "kategori";
            this.cmbKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(161, 131);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(363, 26);
            this.cmbKategori.TabIndex = 11;
            this.cmbKategori.ValueMember = "tbl_kategori.kategori_id";
            // 
            // bsKategori
            // 
            this.bsKategori.DataMember = "tbl_kategori";
            this.bsKategori.DataSource = this.datasetPOS1;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.DataSource = this.bsSupplier;
            this.cmbSupplier.DisplayMember = "nama_supplier";
            this.cmbSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(161, 163);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(363, 26);
            this.cmbSupplier.TabIndex = 12;
            this.cmbSupplier.ValueMember = "tbl_supplier.supplier_id";
            // 
            // bsSupplier
            // 
            this.bsSupplier.DataMember = "tbl_supplier";
            this.bsSupplier.DataSource = this.datasetPOS1;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBarcode.Location = new System.Drawing.Point(161, 259);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(363, 26);
            this.txtBarcode.TabIndex = 15;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeterangan.Location = new System.Drawing.Point(161, 291);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(363, 132);
            this.txtKeterangan.TabIndex = 16;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd MMMM yyyy, HH:mm";
            this.dtpTanggal.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(161, 3);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(363, 26);
            this.dtpTanggal.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "SATUAN";
            // 
            // cmbSatuan
            // 
            this.cmbSatuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSatuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSatuan.DataSource = this.bsSatuan;
            this.cmbSatuan.DisplayMember = "satuan";
            this.cmbSatuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbSatuan.FormattingEnabled = true;
            this.cmbSatuan.Location = new System.Drawing.Point(161, 99);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.Size = new System.Drawing.Size(363, 26);
            this.cmbSatuan.TabIndex = 10;
            this.cmbSatuan.ValueMember = "tbl_satuan.satuan_id";
            // 
            // bsSatuan
            // 
            this.bsSatuan.DataMember = "tbl_satuan";
            this.bsSatuan.DataSource = this.datasetPOS1;
            // 
            // txtHargaModal
            // 
            this.txtHargaModal.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHargaModal.Location = new System.Drawing.Point(161, 195);
            this.txtHargaModal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtHargaModal.Name = "txtHargaModal";
            this.txtHargaModal.Size = new System.Drawing.Size(363, 26);
            this.txtHargaModal.TabIndex = 13;
            this.txtHargaModal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHargaModal.ThousandsSeparator = true;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHargaJual.Location = new System.Drawing.Point(161, 227);
            this.txtHargaJual.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(363, 26);
            this.txtHargaJual.TabIndex = 14;
            this.txtHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHargaJual.ThousandsSeparator = true;
            // 
            // dgvTampil
            // 
            this.dgvTampil.AllowUserToAddRows = false;
            this.dgvTampil.AllowUserToDeleteRows = false;
            this.dgvTampil.AllowUserToOrderColumns = true;
            this.dgvTampil.AutoGenerateColumns = false;
            this.dgvTampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hargaidDataGridViewTextBoxColumn,
            this.barangidDataGridViewTextBoxColumn,
            this.supplieridDataGridViewTextBoxColumn,
            this.hargamodelDataGridViewTextBoxColumn,
            this.hargajualDataGridViewTextBoxColumn,
            this.aktifDataGridViewCheckBoxColumn,
            this.defaultDataGridViewCheckBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dgvTampil.DataSource = this.bsHarga;
            this.dgvTampil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTampil.Location = new System.Drawing.Point(0, 0);
            this.dgvTampil.Name = "dgvTampil";
            this.dgvTampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTampil.Size = new System.Drawing.Size(433, 483);
            this.dgvTampil.TabIndex = 0;
            // 
            // hargaidDataGridViewTextBoxColumn
            // 
            this.hargaidDataGridViewTextBoxColumn.DataPropertyName = "harga_id";
            this.hargaidDataGridViewTextBoxColumn.HeaderText = "harga_id";
            this.hargaidDataGridViewTextBoxColumn.Name = "hargaidDataGridViewTextBoxColumn";
            this.hargaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargaidDataGridViewTextBoxColumn.Width = 113;
            // 
            // barangidDataGridViewTextBoxColumn
            // 
            this.barangidDataGridViewTextBoxColumn.DataPropertyName = "barang_id";
            this.barangidDataGridViewTextBoxColumn.HeaderText = "barang_id";
            this.barangidDataGridViewTextBoxColumn.Name = "barangidDataGridViewTextBoxColumn";
            this.barangidDataGridViewTextBoxColumn.Width = 123;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.Width = 143;
            // 
            // hargamodelDataGridViewTextBoxColumn
            // 
            this.hargamodelDataGridViewTextBoxColumn.DataPropertyName = "harga_model";
            this.hargamodelDataGridViewTextBoxColumn.HeaderText = "harga_model";
            this.hargamodelDataGridViewTextBoxColumn.Name = "hargamodelDataGridViewTextBoxColumn";
            this.hargamodelDataGridViewTextBoxColumn.Width = 143;
            // 
            // hargajualDataGridViewTextBoxColumn
            // 
            this.hargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.HeaderText = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.Name = "hargajualDataGridViewTextBoxColumn";
            this.hargajualDataGridViewTextBoxColumn.Width = 133;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            this.aktifDataGridViewCheckBoxColumn.DataPropertyName = "aktif";
            this.aktifDataGridViewCheckBoxColumn.HeaderText = "aktif";
            this.aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            this.aktifDataGridViewCheckBoxColumn.Width = 64;
            // 
            // defaultDataGridViewCheckBoxColumn
            // 
            this.defaultDataGridViewCheckBoxColumn.DataPropertyName = "_default_";
            this.defaultDataGridViewCheckBoxColumn.HeaderText = "_default_";
            this.defaultDataGridViewCheckBoxColumn.Name = "defaultDataGridViewCheckBoxColumn";
            this.defaultDataGridViewCheckBoxColumn.Width = 104;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 133;
            // 
            // bsHarga
            // 
            this.bsHarga.DataMember = "tbl_harga";
            this.bsHarga.DataSource = this.datasetPOS1;
            // 
            // adapterRestok
            // 
            this.adapterRestok.ClearBeforeFill = true;
            // 
            // adapterBarang
            // 
            this.adapterBarang.ClearBeforeFill = true;
            // 
            // adapterKategori
            // 
            this.adapterKategori.ClearBeforeFill = true;
            // 
            // adapterSupplier
            // 
            this.adapterSupplier.ClearBeforeFill = true;
            // 
            // adapterSatuan
            // 
            this.adapterSatuan.ClearBeforeFill = true;
            // 
            // adapterStok
            // 
            this.adapterStok.ClearBeforeFill = true;
            // 
            // adapterFormRestok
            // 
            this.adapterFormRestok.ClearBeforeFill = true;
            // 
            // adapterHarga
            // 
            this.adapterHarga.ClearBeforeFill = true;
            // 
            // FormRestok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(964, 508);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormRestok";
            this.Text = "FormRestok";
            this.Load += new System.EventHandler(this.FormRestok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSatuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaModal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaJual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRestok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbNamaBarang;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.DataGridView dgvTampil;
        private System.Windows.Forms.ToolStripButton tsbSimpan;
        private System.Windows.Forms.ToolStripButton tsbHapus;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tstCari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSatuan;
        private DatasetPOSTableAdapters.tbl_restokTableAdapter adapterRestok;
        private System.Windows.Forms.BindingSource bsRestok;
        private DatasetPOSTableAdapters.tbl_barangTableAdapter adapterBarang;
        private DatasetPOSTableAdapters.tbl_kategoriTableAdapter adapterKategori;
        private DatasetPOSTableAdapters.tbl_supplierTableAdapter adapterSupplier;
        private DatasetPOSTableAdapters.tbl_satuanTableAdapter adapterSatuan;
        private DatasetPOSTableAdapters.tbl_stokTableAdapter adapterStok;
        private DatasetPOSTableAdapters.tbl_formrestokTableAdapter adapterFormRestok;
        private System.Windows.Forms.BindingSource bsBarang;
        private System.Windows.Forms.BindingSource bsSatuan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsKategori;
        private System.Windows.Forms.BindingSource bsSupplier;
        private System.Windows.Forms.BindingSource bsHarga;
        private DatasetPOS datasetPOS1;
        private System.Windows.Forms.NumericUpDown txtHargaModal;
        private System.Windows.Forms.NumericUpDown txtHargaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargamodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn defaultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private DatasetPOSTableAdapters.tbl_hargaTableAdapter adapterHarga;
    }
}