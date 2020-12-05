namespace POS.Forms
{
    partial class FormPenjualan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBarang = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datasetPOS = new POS.DatasetPOS();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.numTotalBayar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKembalian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFaktur = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.numPotongan = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pbGambar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFakturBaru = new System.Windows.Forms.Button();
            this.btnHapusFaktur = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.adapterBarang = new POS.DatasetPOSTableAdapters.tbl_barangTableAdapter();
            this.adapterPenjualan = new POS.DatasetPOSTableAdapters.tbl_penjualanTableAdapter();
            this.adapterListPenjualanBarang = new POS.DatasetPOSTableAdapters.tbl_listpenjualan_barangTableAdapter();
            this.adapterHarga = new POS.DatasetPOSTableAdapters.tbl_hargaTableAdapter();
            this.adapterLstPenjualan = new POS.DatasetPOSTableAdapters.tbl_lstpenjualanTableAdapter();
            this.lstpenjualanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penjualanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotongan)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 570);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(908, 79);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(457, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(202, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(243, 36);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Rp. 1,234.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBarang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tambah Item ( F1: barang  F2: barcode )";
            // 
            // cmbBarang
            // 
            this.cmbBarang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBarang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbBarang.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarang.FormattingEnabled = true;
            this.cmbBarang.Location = new System.Drawing.Point(3, 22);
            this.cmbBarang.Name = "cmbBarang";
            this.cmbBarang.Size = new System.Drawing.Size(442, 44);
            this.cmbBarang.TabIndex = 0;
            this.cmbBarang.Click += new System.EventHandler(this.cmbBarang_Click);
            this.cmbBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBarang_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 88);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(908, 479);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(675, 473);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lstpenjualanidDataGridViewTextBoxColumn,
            this.penjualanidDataGridViewTextBoxColumn,
            this.barangidDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.hargajualDataGridViewTextBoxColumn,
            this.diskonDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "tbl_listpenjualan_barang";
            this.dataGridView1.DataSource = this.datasetPOS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellVluaeChanged);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // datasetPOS
            // 
            this.datasetPOS.DataSetName = "DatasetPOS";
            this.datasetPOS.Locale = new System.Globalization.CultureInfo("en-US");
            this.datasetPOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Controls.Add(this.numTotalBayar, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtSubtotal, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.txtKembalian, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblFaktur, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtKeterangan, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.numPotongan, 2, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 334);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(669, 136);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // numTotalBayar
            // 
            this.numTotalBayar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTotalBayar.Location = new System.Drawing.Point(404, 71);
            this.numTotalBayar.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numTotalBayar.Name = "numTotalBayar";
            this.numTotalBayar.Size = new System.Drawing.Size(262, 26);
            this.numTotalBayar.TabIndex = 6;
            this.numTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTotalBayar.ThousandsSeparator = true;
            this.numTotalBayar.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numTotalBayar.ValueChanged += new System.EventHandler(this.numTotalBayar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(237, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Potongan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(404, 3);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(262, 26);
            this.txtSubtotal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(237, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 34);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Bayar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(237, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kembalian";
            // 
            // txtKembalian
            // 
            this.txtKembalian.BackColor = System.Drawing.SystemColors.Window;
            this.txtKembalian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKembalian.Enabled = false;
            this.txtKembalian.Location = new System.Drawing.Point(404, 105);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(262, 26);
            this.txtKembalian.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "No. Faktur Penjualan";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblFaktur
            // 
            this.lblFaktur.AutoSize = true;
            this.lblFaktur.Location = new System.Drawing.Point(3, 34);
            this.lblFaktur.Name = "lblFaktur";
            this.lblFaktur.Size = new System.Drawing.Size(0, 18);
            this.lblFaktur.TabIndex = 10;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeterangan.Location = new System.Drawing.Point(3, 105);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(228, 26);
            this.txtKeterangan.TabIndex = 12;
            // 
            // numPotongan
            // 
            this.numPotongan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPotongan.Location = new System.Drawing.Point(404, 37);
            this.numPotongan.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numPotongan.Name = "numPotongan";
            this.numPotongan.Size = new System.Drawing.Size(262, 26);
            this.numPotongan.TabIndex = 5;
            this.numPotongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPotongan.ThousandsSeparator = true;
            this.numPotongan.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numPotongan.ValueChanged += new System.EventHandler(this.numPotongan_ValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.pbGambar, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(684, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(221, 473);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // pbGambar
            // 
            this.pbGambar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGambar.Image = global::POS.Properties.Resources.cart_white;
            this.pbGambar.Location = new System.Drawing.Point(3, 3);
            this.pbGambar.Name = "pbGambar";
            this.pbGambar.Size = new System.Drawing.Size(215, 183);
            this.pbGambar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGambar.TabIndex = 0;
            this.pbGambar.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.btnFakturBaru, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnHapusFaktur, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnSimpan, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnCetak, 0, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 192);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(215, 278);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btnFakturBaru
            // 
            this.btnFakturBaru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFakturBaru.Location = new System.Drawing.Point(3, 3);
            this.btnFakturBaru.Name = "btnFakturBaru";
            this.btnFakturBaru.Size = new System.Drawing.Size(209, 63);
            this.btnFakturBaru.TabIndex = 0;
            this.btnFakturBaru.Text = "Faktur Baru (F3)";
            this.btnFakturBaru.UseVisualStyleBackColor = true;
            this.btnFakturBaru.Click += new System.EventHandler(this.btnFakturBaru_Click);
            // 
            // btnHapusFaktur
            // 
            this.btnHapusFaktur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHapusFaktur.Location = new System.Drawing.Point(3, 72);
            this.btnHapusFaktur.Name = "btnHapusFaktur";
            this.btnHapusFaktur.Size = new System.Drawing.Size(209, 63);
            this.btnHapusFaktur.TabIndex = 1;
            this.btnHapusFaktur.Text = "Hapus Faktur (F4)";
            this.btnHapusFaktur.UseVisualStyleBackColor = true;
            this.btnHapusFaktur.Click += new System.EventHandler(this.btnHapusFaktur_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSimpan.Location = new System.Drawing.Point(3, 141);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(209, 63);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "Simpan (F5)";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCetak.Location = new System.Drawing.Point(3, 210);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(209, 65);
            this.btnCetak.TabIndex = 3;
            this.btnCetak.Text = "Cetak (F6)";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // adapterBarang
            // 
            this.adapterBarang.ClearBeforeFill = true;
            // 
            // adapterPenjualan
            // 
            this.adapterPenjualan.ClearBeforeFill = true;
            // 
            // adapterListPenjualanBarang
            // 
            this.adapterListPenjualanBarang.ClearBeforeFill = true;
            // 
            // adapterHarga
            // 
            this.adapterHarga.ClearBeforeFill = true;
            // 
            // adapterLstPenjualan
            // 
            this.adapterLstPenjualan.ClearBeforeFill = true;
            // 
            // lstpenjualanidDataGridViewTextBoxColumn
            // 
            this.lstpenjualanidDataGridViewTextBoxColumn.DataPropertyName = "lstpenjualan_id";
            this.lstpenjualanidDataGridViewTextBoxColumn.HeaderText = "ID LIST ITEM";
            this.lstpenjualanidDataGridViewTextBoxColumn.Name = "lstpenjualanidDataGridViewTextBoxColumn";
            this.lstpenjualanidDataGridViewTextBoxColumn.ReadOnly = true;
            this.lstpenjualanidDataGridViewTextBoxColumn.Visible = false;
            this.lstpenjualanidDataGridViewTextBoxColumn.Width = 153;
            // 
            // penjualanidDataGridViewTextBoxColumn
            // 
            this.penjualanidDataGridViewTextBoxColumn.DataPropertyName = "penjualan_id";
            this.penjualanidDataGridViewTextBoxColumn.HeaderText = "ID PENJUALAN";
            this.penjualanidDataGridViewTextBoxColumn.Name = "penjualanidDataGridViewTextBoxColumn";
            this.penjualanidDataGridViewTextBoxColumn.Visible = false;
            this.penjualanidDataGridViewTextBoxColumn.Width = 153;
            // 
            // barangidDataGridViewTextBoxColumn
            // 
            this.barangidDataGridViewTextBoxColumn.DataPropertyName = "barang_id";
            this.barangidDataGridViewTextBoxColumn.HeaderText = "ID BARANG";
            this.barangidDataGridViewTextBoxColumn.Name = "barangidDataGridViewTextBoxColumn";
            this.barangidDataGridViewTextBoxColumn.ReadOnly = true;
            this.barangidDataGridViewTextBoxColumn.Visible = false;
            this.barangidDataGridViewTextBoxColumn.Width = 123;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "NAMA BARANG";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.namabarangDataGridViewTextBoxColumn.Width = 131;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            dataGridViewCellStyle2.NullValue = "0";
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 63;
            // 
            // hargajualDataGridViewTextBoxColumn
            // 
            this.hargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = "0";
            this.hargajualDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.hargajualDataGridViewTextBoxColumn.HeaderText = "HARGA SATUAN";
            this.hargajualDataGridViewTextBoxColumn.Name = "hargajualDataGridViewTextBoxColumn";
            this.hargajualDataGridViewTextBoxColumn.Width = 140;
            // 
            // diskonDataGridViewTextBoxColumn
            // 
            this.diskonDataGridViewTextBoxColumn.DataPropertyName = "diskon";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = "0";
            this.diskonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.diskonDataGridViewTextBoxColumn.HeaderText = "DISKON";
            this.diskonDataGridViewTextBoxColumn.Name = "diskonDataGridViewTextBoxColumn";
            this.diskonDataGridViewTextBoxColumn.Width = 93;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "KETERANGAN";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 133;
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(934, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormPenjualan";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormPenjualan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPenjualan_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalBayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotongan)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGambar)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBarang;
        private DatasetPOSTableAdapters.tbl_barangTableAdapter adapterBarang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pbGambar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnFakturBaru;
        private System.Windows.Forms.Button btnHapusFaktur;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKembalian;
        private System.Windows.Forms.Label lblFaktur;
        private DatasetPOS datasetPOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeterangan;
        private DatasetPOSTableAdapters.tbl_penjualanTableAdapter adapterPenjualan;
        private DatasetPOSTableAdapters.tbl_listpenjualan_barangTableAdapter adapterListPenjualanBarang;
        private DatasetPOSTableAdapters.tbl_hargaTableAdapter adapterHarga;
        private DatasetPOSTableAdapters.tbl_lstpenjualanTableAdapter adapterLstPenjualan;
        private System.Windows.Forms.NumericUpDown numTotalBayar;
        private System.Windows.Forms.NumericUpDown numPotongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstpenjualanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penjualanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barangidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
    }
}