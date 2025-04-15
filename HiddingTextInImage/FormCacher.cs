using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddingTextInImage
{
    public partial class FormCacher : Form
    {
        public static string filePath = "";
        public static string binaryMessage = "";
        public static int messageIndex = 0;
        public static string filename = "";
        public static Bitmap imageFinale = null;
        public static int stopCounter = 0;
        public FormCacher()
        {
            InitializeComponent();
            filePath = "";
            binaryMessage = "";
            filename = "";
            messageIndex = 0;
        }

        public static void CacherTexte()
        {

            int maxCapacity = imageFinale.Width * imageFinale.Height * 4; // 4 bits par pixel (A, R, G, B)

            if (binaryMessage.Length > maxCapacity)
            {
                MessageBox.Show("The message is too long !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            messageIndex = 0;
            stopCounter = 0;

            for (int y = 0; y < imageFinale.Height; y++)
            {
                for (int x = 0; x < imageFinale.Width; x++)
                {
                    Color pixel = imageFinale.GetPixel(x, y);

                    // On convertit chaque composante en binaire, puis on remplace le dernier bit
                    string[] binaryColors = new string[4];
                    binaryColors[0] = Convert.ToString(pixel.A, 2).PadLeft(8, '0');
                    binaryColors[1] = Convert.ToString(pixel.R, 2).PadLeft(8, '0');
                    binaryColors[2] = Convert.ToString(pixel.G, 2).PadLeft(8, '0');
                    binaryColors[3] = Convert.ToString(pixel.B, 2).PadLeft(8, '0');

                    for (int i = 0; i < 4; i++) // A, R, G, B
                    {
                        if (messageIndex < binaryMessage.Length)
                        {
                            // Remplace le dernier bit
                            var colorBits = binaryColors[i].ToCharArray();
                            colorBits[7] = binaryMessage[messageIndex];
                            binaryColors[i] = new string(colorBits);
                            messageIndex++;
                        }
                        else if (stopCounter < 8) // Remplissage de fin pour détecter la fin du message
                        {
                            var colorBits = binaryColors[i].ToCharArray();
                            colorBits[7] = '0';
                            binaryColors[i] = new string(colorBits);
                            stopCounter++;
                        }
                    }

                    // Reconstruire le pixel
                    int newA = Convert.ToInt32(binaryColors[0], 2);
                    int newR = Convert.ToInt32(binaryColors[1], 2);
                    int newG = Convert.ToInt32(binaryColors[2], 2);
                    int newB = Convert.ToInt32(binaryColors[3], 2);

                    imageFinale.SetPixel(x, y, Color.FromArgb(newA, newR, newG, newB));

                    if (messageIndex >= binaryMessage.Length && stopCounter >= 8)
                        return; // On arrête une fois que le message + le stop ont été insérés
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            if(tbMsg.Text == "")
            {
                MessageBox.Show("You have to type a message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(filePath == "")
            {
                MessageBox.Show("You have to select a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                try
                {
                    imageFinale = new Bitmap(filePath);
                    binaryMessage = StringToBinary(tbMsg.Text);
                    tbBinaire.Text = binaryMessage;
                    // appel de la fonction pour cacher le texte dans l'image
                    CacherTexte();
                    //pbResult.Image = Image.FromFile(filePath);
                    pbResult.Image = new Bitmap(imageFinale);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error opening the image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMsg.Text = "";
                    lblFichierSelectionne.Text = "";
                    filePath = "";
                    filename = "";
                    return;
                }
            }
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in data.ToCharArray())
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            return sb.ToString();
        }

        private void btnImporterImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "Documents";
                openFileDialog.Filter = "png files (*.png)|*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Title = "Select your image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    string[] s = filePath.Split('\\');
                    filename = s[s.Length - 1];
                    string[] t = filename.Split('.');
                    filename = t[t.Length - 2];
                }
                if (filePath != "")
                {
                    lblFichierSelectionne.Text = "file selected : " + filename + ".png";
                }
                else
                {
                    lblFichierSelectionne.Text = "No file selected";
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(pbResult.Image == null)
            {
                MessageBox.Show("Aucune image à exporter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = "Downloads";
                    saveFileDialog.Filter = "Fichiers PNG (*.png)|*.png";
                    saveFileDialog.Title = "Enregistrer l'image";
                    saveFileDialog.FileName = $"{filename}_hidden.png";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        imageFinale.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Image téléchargée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to export", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void FormCacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(4);
        }

        private void FormCacher_Load(object sender, EventArgs e)
        {

        }
    }
}
