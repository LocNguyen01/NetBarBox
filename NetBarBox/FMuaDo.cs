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

        private Form currentExtraForm;
        private void OpenExtraForm(Form extraForm) //mở form ko cần trang form mới
        {
            if (currentExtraForm != null)
            {
                currentExtraForm.Close();
            }
            currentExtraForm = extraForm;
            extraForm.TopLevel = false;
            extraForm.FormBorderStyle = FormBorderStyle.None;
            extraForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(extraForm);
            panel2.Tag = extraForm;
            extraForm.BringToFront();
            extraForm.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenExtraForm( new FGioHang());
        }
    }
}
