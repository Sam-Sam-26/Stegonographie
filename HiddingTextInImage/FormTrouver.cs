using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddingTextInImage
{
    public partial class FormTrouver : Form
    {
        public static string filePath = "";
        public static string filename = "";

        public FormTrouver()
        {
            InitializeComponent();
            filePath = "";
            filename = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        private void FormTrouver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(4);
        }

      

        public async void RecupererMessage()
        {
            Loader form = new Loader();
            form.Show();
            form.Refresh(); // force affichage visuel

            string message = "";
            bool stop = false;

            await Task.Run(() =>
            {
                Bitmap image = new Bitmap(filePath);
                string currentChar = "";

                for (int y = 0; y < image.Height && !stop; y++)
                {
                    for (int x = 0; x < image.Width && !stop; x++)
                    {
                        Color pixel = image.GetPixel(x, y);

                        currentChar += Convert.ToString(pixel.A, 2).PadLeft(8, '0')[7];
                        currentChar += Convert.ToString(pixel.R, 2).PadLeft(8, '0')[7];
                        currentChar += Convert.ToString(pixel.G, 2).PadLeft(8, '0')[7];
                        currentChar += Convert.ToString(pixel.B, 2).PadLeft(8, '0')[7];

                        form.Invoke((MethodInvoker)(() => form.Step()));
                        Thread.Sleep(2);

                        while (currentChar.Length >= 8)
                        {
                            string byteStr = currentChar.Substring(0, 8);
                            currentChar = currentChar.Substring(8);

                            if (byteStr == "00000000")
                            {
                                stop = true;
                                break;
                            }

                            char c = (char)Convert.ToInt32(byteStr, 2);
                            message += c;
                        }
                    }
                }
            });


            if (!stop)
            {
                message = "";
                MessageBox.Show("There is no message in that image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tbxMessage.Text = message + "\r\n------------------------------------------| end of message |-----------------------------------------";
            }
            await form.End();
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            tbxMessage.Text = "";
            filePath = "";
            filename = "";
            lblFichierSelectionne.Text = "No file selected";
            pbxImage.Image = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "Documents";
                openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Select your image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    string[] s = filePath.Split('\\');
                    filename = s[s.Length - 1];
                }
                if (filePath != "")
                {
                    lblFichierSelectionne.Text = "File selected : " + filename;
                }
                else
                {
                    lblFichierSelectionne.Text = "No file selected";
                }
            }
            if (filePath == "")
            {
                MessageBox.Show("You have to select a file", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    pbxImage.Image = Image.FromFile(filePath);
                    RecupererMessage();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error opening the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxMessage.Text = "";
                    lblFichierSelectionne.Text = "No file selected";
                    filePath = "";
                    filename = "";
                    pbxImage.Image = null;
                }
            }
        }

        private void FormTrouver_Load(object sender, EventArgs e)
        {
            pbxImage.Image = null;
        }
    }
}
