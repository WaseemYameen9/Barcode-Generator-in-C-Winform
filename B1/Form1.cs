using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pic.Image = barcode.Draw(txtEncode.Text,200);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrBarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pic.Image = qrBarcode.Draw(txtEncode.Text, 200);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pic.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
