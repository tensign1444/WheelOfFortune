using System.Drawing;
using System.Windows.Forms;
using WheelOfFortune.Utils.SpinValues;

namespace WheelOfFortune
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            spin();
        }

        private void spin()
        {
            int spinValue = Wheel.Spin();
            Bitmap wheel;
            for (int i = 0; i < 10; i++)
            {
                wheel = new Bitmap(WheelImage.Image);
                WheelImage.Image = RotateImage(wheel, 1);
            }
        }
    }
}