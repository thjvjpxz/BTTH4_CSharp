using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class TimKiem : Form
    {
        public int index, lengthKey;
        public string txtND;
        public TimKiem(string txtND)
        {
            InitializeComponent();
            this.txtND = txtND;
            
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyWord = txtCon.Text;

            if (keyWord != "")
            {
                index = txtND.IndexOf(keyWord);
                lengthKey = keyWord.Length;
            }
        }
    }
}
