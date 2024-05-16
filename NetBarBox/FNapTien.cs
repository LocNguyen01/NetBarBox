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
    public partial class FNapTien : Form
    {
        public FNapTien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(65, 173, 204);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(65, 173, 204);
        }
    }
}
