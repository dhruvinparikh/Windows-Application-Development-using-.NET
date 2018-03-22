using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuApplication
{
    public partial class ImageGallery : Form
    {
        public ImageGallery()
        {
            InitializeComponent();
        }

        private void showPic(object sender, EventArgs e)
        {

            

        }

        private void ImageGallery_Load(object sender, EventArgs e)
        {
            foreach (Image i in imageList1.Images)
            {
                pictureBox1.Image = i;

                System.Threading.Thread.Sleep(2000);
                pictureBox1.Refresh();

            }
        }
    }
}
