namespace HiddingTextInImage
{
    partial class FormCacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCacher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.tbBinaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImporterImg = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblFichierSelectionne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HiddingTextInImage.Properties.Resources.home1;
            this.pictureBox1.Location = new System.Drawing.Point(725, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(434, 79);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(329, 291);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 1;
            this.pbResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Votre message : ";
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(30, 95);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(350, 96);
            this.tbMsg.TabIndex = 4;
            // 
            // btnGenerer
            // 
            this.btnGenerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerer.Location = new System.Drawing.Point(80, 237);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(242, 38);
            this.btnGenerer.TabIndex = 5;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // tbBinaire
            // 
            this.tbBinaire.Location = new System.Drawing.Point(30, 312);
            this.tbBinaire.Multiline = true;
            this.tbBinaire.Name = "tbBinaire";
            this.tbBinaire.ReadOnly = true;
            this.tbBinaire.Size = new System.Drawing.Size(350, 90);
            this.tbBinaire.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Résultat binaire";
            // 
            // btnImporterImg
            // 
            this.btnImporterImg.Location = new System.Drawing.Point(30, 197);
            this.btnImporterImg.Name = "btnImporterImg";
            this.btnImporterImg.Size = new System.Drawing.Size(118, 23);
            this.btnImporterImg.TabIndex = 8;
            this.btnImporterImg.Text = "importer";
            this.btnImporterImg.UseVisualStyleBackColor = true;
            this.btnImporterImg.Click += new System.EventHandler(this.btnImporterImg_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(664, 376);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(99, 23);
            this.btnDownload.TabIndex = 9;
            this.btnDownload.Text = "télécharger";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblFichierSelectionne
            // 
            this.lblFichierSelectionne.AutoSize = true;
            this.lblFichierSelectionne.Location = new System.Drawing.Point(154, 202);
            this.lblFichierSelectionne.Name = "lblFichierSelectionne";
            this.lblFichierSelectionne.Size = new System.Drawing.Size(126, 13);
            this.lblFichierSelectionne.TabIndex = 10;
            this.lblFichierSelectionne.Text = "Aucun fichier séléctionné";
            // 
            // FormCacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFichierSelectionne);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnImporterImg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBinaire);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCacher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCacher_FormClosed);
            this.Load += new System.EventHandler(this.FormCacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.TextBox tbBinaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImporterImg;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblFichierSelectionne;
    }
}