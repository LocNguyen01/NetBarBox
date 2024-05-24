using System;
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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Username";
            textBox2.Text = "Password";
            textBox1.ForeColor = Color.Silver;
            textBox2.ForeColor = Color.Silver;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username" || textBox2.Text == "Password")
            {
                label2.Visible = true;
            }
            /*FMain fMAin = new FMain();
            fMAin.Show();
            this.Hide();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
