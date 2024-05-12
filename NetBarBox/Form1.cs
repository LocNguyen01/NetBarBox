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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customize_bangthongtin();
        }
        private void customize_bangthongtin() //an hien bang thong tin khach hang
        {
            panel4.Visible = false;
        }
        private void hide_panel()
        {
            if (panel4.Visible == true)
            {
                panel4.Visible = false;
            }
        }
        private void show_panel(Panel panelkhachhang)
        {
            if (panelkhachhang.Visible == false)
            {
                hide_panel();
                panelkhachhang.Visible = true;
            } else
            {
                panelkhachhang.Visible = false;
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
            panel3.Controls.Add(extraForm);
            panel3.Tag = extraForm;
            extraForm.BringToFront();
            extraForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_goinhanvien_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FGoiNhanVien());
            label2.Text = "Gọi Nhân Viên";
        }

        private void bt_giohang_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FGioHang());
        }
        private void bt_muado_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FMuaDo());
            label2.Text = "Mua Đồ";
        }

        private void bt_thongtinkhachhang_Click(object sender, EventArgs e)
        {
            show_panel(panel4);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            hide_panel();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hide_panel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bt_thongbao_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FThongBao());
            label2.Text = "Thông Báo";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_trangchu_Click(object sender, EventArgs e)
        {
            label2.Text = "Trang Chủ";
        }
    }
}
