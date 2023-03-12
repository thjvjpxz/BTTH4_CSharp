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
    public partial class TinhTien : Form
    {
        DateTime[] endTime, startTime;
        private int i;

        public TinhTien(DateTime[] endTime, DateTime[] startTime, int i)
        {
            InitializeComponent();
            this.endTime = endTime;
            this.startTime = startTime;
            this.i = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TinhTien_Load(object sender, EventArgs e)
        {
            if (endTime[i].ToString() == "00:00:00" && startTime[i].ToString() == "00:00:00")
            {
                timeSD.Text = "Đang OFF";
                gia.Text = "0 đồng";
            }
            else
            {
                double timeOneM = (double)5000 / 60;
                double timeOneS = (double)timeOneM / 60;
                TimeSpan res = endTime[i] - startTime[i];
                timeSD.Text = res.Hours + "h" + res.Minutes + "p" + res.Seconds + "s";
                int tongSoPhut = res.Hours * 60;
                int tongSoGiay = tongSoPhut * 60 + res.Seconds;
                double tongTien = timeOneS * tongSoGiay;
                gia.Text = Math.Round(tongTien, 2) + " đồng";
            }
            
        }
    }
}
