namespace POS.Forms
{
    partial class FormStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsStok = new System.Windows.Forms.BindingSource(this.components);
            this.datasetPOS = new POS.DatasetPOS();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adapterStokBarang = new POS.DatasetPOSTableAdapters.tbl_stok_barangTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStokID = new System.Windows.Forms.TextBox();
            this.cmbNamaBarang = new System.Windows.Forms.ComboBox();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.adapterBarang = new POS.DatasetPOSTableAdapters.tbl_barangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsStok;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1014, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator2";
            // 
            // bsStok
            // 
            this.bsStok.DataMember = "tbl_stok_barang";
            this.bsStok.DataSource = this.datasetPOS;
            // 
            // datasetPOS
            // 
            this.datasetPOS.DataSetName = "DatasetPOS";
            this.datasetPOS.Locale = new System.Globalization.CultureInfo("en-US");
            this.datasetPOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tsbHapus.Enabled = false;
            this.tsbHapus.Image = global::POS.Properties.Resources.Cancel_48x;
            this.tsbHapus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHapus.Name = "tsbHapus";
            this.tsbHapus.Size = new System.Drawing.Size(78, 22);
            this.tsbHapus.Text = "HAPUS";
            // 
            // tsbReset
            // 
            this.tsbReset.Enabled = false;
            this.tsbReset.Image = global::POS.Properties.Resources.i_resetallBlue_F12;
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(78, 22);
            this.tsbReset.Text = "RESET";
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
            // 
            // tsbCari
            // 
            this.tsbCari.Image = global::POS.Properties.Resources.Filter_256x;
            this.tsbCari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCari.Name = "tsbCari";
            this.tsbCari.Size = new System.Drawing.Size(88, 22);
            this.tsbCari.Text = "FILTER";
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
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1014, 512);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokidDataGridViewTextBoxColumn,
            this.barangidDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsStok;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(613, 492);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stokidDataGridViewTextBoxColumn
            // 
            this.stokidDataGridViewTextBoxColumn.DataPropertyName = "stok_id";
            this.stokidDataGridViewTextBoxColumn.HeaderText = "stok_id";
            this.stokidDataGridViewTextBoxColumn.Name = "stokidDataGridViewTextBoxColumn";
            this.stokidDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokidDataGridViewTextBoxColumn.Width = 103;
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
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokDataGridViewTextBoxColumn.Width = 73;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            this.keteranganDataGridViewTextBoxColumn.Width = 133;
            // 
            // adapterStokBarang
            // 
            this.adapterStokBarang.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtStokID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbNamaBarang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numStok, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKeterangan, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Keterangan";
            // 
            // txtStokID
            // 
            this.txtStokID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStok, "stok_id", true));
            this.txtStokID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStokID.Enabled = false;
            this.txtStokID.Location = new System.Drawing.Point(149, 3);
            this.txtStokID.Name = "txtStokID";
            this.txtStokID.Size = new System.Drawing.Size(215, 26);
            this.txtStokID.TabIndex = 4;
            // 
            // cmbNamaBarang
            // 
            this.cmbNamaBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbNamaBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStok, "nama_barang", true));
            this.cmbNamaBarang.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsStok, "barang_id", true));
            this.cmbNamaBarang.DataSource = this.datasetPOS;
            this.cmbNamaBarang.DisplayMember = "tbl_barang.nama_barang";
            this.cmbNamaBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbNamaBarang.FormattingEnabled = true;
            this.cmbNamaBarang.Location = new System.Drawing.Point(149, 35);
            this.cmbNamaBarang.Name = "cmbNamaBarang";
            this.cmbNamaBarang.Size = new System.Drawing.Size(215, 26);
            this.cmbNamaBarang.TabIndex = 5;
            this.cmbNamaBarang.ValueMember = "tbl_barang.barang_id";
            // 
            // numStok
            // 
            this.numStok.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsStok, "stok", true));
            this.numStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.numStok.Location = new System.Drawing.Point(149, 67);
            this.numStok.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numStok.Minimum = new decimal(new int[] {
            1410065407,
            2,
            0,
            -2147483648});
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(215, 26);
            this.numStok.TabIndex = 6;
            this.numStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numStok.ThousandsSeparator = true;
            this.numStok.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStok, "keterangan", true));
            this.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKeterangan.Location = new System.Drawing.Point(149, 99);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(215, 116);
            this.txtKeterangan.TabIndex = 7;
            // 
            // adapterBarang
            // 
            this.adapterBarang.ClearBeforeFill = true;
            // 
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1014, 537);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormStok";
            this.Text = "FormStok";
            this.Load += new System.EventHandler(this.FormStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
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
        private System.Windows.Forms.BindingSource bsStok;
        private DatasetPOS datasetPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private DatasetPOSTableAdapters.tbl_stok_barangTableAdapter adapterStokBarang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStokID;
        private System.Windows.Forms.ComboBox cmbNamaBarang;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.TextBox txtKeterangan;
        private DatasetPOSTableAdapters.tbl_barangTableAdapter adapterBarang;
    }
}