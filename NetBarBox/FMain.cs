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
    public partial class FMain : Form
    {
        public FMain()
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
        private void bt_muado_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FMuaDo());
            label2.Text = "Mua Đồ";
        }

        private void bt_thongtinkhachhang_Click(object sender, EventArgs e)
        {
            show_panel(panel4);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            hide_panel();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hide_panel();
        }

        private void bt_thongbao_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FThongBao());
            label2.Text = "Thông Báo";
        }
        private void bt_trangchu_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FTrangChu());
            label2.Text = "Trang Chủ";
        }

        private void bt_naptien_Click(object sender, EventArgs e)
        {
            OpenExtraForm(new FNapTien());
            label2.Text = "Nạp Tiền";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenExtraForm(new FTrangChu());
            label2.Text = "Trang Chủ";
        }
        bool IsLogout = true;
        private void bt_logout_Click(object sender, EventArgs e)
        {
            IsLogout = false;
            this.Close();
            FDangNhap fDangNhap = new FDangNhap();
            fDangNhap.Show();
        }

        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(IsLogout)
            {
                Application.Exit();
            }
        }
    }
}
