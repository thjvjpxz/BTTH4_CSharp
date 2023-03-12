using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUser.Text = "";
            chkNho.Checked = false;
            txtUser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            
            string thongBao = "Tài Khoản: " + user + "\nMật Khẩu: " + pass;

            if (chkNho.Checked)
                thongBao += "\nBạn có ghi nhớ";
            MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK);
        }
    }
}
