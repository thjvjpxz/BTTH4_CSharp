﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txta.Text);
                int b = int.Parse(txtb.Text);

                HoanDoi.HoanVi(ref a, ref b);
                txta.Text = a + "";
                txtb.Text = b + "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txta.Focus();
        }
    }
}
