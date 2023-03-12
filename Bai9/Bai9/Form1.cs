using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {

        private List<Info> listInfo;

        public Form1()
        {
            InitializeComponent();
            listInfo = new List<Info>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int soDienThoai;
            if (txtHoTen.Text == "")
                MessageBox.Show("Chưa nhập tên", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDienThoai.Text == "")
                MessageBox.Show("Chưa nhập số điện thoại", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtDiaChi.Text == "")
                MessageBox.Show("Chưa nhập địa chỉ", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!int.TryParse(txtDienThoai.Text, out soDienThoai))
                MessageBox.Show("Điện thoại chỉ được nhập số", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listInfo.Add(new Info(txtHoTen.Text, dtNgaySinh.Value, txtDienThoai.Text, txtDiaChi.Text));
                foreach (Info item in listInfo)
                {
                    ListViewItem list = new ListViewItem(item.HoTen);
                    list.SubItems.Add(item.NgaySinh.ToString("dd/MM/yyyy"));
                    list.SubItems.Add(item.DiaChi);
                    list.SubItems.Add(item.DienThoai);
                    listView1.Items.Add(list);
                }
                listInfo = null;
                listInfo = new List<Info>();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                string date = lvi.SubItems[1].Text;
                string day = date.Substring(0, 2);
                string month = date.Substring(3, 2);
                string year = date.Substring(6);
                string dateNew = month + "/" + day + "/" + year;
                txtHoTen.Text = lvi.SubItems[0].Text;
                dtNgaySinh.Value = DateTime.Parse(dateNew);
                txtDiaChi.Text = lvi.SubItems[2].Text;
                txtDienThoai.Text = lvi.SubItems[3].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người muốn xóa!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                lvi.SubItems[0].Text = txtHoTen.Text;
                lvi.SubItems[1].Text = dtNgaySinh.Value.ToString("dd/MM/yyyy");
                lvi.SubItems[2].Text = txtDiaChi.Text;
                lvi.SubItems[3].Text = txtDienThoai.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người muốn sửa!");
            }
        }
    }
}
