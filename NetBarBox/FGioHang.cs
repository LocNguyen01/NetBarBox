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
    public partial class FGioHang : Form
    {
        public FGioHang()
        {
            InitializeComponent();
            panel1.Visible = true;
        }
        private void show_panel()
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
        }

        private void hide_panel(Panel panelgiohang)
        {
            if (panelgiohang.Visible == true)
            {
                show_panel();
                panelgiohang.Visible = false;
            }
            else
            {
                panelgiohang.Visible = true;
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FMuaDo());
            hide_panel(panel1);
            pictureBox1.Visible = false;
        }
    }
}
