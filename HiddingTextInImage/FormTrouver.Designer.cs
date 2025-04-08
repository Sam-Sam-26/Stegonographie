namespace HiddingTextInImage
{
    partial class FormTrouver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrouver));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFichierSelectionne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HiddingTextInImage.Properties.Resources.home1;
            this.pictureBox1.Location = new System.Drawing.Point(725, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(12, 12);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(395, 344);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 2;
            this.pbxImage.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(157, 392);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(496, 37);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Importer une image";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(447, 91);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.Size = new System.Drawing.Size(341, 265);
            this.tbxMessage.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message caché :";
            // 
            // lblFichierSelectionne
            // 
            this.lblFichierSelectionne.AutoSize = true;
            this.lblFichierSelectionne.Location = new System.Drawing.Point(12, 359);
            this.lblFichierSelectionne.Name = "lblFichierSelectionne";
            this.lblFichierSelectionne.Size = new System.Drawing.Size(126, 13);
            this.lblFichierSelectionne.TabIndex = 6;
            this.lblFichierSelectionne.Text = "Aucun fichier séléctionné";
            // 
            // FormTrouver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFichierSelectionne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTrouver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrouver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTrouver_FormClosed);
            this.Load += new System.EventHandler(this.FormTrouver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFichierSelectionne;
    }
}