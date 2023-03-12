using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public string txtND;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveFile()
        {
            SaveFileDialog sv = new SaveFileDialog();

            sv.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
            sv.Title = "Save a Text File";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sv.FileName, txtNoiDung.Text);
            }
        }

        private void OpenFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtNoiDung.Text = File.ReadAllText(open.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.Font = font.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                txtNoiDung.ForeColor = color.Color;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtND = txtNoiDung.Text;
            TimKiem frmTimKiem = new TimKiem(txtND);
            frmTimKiem.Show();

            if (frmTimKiem.index >= 0)
            {
                txtNoiDung.Select(frmTimKiem.index, frmTimKiem.lengthKey);
                txtNoiDung.Focus();
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNoiDung.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNoiDung.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNoiDung.Paste();
        }

        private void txtNoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
                txtNoiDung.Copy();
            else if (e.Control && e.KeyCode == Keys.V)
                txtNoiDung.Paste();
            else if (e.Control && e.KeyCode == Keys.X)
                txtNoiDung.Cut();
            else if (e.Control && e.KeyCode == Keys.S)
                SaveFile();
            else if (e.Control && e.KeyCode == Keys.N)
                txtNoiDung.Text = "";
            else if (e.Control && e.KeyCode == Keys.O)
                OpenFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNoiDung.Text = "";
        }
    }
}
