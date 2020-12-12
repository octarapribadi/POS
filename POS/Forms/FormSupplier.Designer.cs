namespace POS.Forms
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsSupplier = new System.Windows.Forms.BindingSource(this.components);
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
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.cmbNamaSupplier = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adapterSupplier = new POS.DatasetPOSTableAdapters.tbl_supplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsSupplier;
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
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1073, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator2";
            // 
            // bsSupplier
            // 
            this.bsSupplier.DataMember = "tbl_supplier";
            this.bsSupplier.DataSource = this.datasetPOS1;
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
            this.toolStripTextBox1.Size = new System.Drawing.Size(81, 23);
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
            this.tstCari.Size = new System.Drawing.Size(250, 25);
            this.tstCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstCari_KeyDown);
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(17, 13, 17, 13);
            this.splitContainer1.Size = new System.Drawing.Size(1073, 401);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.77366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.22634F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtSupplierID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbNamaSupplier, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAlamat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTelepon, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkAktif, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtKeterangan, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Supplier*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aktif?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Keterangan";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Location = new System.Drawing.Point(171, 3);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(312, 26);
            this.txtSupplierID.TabIndex = 7;
            // 
            // cmbNamaSupplier
            // 
            this.cmbNamaSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNamaSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNamaSupplier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbNamaSupplier.DataSource = this.bsSupplier;
            this.cmbNamaSupplier.DisplayMember = "nama_supplier";
            this.cmbNamaSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbNamaSupplier.FormattingEnabled = true;
            this.cmbNamaSupplier.Location = new System.Drawing.Point(171, 35);
            this.cmbNamaSupplier.Name = "cmbNamaSupplier";
            this.cmbNamaSupplier.Size = new System.Drawing.Size(312, 26);
            this.cmbNamaSupplier.TabIndex = 8;
            this.cmbNamaSupplier.ValueMember = "supplier_id";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAlamat.Location = new System.Drawing.Point(171, 67);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(312, 73);
            this.txtAlamat.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Location = new System.Drawing.Point(171, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelepon
            // 
            this.txtTelepon.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelepon.Location = new System.Drawing.Point(171, 178);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(312, 26);
            this.txtTelepon.TabIndex = 11;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Checked = true;
            this.chkAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAktif.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkAktif.Location = new System.Drawing.Point(171, 210);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(312, 22);
            this.chkAktif.TabIndex = 12;
            this.chkAktif.Text = "Ceklist untuk mengaktifkan";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKeterangan.Location = new System.Drawing.Point(171, 238);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(312, 98);
            this.txtKeterangan.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn,
            this.alamatsupplierDataGridViewTextBoxColumn,
            this.emailsupplierDataGridViewTextBoxColumn,
            this.teleponsupplierDataGridViewTextBoxColumn,
            this.aktifDataGridViewCheckBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsSupplier;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(17, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplieridDataGridViewTextBoxColumn.Width = 143;
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            this.namasupplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.namasupplierDataGridViewTextBoxColumn.Width = 163;
            // 
            // alamatsupplierDataGridViewTextBoxColumn
            // 
            this.alamatsupplierDataGridViewTextBoxColumn.DataPropertyName = "alamat_supplier";
            this.alamatsupplierDataGridViewTextBoxColumn.HeaderText = "alamat_supplier";
            this.alamatsupplierDataGridViewTextBoxColumn.Name = "alamatsupplierDataGridViewTextBoxColumn";
            this.alamatsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.alamatsupplierDataGridViewTextBoxColumn.Width = 183;
            // 
            // emailsupplierDataGridViewTextBoxColumn
            // 
            this.emailsupplierDataGridViewTextBoxColumn.DataPropertyName = "email_supplier";
            this.emailsupplierDataGridViewTextBoxColumn.HeaderText = "email_supplier";
            this.emailsupplierDataGridViewTextBoxColumn.Name = "emailsupplierDataGridViewTextBoxColumn";
            this.emailsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailsupplierDataGridViewTextBoxColumn.Width = 173;
            // 
            // teleponsupplierDataGridViewTextBoxColumn
            // 
            this.teleponsupplierDataGridViewTextBoxColumn.DataPropertyName = "telepon_supplier";
            this.teleponsupplierDataGridViewTextBoxColumn.HeaderText = "telepon_supplier";
            this.teleponsupplierDataGridViewTextBoxColumn.Name = "teleponsupplierDataGridViewTextBoxColumn";
            this.teleponsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            this.teleponsupplierDataGridViewTextBoxColumn.Width = 193;
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
            // adapterSupplier
            // 
            this.adapterSupplier.ClearBeforeFill = true;
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1073, 426);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSupplier";
            this.Text = "FormSupplier";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tsbCari;
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
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.ComboBox cmbNamaSupplier;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.TextBox txtKeterangan;
        private DatasetPOS datasetPOS1;
        private DatasetPOSTableAdapters.tbl_supplierTableAdapter adapterSupplier;
        private System.Windows.Forms.BindingSource bsSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
    }
}