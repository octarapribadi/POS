namespace POS.Forms
{
    partial class FormLaporanRestok
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.datasetPOS = new POS.DatasetPOS();
            this.adapterLaporanRestok = new POS.DatasetPOSTableAdapters.tbl_laporan_restokTableAdapter();
            this.reportReStok = new POS.Report.ReportReStok();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasetPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.16918F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.74018F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpTanggalAwal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpTanggalAkhir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFilter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.crystalReportViewer1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTampilkan, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 494);
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
            this.dtpTanggalAwal.CustomFormat = "dd MMMM yyyy HH:mm tt";
            this.dtpTanggalAwal.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAwal.Location = new System.Drawing.Point(163, 3);
            this.dtpTanggalAwal.Name = "dtpTanggalAwal";
            this.dtpTanggalAwal.Size = new System.Drawing.Size(363, 26);
            this.dtpTanggalAwal.TabIndex = 3;
            // 
            // dtpTanggalAkhir
            // 
            this.dtpTanggalAkhir.CustomFormat = "dd MMMM yyyy HH:mm tt";
            this.dtpTanggalAkhir.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalAkhir.Location = new System.Drawing.Point(163, 35);
            this.dtpTanggalAkhir.Name = "dtpTanggalAkhir";
            this.dtpTanggalAkhir.Size = new System.Drawing.Size(363, 26);
            this.dtpTanggalAkhir.TabIndex = 4;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(163, 67);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(363, 26);
            this.txtFilter.TabIndex = 5;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.crystalReportViewer1, 3);
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 99);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(656, 392);
            this.crystalReportViewer1.TabIndex = 6;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTampilkan.Location = new System.Drawing.Point(532, 3);
            this.btnTampilkan.Name = "btnTampilkan";
            this.tableLayoutPanel1.SetRowSpan(this.btnTampilkan, 3);
            this.btnTampilkan.Size = new System.Drawing.Size(127, 90);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // datasetPOS
            // 
            this.datasetPOS.DataSetName = "DatasetPOS";
            this.datasetPOS.Locale = new System.Globalization.CultureInfo("en-US");
            this.datasetPOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adapterLaporanRestok
            // 
            this.adapterLaporanRestok.ClearBeforeFill = true;
            // 
            // FormLaporanRestok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormLaporanRestok";
            this.Text = "FormLaporanRestok";
            this.Load += new System.EventHandler(this.FormLaporanRestok_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnTampilkan;
        private DatasetPOS datasetPOS;
        private DatasetPOSTableAdapters.tbl_laporan_restokTableAdapter adapterLaporanRestok;
        private Report.ReportReStok reportReStok;
    }
}