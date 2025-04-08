namespace HiddingTextInImage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCacher = new System.Windows.Forms.Button();
            this.btnTrouver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCacher
            // 
            this.btnCacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCacher.Location = new System.Drawing.Point(196, 238);
            this.btnCacher.Name = "btnCacher";
            this.btnCacher.Size = new System.Drawing.Size(251, 85);
            this.btnCacher.TabIndex = 0;
            this.btnCacher.Text = "ENCRYPT";
            this.btnCacher.UseVisualStyleBackColor = true;
            this.btnCacher.Click += new System.EventHandler(this.btnCacher_Click);
            // 
            // btnTrouver
            // 
            this.btnTrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrouver.Location = new System.Drawing.Point(498, 238);
            this.btnTrouver.Name = "btnTrouver";
            this.btnTrouver.Size = new System.Drawing.Size(251, 85);
            this.btnTrouver.TabIndex = 1;
            this.btnTrouver.Text = "DECRYPT";
            this.btnTrouver.UseVisualStyleBackColor = true;
            this.btnTrouver.Click += new System.EventHandler(this.btnTrouver_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(390, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "copyrights: Samuel Schmidt © 2025\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(960, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrouver);
            this.Controls.Add(this.btnCacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCacher;
        private System.Windows.Forms.Button btnTrouver;
        private System.Windows.Forms.Label label1;
    }
}

