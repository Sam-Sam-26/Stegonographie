using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddingTextInImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formCacher = new FormCacher();
            formCacher.Show();
        }

        private void btnTrouver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formTrouver = new FormTrouver();
            formTrouver.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(4);
        }
    }
}
