using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        // DateTime endTime, startTime;
        DateTime[] endTime, startTime;
        public Form1()
        {
            InitializeComponent();
            startTime = new DateTime[20];
            endTime = new DateTime[20];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label45.Text == "ON")
                MessageBox.Show("Máy đang ON");
            else
            {
                startTime[0] = DateTime.Now;
                h1.Text = startTime[0].ToString("HH:mm:ss");
                label45.BackColor = Color.Lime;
                label45.Text = "ON";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label45.Text == "OFF")
                MessageBox.Show("Máy đang OFF");
            else
            {
                endTime[0] = DateTime.Now;
                TinhTien frm2 = new TinhTien(endTime, startTime, 0);
                frm2.ShowDialog();
                label45.BackColor = Color.Red;
                label45.Text = "OFF";
                endTime[0] = DateTime.Parse("00:00:00");
                startTime[0] = DateTime.Parse("00:00:00");
                h1.Text = "00:00:00";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label44.Text == "ON")
                MessageBox.Show("Máy đang ON");
            else
            {
                startTime[1] = DateTime.Now;
                h2.Text = startTime[1].ToString("HH:mm:ss");
                label44.BackColor = Color.Lime;
                label44.Text = "ON";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label44.Text == "OFF")
                MessageBox.Show("Máy đang OFF");
            else
            {
                endTime[1] = DateTime.Now;
                TinhTien frm2 = new TinhTien(endTime, startTime, 1);
                frm2.ShowDialog();
                label44.BackColor = Color.Red;
                label44.Text = "OFF";
                endTime[1] = DateTime.Parse("00:00:00");
                startTime[1] = DateTime.Parse("00:00:00");
                h2.Text = "00:00:00";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            startTime[2] = DateTime.Now;
            h3.Text = startTime[2].ToString("HH:mm:ss");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            endTime[2] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 2);
            frm2.ShowDialog();
            endTime[2] = DateTime.Parse("00:00:00");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            startTime[3] = DateTime.Now;
            h4.Text = startTime[3].ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            endTime[3] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 3);
            frm2.ShowDialog();
            endTime[3] = DateTime.Parse("00:00:00");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            startTime[4] = DateTime.Now;
            h5.Text = startTime[4].ToString("HH:mm:ss");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            endTime[4] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 4);
            frm2.ShowDialog();
            endTime[4] = DateTime.Parse("00:00:00");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            startTime[5] = DateTime.Now;
            h6.Text = startTime[5].ToString("HH:mm:ss");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            endTime[5] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 5);
            frm2.ShowDialog();
            endTime[5] = DateTime.Parse("00:00:00");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            startTime[6] = DateTime.Now;
            h7.Text = startTime[6].ToString("HH:mm:ss");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            endTime[6] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 6);
            frm2.ShowDialog();
            endTime[6] = DateTime.Parse("00:00:00");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            startTime[7] = DateTime.Now;
            h8.Text = startTime[7].ToString("HH:mm:ss");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            endTime[7] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 7);
            frm2.ShowDialog();
            endTime[7] = DateTime.Parse("00:00:00");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            startTime[8] = DateTime.Now;
            h9.Text = startTime[8].ToString("HH:mm:ss");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            endTime[8] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 8);
            frm2.ShowDialog();
            endTime[8] = DateTime.Parse("00:00:00");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            startTime[8] = DateTime.Now;
            h10.Text = startTime[8].ToString("HH:mm:ss");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            endTime[9] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 9);
            frm2.ShowDialog();
            endTime[9] = DateTime.Parse("00:00:00");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            startTime[10] = DateTime.Now;
            h11.Text = startTime[10].ToString("HH:mm:ss");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            endTime[10] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 10);
            frm2.ShowDialog();
            endTime[10] = DateTime.Parse("00:00:00");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            startTime[11] = DateTime.Now;
            h12.Text = startTime[11].ToString("HH:mm:ss");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            endTime[11] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 11);
            frm2.ShowDialog();
            endTime[11] = DateTime.Parse("00:00:00");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            startTime[12] = DateTime.Now;
            h13.Text = startTime[12].ToString("HH:mm:ss");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            endTime[12] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 12);
            frm2.ShowDialog();
            endTime[12] = DateTime.Parse("00:00:00");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            startTime[13] = DateTime.Now;
            h14.Text = startTime[13].ToString("HH:mm:ss");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            endTime[13] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 13);
            frm2.ShowDialog();
            endTime[13] = DateTime.Parse("00:00:00");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            startTime[14] = DateTime.Now;
            h15.Text = startTime[14].ToString("HH:mm:ss");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            endTime[14] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 14);
            frm2.ShowDialog();
            endTime[14] = DateTime.Parse("00:00:00");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            startTime[15] = DateTime.Now;
            h16.Text = startTime[15].ToString("HH:mm:ss");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            endTime[15] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 15);
            frm2.ShowDialog();
            endTime[15] = DateTime.Parse("00:00:00");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            startTime[16] = DateTime.Now;
            h17.Text = startTime[16].ToString("HH:mm:ss");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            endTime[16] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 16);
            frm2.ShowDialog();
            endTime[16] = DateTime.Parse("00:00:00");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            startTime[17] = DateTime.Now;
            h18.Text = startTime[17].ToString("HH:mm:ss");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            endTime[17] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 17);
            frm2.ShowDialog();
            endTime[17] = DateTime.Parse("00:00:00");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            startTime[18] = DateTime.Now;
            h19.Text = startTime[18].ToString("HH:mm:ss");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            endTime[18] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 18);
            frm2.ShowDialog();
            endTime[18] = DateTime.Parse("00:00:00");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            startTime[19] = DateTime.Now;
            h20.Text = startTime[19].ToString("HH:mm:ss");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            endTime[19] = DateTime.Now;
            TinhTien frm2 = new TinhTien(endTime, startTime, 19);
            frm2.ShowDialog();
            endTime[19] = DateTime.Parse("00:00:00");
        }
    
    }
}
