﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void loadNextImage()
        {
            if(imageNumber == 3) 
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jqp", imageNumber);
            imageNumber++;
        }   


        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
