namespace POS.Forms
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mASTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATABARANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kATEGORIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUPPLIERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sTOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hARGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSAKSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pENJUALANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARANGMASUKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARANGKELUARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAPORANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pENJUALANToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOKBARANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pENGATURANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAMPILANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.dATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERIFIKASIDATABASEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.pENGGUNAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKAKSESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bARCODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kELUARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssVersi = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.mASTERToolStripMenuItem,
            this.tRANSAKSIToolStripMenuItem,
            this.lAPORANToolStripMenuItem,
            this.pENGATURANToolStripMenuItem,
            this.bARCODEToolStripMenuItem,
            this.kELUARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(936, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Image = global::POS.Properties.Resources.arrow_right_to_bracket;
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.lOGINToolStripMenuItem.Text = "LO&GIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // mASTERToolStripMenuItem
            // 
            this.mASTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dATABARANGToolStripMenuItem,
            this.kATEGORIToolStripMenuItem,
            this.sUPPLIERToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sTOKToolStripMenuItem,
            this.hARGAToolStripMenuItem});
            this.mASTERToolStripMenuItem.Image = global::POS.Properties.Resources.database;
            this.mASTERToolStripMenuItem.Name = "mASTERToolStripMenuItem";
            this.mASTERToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.mASTERToolStripMenuItem.Text = "&MASTER";
            // 
            // dATABARANGToolStripMenuItem
            // 
            this.dATABARANGToolStripMenuItem.Name = "dATABARANGToolStripMenuItem";
            this.dATABARANGToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.dATABARANGToolStripMenuItem.Text = "DATA &BARANG";
            this.dATABARANGToolStripMenuItem.Click += new System.EventHandler(this.dATABARANGToolStripMenuItem_Click);
            // 
            // kATEGORIToolStripMenuItem
            // 
            this.kATEGORIToolStripMenuItem.Name = "kATEGORIToolStripMenuItem";
            this.kATEGORIToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.kATEGORIToolStripMenuItem.Text = "&KATEGORI";
            this.kATEGORIToolStripMenuItem.Click += new System.EventHandler(this.kATEGORIToolStripMenuItem_Click);
            // 
            // sUPPLIERToolStripMenuItem
            // 
            this.sUPPLIERToolStripMenuItem.Name = "sUPPLIERToolStripMenuItem";
            this.sUPPLIERToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.sUPPLIERToolStripMenuItem.Text = "&SUPPLIER";
            this.sUPPLIERToolStripMenuItem.Click += new System.EventHandler(this.sUPPLIERToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // sTOKToolStripMenuItem
            // 
            this.sTOKToolStripMenuItem.Name = "sTOKToolStripMenuItem";
            this.sTOKToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.sTOKToolStripMenuItem.Text = "S&TOK";
            this.sTOKToolStripMenuItem.Click += new System.EventHandler(this.sTOKToolStripMenuItem_Click);
            // 
            // hARGAToolStripMenuItem
            // 
            this.hARGAToolStripMenuItem.Name = "hARGAToolStripMenuItem";
            this.hARGAToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.hARGAToolStripMenuItem.Text = "&HARGA";
            this.hARGAToolStripMenuItem.Click += new System.EventHandler(this.hARGAToolStripMenuItem_Click);
            // 
            // tRANSAKSIToolStripMenuItem
            // 
            this.tRANSAKSIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pENJUALANToolStripMenuItem,
            this.bARANGMASUKToolStripMenuItem,
            this.bARANGKELUARToolStripMenuItem});
            this.tRANSAKSIToolStripMenuItem.Image = global::POS.Properties.Resources.money_bill_transfer;
            this.tRANSAKSIToolStripMenuItem.Name = "tRANSAKSIToolStripMenuItem";
            this.tRANSAKSIToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.tRANSAKSIToolStripMenuItem.Text = "&TRANSAKSI";
            // 
            // pENJUALANToolStripMenuItem
            // 
            this.pENJUALANToolStripMenuItem.Image = global::POS.Properties.Resources.cart_arrow_down;
            this.pENJUALANToolStripMenuItem.Name = "pENJUALANToolStripMenuItem";
            this.pENJUALANToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.pENJUALANToolStripMenuItem.Text = "&PENJUALAN";
            this.pENJUALANToolStripMenuItem.Click += new System.EventHandler(this.pENJUALANToolStripMenuItem_Click);
            // 
            // bARANGMASUKToolStripMenuItem
            // 
            this.bARANGMASUKToolStripMenuItem.Image = global::POS.Properties.Resources.cart_plus;
            this.bARANGMASUKToolStripMenuItem.Name = "bARANGMASUKToolStripMenuItem";
            this.bARANGMASUKToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.bARANGMASUKToolStripMenuItem.Text = "RE-&STOK BARANG";
            this.bARANGMASUKToolStripMenuItem.Click += new System.EventHandler(this.bARANGMASUKToolStripMenuItem_Click);
            // 
            // bARANGKELUARToolStripMenuItem
            // 
            this.bARANGKELUARToolStripMenuItem.Image = global::POS.Properties.Resources.cart_shopping;
            this.bARANGKELUARToolStripMenuItem.Name = "bARANGKELUARToolStripMenuItem";
            this.bARANGKELUARToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.bARANGKELUARToolStripMenuItem.Text = "&BARANG KELUAR";
            this.bARANGKELUARToolStripMenuItem.Click += new System.EventHandler(this.bARANGKELUARToolStripMenuItem_Click);
            // 
            // lAPORANToolStripMenuItem
            // 
            this.lAPORANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pENJUALANToolStripMenuItem1,
            this.sTOKBARANGToolStripMenuItem,
            this.lOGToolStripMenuItem1});
            this.lAPORANToolStripMenuItem.Image = global::POS.Properties.Resources.book;
            this.lAPORANToolStripMenuItem.Name = "lAPORANToolStripMenuItem";
            this.lAPORANToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.lAPORANToolStripMenuItem.Text = "&LAPORAN";
            this.lAPORANToolStripMenuItem.Click += new System.EventHandler(this.lAPORANToolStripMenuItem_Click);
            // 
            // pENJUALANToolStripMenuItem1
            // 
            this.pENJUALANToolStripMenuItem1.Image = global::POS.Properties.Resources.cart_arrow_down;
            this.pENJUALANToolStripMenuItem1.Name = "pENJUALANToolStripMenuItem1";
            this.pENJUALANToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.pENJUALANToolStripMenuItem1.Text = "&PENJUALAN";
            this.pENJUALANToolStripMenuItem1.Click += new System.EventHandler(this.pENJUALANToolStripMenuItem1_Click);
            // 
            // sTOKBARANGToolStripMenuItem
            // 
            this.sTOKBARANGToolStripMenuItem.Image = global::POS.Properties.Resources.cart_plus;
            this.sTOKBARANGToolStripMenuItem.Name = "sTOKBARANGToolStripMenuItem";
            this.sTOKBARANGToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.sTOKBARANGToolStripMenuItem.Text = "&RE-STOK";
            this.sTOKBARANGToolStripMenuItem.Click += new System.EventHandler(this.sTOKBARANGToolStripMenuItem_Click);
            // 
            // lOGToolStripMenuItem1
            // 
            this.lOGToolStripMenuItem1.Image = global::POS.Properties.Resources.list;
            this.lOGToolStripMenuItem1.Name = "lOGToolStripMenuItem1";
            this.lOGToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.lOGToolStripMenuItem1.Text = "L&OG";
            this.lOGToolStripMenuItem1.Click += new System.EventHandler(this.lOGToolStripMenuItem1_Click);
            // 
            // pENGATURANToolStripMenuItem
            // 
            this.pENGATURANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRINTERToolStripMenuItem,
            this.tAMPILANToolStripMenuItem,
            this.toolStripMenuItem2,
            this.dATAToolStripMenuItem,
            this.vERIFIKASIDATABASEToolStripMenuItem,
            this.toolStripMenuItem3,
            this.pENGGUNAToolStripMenuItem,
            this.hAKAKSESToolStripMenuItem});
            this.pENGATURANToolStripMenuItem.Image = global::POS.Properties.Resources.gear;
            this.pENGATURANToolStripMenuItem.Name = "pENGATURANToolStripMenuItem";
            this.pENGATURANToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.pENGATURANToolStripMenuItem.Text = "&PENGATURAN";
            // 
            // pRINTERToolStripMenuItem
            // 
            this.pRINTERToolStripMenuItem.Image = global::POS.Properties.Resources.print;
            this.pRINTERToolStripMenuItem.Name = "pRINTERToolStripMenuItem";
            this.pRINTERToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.pRINTERToolStripMenuItem.Text = "&PRINTER";
            this.pRINTERToolStripMenuItem.Click += new System.EventHandler(this.pRINTERToolStripMenuItem_Click);
            // 
            // tAMPILANToolStripMenuItem
            // 
            this.tAMPILANToolStripMenuItem.Image = global::POS.Properties.Resources.display;
            this.tAMPILANToolStripMenuItem.Name = "tAMPILANToolStripMenuItem";
            this.tAMPILANToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.tAMPILANToolStripMenuItem.Text = "&TAMPILAN";
            this.tAMPILANToolStripMenuItem.Click += new System.EventHandler(this.tAMPILANToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 6);
            // 
            // dATAToolStripMenuItem
            // 
            this.dATAToolStripMenuItem.Image = global::POS.Properties.Resources.database;
            this.dATAToolStripMenuItem.Name = "dATAToolStripMenuItem";
            this.dATAToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.dATAToolStripMenuItem.Text = "&DATABASE";
            this.dATAToolStripMenuItem.Click += new System.EventHandler(this.dATAToolStripMenuItem_Click);
            // 
            // vERIFIKASIDATABASEToolStripMenuItem
            // 
            this.vERIFIKASIDATABASEToolStripMenuItem.Image = global::POS.Properties.Resources.repeat;
            this.vERIFIKASIDATABASEToolStripMenuItem.Name = "vERIFIKASIDATABASEToolStripMenuItem";
            this.vERIFIKASIDATABASEToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.vERIFIKASIDATABASEToolStripMenuItem.Text = "&VERIFIKASI DATABASE";
            this.vERIFIKASIDATABASEToolStripMenuItem.Click += new System.EventHandler(this.vERIFIKASIDATABASEToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(232, 6);
            // 
            // pENGGUNAToolStripMenuItem
            // 
            this.pENGGUNAToolStripMenuItem.Image = global::POS.Properties.Resources.user;
            this.pENGGUNAToolStripMenuItem.Name = "pENGGUNAToolStripMenuItem";
            this.pENGGUNAToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.pENGGUNAToolStripMenuItem.Text = "PENGGUNA";
            this.pENGGUNAToolStripMenuItem.Click += new System.EventHandler(this.pENGGUNAToolStripMenuItem_Click);
            // 
            // hAKAKSESToolStripMenuItem
            // 
            this.hAKAKSESToolStripMenuItem.Image = global::POS.Properties.Resources.lock_open;
            this.hAKAKSESToolStripMenuItem.Name = "hAKAKSESToolStripMenuItem";
            this.hAKAKSESToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.hAKAKSESToolStripMenuItem.Text = "HAK AKSES";
            this.hAKAKSESToolStripMenuItem.Click += new System.EventHandler(this.hAKAKSESToolStripMenuItem_Click);
            // 
            // bARCODEToolStripMenuItem
            // 
            this.bARCODEToolStripMenuItem.Image = global::POS.Properties.Resources.qrcode;
            this.bARCODEToolStripMenuItem.Name = "bARCODEToolStripMenuItem";
            this.bARCODEToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.bARCODEToolStripMenuItem.Text = "&QR";
            this.bARCODEToolStripMenuItem.Click += new System.EventHandler(this.bARCODEToolStripMenuItem_Click);
            // 
            // kELUARToolStripMenuItem
            // 
            this.kELUARToolStripMenuItem.Image = global::POS.Properties.Resources.arrow_right_from_bracket;
            this.kELUARToolStripMenuItem.Name = "kELUARToolStripMenuItem";
            this.kELUARToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.kELUARToolStripMenuItem.Text = "&KELUAR";
            this.kELUARToolStripMenuItem.Click += new System.EventHandler(this.kELUARToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsername,
            this.tssUser,
            this.toolStripStatusLabel3,
            this.tssVersi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(936, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsUsername
            // 
            this.tsUsername.Name = "tsUsername";
            this.tsUsername.Size = new System.Drawing.Size(0, 21);
            // 
            // tssUser
            // 
            this.tssUser.BackColor = System.Drawing.Color.Red;
            this.tssUser.ForeColor = System.Drawing.Color.White;
            this.tssUser.Image = global::POS.Properties.Resources.user;
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(119, 21);
            this.tssUser.Text = "[belum login]";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(14, 21);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // tssVersi
            // 
            this.tssVersi.Image = global::POS.Properties.Resources.code;
            this.tssVersi.Name = "tssVersi";
            this.tssVersi.Size = new System.Drawing.Size(69, 21);
            this.tssVersi.Text = "[versi]";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::POS.Properties.Resources.POS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(936, 410);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mASTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATABARANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kATEGORIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUPPLIERToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hARGAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSAKSIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pENJUALANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bARANGMASUKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAPORANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pENJUALANToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTOKBARANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pENGATURANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kELUARToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRINTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAMPILANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bARCODEToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsUsername;
        private System.Windows.Forms.ToolStripMenuItem bARANGKELUARToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vERIFIKASIDATABASEToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssUser;
        private System.Windows.Forms.ToolStripStatusLabel tssVersi;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pENGGUNAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKAKSESToolStripMenuItem;
    }
}