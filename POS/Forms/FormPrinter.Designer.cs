namespace POS.Forms
{
    partial class FormPrinter
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numMarginBawah = new System.Windows.Forms.NumericUpDown();
            this.numMarginAtas = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numMarginKanan = new System.Windows.Forms.NumericUpDown();
            this.numMarginKiri = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numPaperWidth = new System.Windows.Forms.NumericUpDown();
            this.numPaperHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrinterName = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginBawah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginAtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginKanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginKiri)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaperWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaperHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.68922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.31078F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSimpan, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbPrinterName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numMarginBawah);
            this.groupBox2.Controls.Add(this.numMarginAtas);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numMarginKanan);
            this.groupBox2.Controls.Add(this.numMarginKiri);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 156);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Margin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(513, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cm";
            // 
            // numMarginBawah
            // 
            this.numMarginBawah.DecimalPlaces = 1;
            this.numMarginBawah.Location = new System.Drawing.Point(345, 113);
            this.numMarginBawah.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMarginBawah.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numMarginBawah.Name = "numMarginBawah";
            this.numMarginBawah.Size = new System.Drawing.Size(155, 26);
            this.numMarginBawah.TabIndex = 11;
            // 
            // numMarginAtas
            // 
            this.numMarginAtas.DecimalPlaces = 1;
            this.numMarginAtas.Location = new System.Drawing.Point(345, 81);
            this.numMarginAtas.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMarginAtas.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numMarginAtas.Name = "numMarginAtas";
            this.numMarginAtas.Size = new System.Drawing.Size(155, 26);
            this.numMarginAtas.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Atas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 121);
            this.label13.Margin = new System.Windows.Forms.Padding(10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "Bawah";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(513, 83);
            this.label14.Margin = new System.Windows.Forms.Padding(10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "Cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cm";
            // 
            // numMarginKanan
            // 
            this.numMarginKanan.DecimalPlaces = 1;
            this.numMarginKanan.Location = new System.Drawing.Point(345, 49);
            this.numMarginKanan.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMarginKanan.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numMarginKanan.Name = "numMarginKanan";
            this.numMarginKanan.Size = new System.Drawing.Size(155, 26);
            this.numMarginKanan.TabIndex = 5;
            // 
            // numMarginKiri
            // 
            this.numMarginKiri.DecimalPlaces = 1;
            this.numMarginKiri.Location = new System.Drawing.Point(345, 17);
            this.numMarginKiri.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numMarginKiri.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numMarginKiri.Name = "numMarginKiri";
            this.numMarginKiri.Size = new System.Drawing.Size(155, 26);
            this.numMarginKiri.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kiri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Kanan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(513, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konfigurasi Printer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Printer";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(10, 387);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(10);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(118, 43);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numPaperWidth);
            this.groupBox1.Controls.Add(this.numPaperHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ukuran Kertas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cm";
            // 
            // numPaperWidth
            // 
            this.numPaperWidth.DecimalPlaces = 1;
            this.numPaperWidth.Location = new System.Drawing.Point(345, 53);
            this.numPaperWidth.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPaperWidth.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numPaperWidth.Name = "numPaperWidth";
            this.numPaperWidth.Size = new System.Drawing.Size(155, 26);
            this.numPaperWidth.TabIndex = 5;
            // 
            // numPaperHeight
            // 
            this.numPaperHeight.DecimalPlaces = 1;
            this.numPaperHeight.Location = new System.Drawing.Point(345, 17);
            this.numPaperHeight.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPaperHeight.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numPaperHeight.Name = "numPaperHeight";
            this.numPaperHeight.Size = new System.Drawing.Size(155, 26);
            this.numPaperHeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Panjang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lebar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cm";
            // 
            // cmbPrinterName
            // 
            this.cmbPrinterName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPrinterName.FormattingEnabled = true;
            this.cmbPrinterName.Location = new System.Drawing.Point(280, 73);
            this.cmbPrinterName.Margin = new System.Windows.Forms.Padding(10);
            this.cmbPrinterName.Name = "cmbPrinterName";
            this.cmbPrinterName.Size = new System.Drawing.Size(408, 26);
            this.cmbPrinterName.TabIndex = 6;
            // 
            // FormPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(698, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormPrinter";
            this.Text = "FormPrinter";
            this.Load += new System.EventHandler(this.FormPrinter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginBawah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginAtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginKanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginKiri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaperWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPaperHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPaperWidth;
        private System.Windows.Forms.NumericUpDown numPaperHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrinterName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numMarginBawah;
        private System.Windows.Forms.NumericUpDown numMarginAtas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMarginKanan;
        private System.Windows.Forms.NumericUpDown numMarginKiri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}