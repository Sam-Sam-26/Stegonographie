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

        public void RecupererMessage()
        {
            string message = "";
            Bitmap image = new Bitmap(filePath);
            string currentChar = "";

            bool stop = false;

            for (int y = 0; y < image.Height && !stop; y++)
            {
                for (int x = 0; x < image.Width && !stop; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // On récupère les LSB de chaque composante (A, R, G, B)
                    currentChar += Convert.ToString(pixel.A, 2).PadLeft(8, '0')[7];
                    currentChar += Convert.ToString(pixel.R, 2).PadLeft(8, '0')[7];
                    currentChar += Convert.ToString(pixel.G, 2).PadLeft(8, '0')[7];
                    currentChar += Convert.ToString(pixel.B, 2).PadLeft(8, '0')[7];

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

            tbxMessage.Text = message + "\r\n------------------------------------------| end of message |-----------------------------------------";
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
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
                    lblFichierSelectionne.Text = "fichier séléctionné : " + filename;
                }
                else
                {
                    lblFichierSelectionne.Text = "Aucun fichier séléctionné";
                }
            }
            if (filePath == "")
            {
                MessageBox.Show("Vous devez séléctioner un fichier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pbxImage.Image = Image.FromFile(filePath);
                RecupererMessage();
            }
        }

        private void FormTrouver_Load(object sender, EventArgs e)
        {
            pbxImage.Image = null;
        }
    }
}
