namespace POS.Forms
{
    partial class FormTampilan
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
            this.cmbWarnaForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJenisTulisan = new System.Windows.Forms.ComboBox();
            this.numUkuranTulisan = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWarnaTulisan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numKwitansiFontSize = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUkuranTulisan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKwitansiFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.cmbWarnaForm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbJenisTulisan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numUkuranTulisan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbWarnaTulisan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numKwitansiFontSize, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSimpan, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbWarnaForm
            // 
            this.cmbWarnaForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWarnaForm.FormattingEnabled = true;
            this.cmbWarnaForm.Location = new System.Drawing.Point(197, 99);
            this.cmbWarnaForm.Name = "cmbWarnaForm";
            this.cmbWarnaForm.Size = new System.Drawing.Size(447, 26);
            this.cmbWarnaForm.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Tulisan";
            // 
            // cmbJenisTulisan
            // 
            this.cmbJenisTulisan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbJenisTulisan.FormattingEnabled = true;
            this.cmbJenisTulisan.Location = new System.Drawing.Point(197, 3);
            this.cmbJenisTulisan.Name = "cmbJenisTulisan";
            this.cmbJenisTulisan.Size = new System.Drawing.Size(447, 26);
            this.cmbJenisTulisan.TabIndex = 2;
            // 
            // numUkuranTulisan
            // 
            this.numUkuranTulisan.Dock = System.Windows.Forms.DockStyle.Left;
            this.numUkuranTulisan.Location = new System.Drawing.Point(197, 35);
            this.numUkuranTulisan.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numUkuranTulisan.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUkuranTulisan.Name = "numUkuranTulisan";
            this.numUkuranTulisan.Size = new System.Drawing.Size(142, 26);
            this.numUkuranTulisan.TabIndex = 3;
            this.numUkuranTulisan.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ukuran Tulisan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Warna Tulisan";
            // 
            // cmbWarnaTulisan
            // 
            this.cmbWarnaTulisan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbWarnaTulisan.FormattingEnabled = true;
            this.cmbWarnaTulisan.Location = new System.Drawing.Point(197, 67);
            this.cmbWarnaTulisan.Name = "cmbWarnaTulisan";
            this.cmbWarnaTulisan.Size = new System.Drawing.Size(447, 26);
            this.cmbWarnaTulisan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Warna Form";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(197, 167);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(129, 52);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ukuran Tulisan Kwitansi";
            // 
            // numKwitansiFontSize
            // 
            this.numKwitansiFontSize.Location = new System.Drawing.Point(197, 131);
            this.numKwitansiFontSize.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numKwitansiFontSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numKwitansiFontSize.Name = "numKwitansiFontSize";
            this.numKwitansiFontSize.Size = new System.Drawing.Size(142, 26);
            this.numKwitansiFontSize.TabIndex = 12;
            this.numKwitansiFontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // FormTampilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(647, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormTampilan";
            this.Text = "FormTampilan";
            this.Load += new System.EventHandler(this.FormTampilan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUkuranTulisan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKwitansiFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbJenisTulisan;
        private System.Windows.Forms.NumericUpDown numUkuranTulisan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWarnaTulisan;
        private System.Windows.Forms.ComboBox cmbWarnaForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numKwitansiFontSize;
    }
}