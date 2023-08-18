using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_Google_MAp
{
    public partial class Load_Form : Form
    {
        int strtpoint = 0;

        public Load_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            strtpoint++;
            progressBar1.Value = strtpoint;
            if (strtpoint==100)
            {
                timer1.Stop();
                //progressBar1.Value = 0;
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }
    }
}
