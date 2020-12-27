namespace POS.Forms
{
    partial class FormLogStok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsLog = new System.Windows.Forms.BindingSource(this.components);
            this.adapterLogStok = new POS.DatasetPOSTableAdapters.tbl_log_stokTableAdapter();
            this.datasetPOS = new POS.DatasetPOS();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalwaktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpTanggalAwal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpTanggalAkhir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFilter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTampilkan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 486);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal Awal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Akhir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter";
            // 
            // dtpTanggalAwal
            // 
            this.dtpTanggalAwal.CustomFormat = "dd MMMM yyyy HH:mm";
            this.dtpTanggalAwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwal.Location = new System.Drawing.Point(147, 3);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.Size = new System.Drawing.Size(426, 26);
            this.dtpTanggalAwal.TabIndex = 3;
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.CustomFormat = "dd MMMM yyyy HH:mm";
            this.dtpTanggalAkhir.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(147, 35);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(426, 26);
            this.dtpTanggalAkhir.TabIndex = 4;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(147, 67);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(426, 26);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilter_MouseClick);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.MouseLeave += new System.EventHandler(this.txtFilter_MouseLeave);
            this.txtFilter.MouseHover += new System.EventHandler(this.txtFilter_MouseHover);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTampilkan.Location = new System.Drawing.Point(579, 3);
            this.btnTampilkan.Name = "btnTampilkan";
            this.tableLayoutPanel1.SetRowSpan(this.btnTampilkan, 3);
            this.btnTampilkan.Size = new System.Drawing.Size(138, 90);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tanggalwaktuDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.DataSource = this.bsLog;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(714, 384);
            this.dataGridView1.TabIndex = 8;
            // 
            // bsLog
            // 
            this.bsLog.DataMember = "tbl_log_stok";
            this.bsLog.DataSource = this.datasetPOS;
            // 
            // adapterLogStok
            // 
            this.adapterLogStok.ClearBeforeFill = true;
            // 
            // datasetPOS
            // 
            this.datasetPOS.DataSetName = "DatasetPOS";
            this.datasetPOS.Locale = new System.Globalization.CultureInfo("en-US");
            this.datasetPOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 53;
            // 
            // tanggalwaktuDataGridViewTextBoxColumn
            // 
            this.tanggalwaktuDataGridViewTextBoxColumn.DataPropertyName = "tanggal_waktu";
            dataGridViewCellStyle4.Format = "F";
            dataGridViewCellStyle4.NullValue = null;
            this.tanggalwaktuDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tanggalwaktuDataGridViewTextBoxColumn.HeaderText = "tanggal_waktu";
            this.tanggalwaktuDataGridViewTextBoxColumn.Name = "tanggalwaktuDataGridViewTextBoxColumn";
            this.tanggalwaktuDataGridViewTextBoxColumn.Width = 163;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 133;
            // 
            // FormLogStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(720, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormLogStok";
            this.Text = "FormLogStok";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTanggalAwal;
        private System.Windows.Forms.DateTimePicker dtpTanggalAkhir;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsLog;
        private DatasetPOSTableAdapters.tbl_log_stokTableAdapter adapterLogStok;
        private DatasetPOS datasetPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalwaktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
    }
}