using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel_of_Fortune_Wheel
{
    public partial class Main : Form
    {
        //Allows the use of the current working directory where the images are then retrieved
        static string livePath = Environment.CurrentDirectory;
        //Utilized in order to create a class of images to use for the spin.
        static Image[] images = new Image[24];
        //Sets the current slot number to 0.
        static int i = 0;
        //Used to make the spinner start in the non spinning
        //position then trigger once button is pressed.
        static bool spinning = false;
        //Used to control the SpinTheWheel function below.
        static Thread SpinWheel = new Thread(SpinTheWheel);
        //Used to close and open SpinWheel throughtout the code.
        static PictureBox wheel = new PictureBox();
        //Initializes the main program and assigns WOF_Wheel to wheel.
        public Main()
        {
            InitializeComponent();
            wheel = WOF_Wheel;
        }
        //Allows the the looping through of all png images, which
        //is what makes it look like the wheel is spinning.
        static void ImageChanger()
        {
            if (i + 1 >= images.Length)
                i = 0;
            else
                i++;
            //Collects the images from the current resource directory.
            images[i] = Image.FromFile(livePath + "\\Resources\\Slot " + (i + 1) + " active.png");
            wheel.Invoke(new Action(() => wheel.BackgroundImage = images[i]));
        }
        //Supposed to spin the wheel at random but it is currently not doing so
        //and keeps landing on the same one.
        static void SpinTheWheel()
        {
            Random random = new Random();
            int cycle = 1;

            for (int y = 0; y < 5; y++)
            {
                //spin speed
                int spin = random.Next((400 - ((cycle - 1) * 150)), (460 - ((cycle - 1) * 110)));
                for (int x = 0; x < spin; x++)
                {
                    ImageChanger();
                    Thread.Sleep(10 * cycle);
                }
                cycle++;
            }
            //This is also have troubles working as it will not actually print the wedge that was landed on.
            spinning = false;
            MessageBox.Show("Congrats!! You won prize " + (i + 1));
            SpinWheel.Abort();
        }
        //Code to make the wheel spin upon click event.
        private void Spin_Button_Click(object sender, EventArgs e)
        {
            if (!spinning)
            {
                Thread SpinWheel = new Thread(SpinTheWheel);
                spinning = true;
                SpinWheel.Start();
            }
        }
    }
}