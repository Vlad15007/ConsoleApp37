using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Color myGreen = Color.Teal;
        Color myRed = Color.FromArgb(90, 30, 30);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image (*.png; *.jpg)|*png;*jpg;*jpeg|All files (*.*)|*.*";
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                Bitmap fromPicBox1 = new Bitmap(pictureBox1.Image);
                Bitmap toPicBox2 = new Bitmap(fromPicBox1.Width, fromPicBox1.Height);

                for (int i = 0; i < fromPicBox1.Width; i++)
                {
                    for (int j = 0; j < fromPicBox1.Height; j++)
                    {
                        Color pixelPic1 = fromPicBox1.GetPixel(i, j);
                        int R = pixelPic1.R;
                        int G = pixelPic1.G;
                        int B = pixelPic1.B;
                        int filtr = (R + G + B)/3;
                        if(filtr < 128)
                        {
                            toPicBox2.SetPixel(i, j, myRed);
                        }
                        else
                        {
                            toPicBox2.SetPixel(i, j, myGreen);
                        }
                        //this.Text = filtr.ToString();
                        //break;

                        //toPicBox2.SetPixel(i, j, Color.FromArgb(filtr, filtr, filtr));
                    }
                   // break;
                }
                pictureBox2.Image = toPicBox2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Image != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Сохранить";
                save.Filter = "Image (*.png)|*png|All files (*.*)|*.*";
                if(save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(save.FileName);
                }

            }
        }
    }
}
