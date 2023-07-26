using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Imaging;

namespace CodigoQR
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }



        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtValor.Text, out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
            ImgQr.BackgroundImage = imagen;
            imagen.Save("Imagen.Png", ImageFormat.Png);
            btnGuardar.Enabled = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias...");
            Application.Exit();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image image = (Image)ImgQr.BackgroundImage.Clone();
            SaveFileDialog CajaDialogoGuardar = new SaveFileDialog();
            CajaDialogoGuardar.AddExtension = true;
            CajaDialogoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDialogoGuardar.ShowDialog();

            if (!string.IsNullOrEmpty(CajaDialogoGuardar.FileName))
            {
                image.Save(CajaDialogoGuardar.FileName, ImageFormat.Png);
            }
            image.Dispose();
        }
    }
}