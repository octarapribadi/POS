namespace POS.Forms
{
    partial class FormBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsBarangView = new System.Windows.Forms.BindingSource(this.components);
            this.datasetPOS1 = new POS.DatasetPOS();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSimpan = new System.Windows.Forms.ToolStripButton();
            this.tsbHapus = new System.Windows.Forms.ToolStripButton();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstCari = new System.Windows.Forms.ToolStripTextBox();
            this.tsbCari = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNamaBarang = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cmbSatuan = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.numHargaModal = new System.Windows.Forms.NumericUpDown();
            this.numHargaJual = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barangidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargamodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adapterBarang = new POS.DatasetPOSTableAdapters.tbl_barangTableAdapter();
            this.adapterKategori = new POS.DatasetPOSTableAdapters.tbl_kategoriTableAdapter();
            this.adapterSatuan = new POS.DatasetPOSTableAdapters.tbl_satuanTableAdapter();
            this.adapterSupplier = new POS.DatasetPOSTableAdapters.tbl_supplierTableAdapter();
            this.adapterHarga = new POS.DatasetPOSTableAdapters.tbl_hargaTableAdapter();
            this.adapterBarangView = new POS.DatasetPOSTableAdapters.tbl_barang_viewTableAdapter();
            this.adapterStok = new POS.DatasetPOSTableAdapters.tbl_stokTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarangView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaModal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaJual)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsBarangView;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.tsbSimpan,
            this.tsbHapus,
            this.tsbReset,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.tstCari,
            this.tsbCari});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1190, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator2";
            // 
            // bsBarangView
            // 
            this.bsBarangView.DataMember = "tbl_barang_view";
            this.bsBarangView.DataSource = this.datasetPOS1;
            this.bsBarangView.PositionChanged += new System.EventHandler(this.bsBarangView_PositionChanged);
            // 
            // datasetPOS1
            // 
            this.datasetPOS1.DataSetName = "DatasetPOS";
            this.datasetPOS1.Locale = new System.Globalization.CultureInfo("en-US");
            this.datasetPOS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.tsbHapus.Click += new System.EventHandler(this.tsbHapus_Click);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::POS.Properties.Resources.Search_64x;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel2.Text = "PENCARIAN :";
            // 
            // tstCari
            // 
            this.tstCari.Name = "tstCari";
            this.tstCari.Size = new System.Drawing.Size(200, 25);
            this.tstCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyDown);
            // 
            // tsbCari
            // 
            this.tsbCari.Image = global::POS.Properties.Resources.Filter_256x;
            this.tsbCari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCari.Name = "tsbCari";
            this.tsbCari.Size = new System.Drawing.Size(88, 22);
            this.tsbCari.Text = "FILTER";
            this.tsbCari.Click += new System.EventHandler(this.tsbCari_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1190, 531);
            this.splitContainer1.SplitterDistance = 595;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.91597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.08403F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtKodeBarang, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cmbNamaBarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbKategori, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBarcode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbSatuan, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbSupplier, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkAktif, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.numStok, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtKeterangan, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.numHargaModal, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numHargaJual, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 12;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Supplier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Harga Modal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Harga Jual";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKodeBarang.Enabled = false;
            this.txtKodeBarang.Location = new System.Drawing.Point(183, 8);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(404, 26);
            this.txtKodeBarang.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Stok**";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Keterangan";
            // 
            // cmbNamaBarang
            // 
            this.cmbNamaBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNamaBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNamaBarang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbNamaBarang.DataSource = this.bsBarangView;
            this.cmbNamaBarang.DisplayMember = "nama_barang";
            this.cmbNamaBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNamaBarang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbNamaBarang.FormattingEnabled = true;
            this.cmbNamaBarang.Location = new System.Drawing.Point(183, 40);
            this.cmbNamaBarang.Name = "cmbNamaBarang";
            this.cmbNamaBarang.Size = new System.Drawing.Size(404, 26);
            this.cmbNamaBarang.TabIndex = 12;
            this.cmbNamaBarang.ValueMember = "barang_id";
            this.cmbNamaBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNamaBarang_KeyDown);
            // 
            // cmbKategori
            // 
            this.cmbKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKategori.DataSource = this.datasetPOS1;
            this.cmbKategori.DisplayMember = "tbl_kategori.kategori";
            this.cmbKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(183, 72);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(404, 26);
            this.cmbKategori.TabIndex = 13;
            this.cmbKategori.ValueMember = "tbl_kategori.kategori_id";
            this.cmbKategori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbKategori_KeyDown);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBarcode.Location = new System.Drawing.Point(183, 104);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(404, 26);
            this.txtBarcode.TabIndex = 14;
            // 
            // cmbSatuan
            // 
            this.cmbSatuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSatuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSatuan.DataSource = this.datasetPOS1;
            this.cmbSatuan.DisplayMember = "tbl_satuan.satuan";
            this.cmbSatuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSatuan.FormattingEnabled = true;
            this.cmbSatuan.Location = new System.Drawing.Point(183, 136);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.Size = new System.Drawing.Size(404, 26);
            this.cmbSatuan.TabIndex = 15;
            this.cmbSatuan.ValueMember = "tbl_satuan.satuan_id";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.DataSource = this.datasetPOS1;
            this.cmbSupplier.DisplayMember = "tbl_supplier.nama_supplier";
            this.cmbSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(183, 168);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(404, 26);
            this.cmbSupplier.TabIndex = 16;
            this.cmbSupplier.ValueMember = "tbl_supplier.supplier_id";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAktif.Location = new System.Drawing.Point(183, 264);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(404, 22);
            this.chkAktif.TabIndex = 19;
            this.chkAktif.Text = "Ceklist Jika Barang Masih Mau Dijual";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Aktif?";
            // 
            // numStok
            // 
            this.numStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numStok.Enabled = false;
            this.numStok.Location = new System.Drawing.Point(183, 292);
            this.numStok.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(404, 26);
            this.numStok.TabIndex = 20;
            this.numStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numStok.ThousandsSeparator = true;
            this.numStok.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKeterangan.Location = new System.Drawing.Point(183, 324);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(404, 143);
            this.txtKeterangan.TabIndex = 21;
            // 
            // numHargaModal
            // 
            this.numHargaModal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHargaModal.Location = new System.Drawing.Point(183, 200);
            this.numHargaModal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numHargaModal.Name = "numHargaModal";
            this.numHargaModal.Size = new System.Drawing.Size(404, 26);
            this.numHargaModal.TabIndex = 17;
            this.numHargaModal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHargaModal.ThousandsSeparator = true;
            this.numHargaModal.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numHargaJual
            // 
            this.numHargaJual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHargaJual.Location = new System.Drawing.Point(183, 232);
            this.numHargaJual.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numHargaJual.Name = "numHargaJual";
            this.numHargaJual.Size = new System.Drawing.Size(404, 26);
            this.numHargaJual.TabIndex = 18;
            this.numHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHargaJual.ThousandsSeparator = true;
            this.numHargaJual.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(591, 531);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barangidDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.kodebarcodeDataGridViewTextBoxColumn,
            this.aktifDataGridViewCheckBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.hargamodelDataGridViewTextBoxColumn,
            this.hargajualDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsBarangView;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(571, 511);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // barangidDataGridViewTextBoxColumn
            // 
            this.barangidDataGridViewTextBoxColumn.DataPropertyName = "barang_id";
            this.barangidDataGridViewTextBoxColumn.HeaderText = "barang_id";
            this.barangidDataGridViewTextBoxColumn.Name = "barangidDataGridViewTextBoxColumn";
            this.barangidDataGridViewTextBoxColumn.ReadOnly = true;
            this.barangidDataGridViewTextBoxColumn.Width = 123;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.namabarangDataGridViewTextBoxColumn.Width = 143;
            // 
            // kodebarcodeDataGridViewTextBoxColumn
            // 
            this.kodebarcodeDataGridViewTextBoxColumn.DataPropertyName = "kode_barcode";
            this.kodebarcodeDataGridViewTextBoxColumn.HeaderText = "kode_barcode";
            this.kodebarcodeDataGridViewTextBoxColumn.Name = "kodebarcodeDataGridViewTextBoxColumn";
            this.kodebarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodebarcodeDataGridViewTextBoxColumn.Width = 153;
            // 
            // aktifDataGridViewCheckBoxColumn
            // 
            this.aktifDataGridViewCheckBoxColumn.DataPropertyName = "aktif";
            this.aktifDataGridViewCheckBoxColumn.HeaderText = "aktif";
            this.aktifDataGridViewCheckBoxColumn.Name = "aktifDataGridViewCheckBoxColumn";
            this.aktifDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aktifDataGridViewCheckBoxColumn.Width = 64;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            this.keteranganDataGridViewTextBoxColumn.Width = 133;
            // 
            // hargamodelDataGridViewTextBoxColumn
            // 
            this.hargamodelDataGridViewTextBoxColumn.DataPropertyName = "harga_model";
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = "0";
            this.hargamodelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.hargamodelDataGridViewTextBoxColumn.HeaderText = "harga_modal";
            this.hargamodelDataGridViewTextBoxColumn.Name = "hargamodelDataGridViewTextBoxColumn";
            this.hargamodelDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargamodelDataGridViewTextBoxColumn.Width = 143;
            // 
            // hargajualDataGridViewTextBoxColumn
            // 
            this.hargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual";
            dataGridViewCellStyle9.Format = "C0";
            dataGridViewCellStyle9.NullValue = "0";
            this.hargajualDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.hargajualDataGridViewTextBoxColumn.HeaderText = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.Name = "hargajualDataGridViewTextBoxColumn";
            this.hargajualDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargajualDataGridViewTextBoxColumn.Width = 133;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriDataGridViewTextBoxColumn.Width = 113;
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            this.satuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.satuanDataGridViewTextBoxColumn.Width = 93;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokDataGridViewTextBoxColumn.Width = 73;
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            this.namasupplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.namasupplierDataGridViewTextBoxColumn.Width = 163;
            // 
            // adapterBarang
            // 
            this.adapterBarang.ClearBeforeFill = true;
            // 
            // adapterKategori
            // 
            this.adapterKategori.ClearBeforeFill = true;
            // 
            // adapterSatuan
            // 
            this.adapterSatuan.ClearBeforeFill = true;
            // 
            // adapterSupplier
            // 
            this.adapterSupplier.ClearBeforeFill = true;
            // 
            // adapterHarga
            // 
            this.adapterHarga.ClearBeforeFill = true;
            // 
            // adapterBarangView
            // 
            this.adapterBarangView.ClearBeforeFill = true;
            // 
            // adapterStok
            // 
            this.adapterStok.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 2);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(8, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(388, 56);
            this.label12.TabIndex = 22;
            this.label12.Text = "Catatan:\r\n*) Wajib Diisi\r\n**) Lakukan penyesuaian stok dari\r\n\"Form Restok\" dan \"F" +
    "orm Barang Keluar\"";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1190, 556);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarangView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaModal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHargaJual)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSimpan;
        private System.Windows.Forms.ToolStripButton tsbHapus;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstCari;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNamaBarang;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.ComboBox cmbSatuan;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.TextBox txtKeterangan;
        private DatasetPOS datasetPOS1;
        private DatasetPOSTableAdapters.tbl_barangTableAdapter adapterBarang;
        private DatasetPOSTableAdapters.tbl_kategoriTableAdapter adapterKategori;
        private DatasetPOSTableAdapters.tbl_satuanTableAdapter adapterSatuan;
        private DatasetPOSTableAdapters.tbl_supplierTableAdapter adapterSupplier;
        private DatasetPOSTableAdapters.tbl_hargaTableAdapter adapterHarga;
        private System.Windows.Forms.BindingSource bsBarangView;
        private DatasetPOSTableAdapters.tbl_barang_viewTableAdapter adapterBarangView;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargamodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numHargaModal;
        private System.Windows.Forms.NumericUpDown numHargaJual;
        private System.Windows.Forms.ToolStripButton tsbCari;
        private System.Windows.Forms.Panel panel1;
        private DatasetPOSTableAdapters.tbl_stokTableAdapter adapterStok;
        private System.Windows.Forms.Label label12;
    }
}