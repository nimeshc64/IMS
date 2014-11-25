using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms;

using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;


namespace InstituteMS
{
    class QrEncod
    {
        private string data;
        private Bitmap img;

        public void SetData(string data)
        {          
                this.data =data;           
        }

        public Bitmap GetImage()
        {                     
                return this.img;            
        }

        public void Encoding()
        {    
            try
            {
                var qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
                var qrCode = qrEncoder.Encode(data);
                MemoryStream ms = new MemoryStream();
                var renderer = new GraphicsRenderer(new FixedCodeSize(100, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
                renderer.WriteToStream(qrCode.Matrix, ImageFormat.Jpeg, ms);
                img = new Bitmap(ms); 
            }
            catch(Exception ex)
            { 

            }
        }
        public void SaveImageCapture(System.Drawing.Image image,string name)
        {

            SaveFileDialog s = new SaveFileDialog();
            s.FileName =name;// Default file name
            s.DefaultExt = ".Jpg";// Default file extension
            s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();

            }

        }
    }
}
