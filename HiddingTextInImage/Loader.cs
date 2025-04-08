using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HiddingTextInImage
{
    public partial class Loader: Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(FormTrouver.filePath);
            pgbLoader.Maximum = image.Height * image.Width;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Step()
        {
            pgbLoader.PerformStep();
        }
        public async Task End()
        {
            pgbLoader.Value = pgbLoader.Maximum;
            Thread.Sleep(800);
            this.Hide();
        }

    }
}
