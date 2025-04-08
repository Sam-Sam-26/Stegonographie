namespace HiddingTextInImage
{
    partial class Loader
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
            this.pgbLoader = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgbLoader
            // 
            this.pgbLoader.Location = new System.Drawing.Point(26, 42);
            this.pgbLoader.Maximum = 1000;
            this.pgbLoader.Name = "pgbLoader";
            this.pgbLoader.Size = new System.Drawing.Size(379, 41);
            this.pgbLoader.Step = 1;
            this.pgbLoader.TabIndex = 2;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 117);
            this.Controls.Add(this.pgbLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Loader";
            this.Text = "Working...";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgbLoader;
    }
}