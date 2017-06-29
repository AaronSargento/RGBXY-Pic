using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Input: The user can click 'Load Picture' to load a picture onto the application. The user can click 'Exit' to exit out of application.
// Output: Once the picture is loaded, if the user clicks on any part of the picture box, the location (x,y) and color (r,g,b) will be given of the current pixel

namespace Homework_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            This function allows the user to exit out of the application
        */
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
            This function will allow the user to grab a picture from their library
        */
        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            //Clear the boxes each time we want to load a picture
            locationListBox.Items.Clear();
            colorListBox.Items.Clear();

            OpenFileDialog image1 = new OpenFileDialog();
            image1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";

            if (image1.ShowDialog() == DialogResult.OK)
            {
                loadPictureBox.Image = new Bitmap(image1.FileName);
                loadPictureBox.Size = loadPictureBox.Image.Size;
                promptLabel.Text = "Move mouse to get current Pixel Location and Color";
            }
        }

        /*
            This function will allow the user to get the color and location of the pixel clicked on the picture box.
        */
        private void loadPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Clear the List Boxes for each iteration
            locationListBox.Items.Clear();
            colorListBox.Items.Clear();

            try
            {
                //Add titles
                locationListBox.Items.Add("Pixel Location (X, Y)");
                colorListBox.Items.Add("Pixel Color (R, G, B)");

                Bitmap image2 = new Bitmap(loadPictureBox.Image);
                Color pixelColor = image2.GetPixel(e.X, e.Y);
                locationListBox.Items.Add("X:" + e.X.ToString() + ", Y: " + e.Y.ToString());
                colorListBox.Items.Add("R: " + pixelColor.R.ToString() + ", G: " + pixelColor.G.ToString() + ", B: " + pixelColor.B.ToString());

                promptLabel.Text = "Successfully solidified current pixel location and color";
                MessageBox.Show(" Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
            This function will allow the user to get the color and location of the current pixel (on cursor) on the picture box.
        */
        private void loadPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (loadPictureBox.Image != null)
            {
                promptLabel.Text = "Click mouse to get current Pixel Location and Color";
                locationListBox.Items.Insert(0, "Pixel Location (X, Y)");
                colorListBox.Items.Insert(0, "Pixel Color (R, G, B)");

                try
                {
                    Bitmap image2 = new Bitmap(loadPictureBox.Image);
                    Color pixelColor = image2.GetPixel(e.X, e.Y);

                    //Place current location at top of list
                    locationListBox.Items.Insert(1, "X:" + e.X.ToString() + ", Y: " + e.Y.ToString());
                    colorListBox.Items.Insert(1, "R: " + pixelColor.R.ToString() + ", G: " + pixelColor.G.ToString() + ", B: " + pixelColor.B.ToString());

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
