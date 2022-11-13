namespace BaltikaApp
{
    partial class OpenImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenImageForm));
            this.VesselPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VesselPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VesselPictureBox
            // 
            this.VesselPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VesselPictureBox.Location = new System.Drawing.Point(0, 0);
            this.VesselPictureBox.Name = "VesselPictureBox";
            this.VesselPictureBox.Size = new System.Drawing.Size(800, 450);
            this.VesselPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VesselPictureBox.TabIndex = 0;
            this.VesselPictureBox.TabStop = false;
            // 
            // OpenImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VesselPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenImageForm";
            this.Text = "Изображение";
            ((System.ComponentModel.ISupportInitialize)(this.VesselPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox VesselPictureBox;
    }
}