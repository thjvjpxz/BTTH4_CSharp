using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        private double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out a))
                lbErrorA.Text = "Vui lòng nhập số";
            else
                lbErrorA.Text = "";
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtB.Text, out b))
                lbErrorB.Text = "Vui lòng nhập số";
            else
                lbErrorB.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtB.Text, out b) || !double.TryParse(txtA.Text, out a) || !double.TryParse(txtC.Text, out c))
                MessageBox.Show("Vui lòng nhập số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                double denta = b * b - 4 * a * c;
                if (denta < 0)
                {
                    txtX1.Text = "Phương trình vô nghiệm!";
                    txtX2.Text = "Phương trình vô nghiệm!";
                }
                else if (denta == 0)
                {
                    double res = -b / (2 * a);
                    txtX1.Text = res.ToString();
                    txtX2.Text = res.ToString();
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                    txtX1.Text = x1.ToString();
                    txtX2.Text = x2.ToString();
                }
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (!double.TryParse(txtC.Text, out c))
                lbErrorC.Text = "Vui lòng nhập số";
            else
                lbErrorC.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = "Đổi màu";
            contextMenuStrip1.Items.Add(toolStripMenuItem);

            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem2.Text = "Đổi font";
            contextMenuStrip1.Items.Add(toolStripMenuItem2);

            toolStripMenuItem.Click += toolStripMenuItem_Click;
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Đổi font của đối tượng được bôi đen trên form sang font mới
                Control control = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
                if (control != null)
                {
                    control.Font = fontDialog1.Font;
                }
            }
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Đổi màu của đối tượng được bôi đen trên form sang màu mới
                Control control = this.GetChildAtPoint(this.PointToClient(Cursor.Position));
                if (control != null)
                {
                    control.BackColor = colorDialog1.Color;
                }
            }
        }
    }
}
