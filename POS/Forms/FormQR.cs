using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace POS.Forms
{
    public partial class FormQR : Form
    {
        public FormQR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBox1.Text,QRCodeGenerator.ECCLevel.Q);
           
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeByte = qrCode.GetGraphic(20);
            MemoryStream ms = new MemoryStream(qrCodeByte);
            //pictureBox1.Image = Image.FromStream(ms);
            Bitmap bmp = new Bitmap(ms);
            Bitmap img = new Bitmap(bmp.Width, bmp.Height);
            Graphics g = Graphics.FromImage(img);
            g.DrawImage(bmp,0,0);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            Font font = new Font("Arial", 30);

            Rectangle r = new Rectangle(0, bmp.Height - 50, bmp.Width, 40);

            g.DrawString(textBox1.Text,font,Brushes.Black,r, sf);
            g.Flush();
            pictureBox1.Image = img;
        }
    }
}
