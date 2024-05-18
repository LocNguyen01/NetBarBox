using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetBarBox
{
    public partial class FMuaDo : Form
    {
        public FMuaDo()
        {
            InitializeComponent();
        }
        private void FMuaDo_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Tìm kiếm";
            textBox1.ForeColor = Color.Silver;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tìm kiếm")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Tìm kiếm";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}
