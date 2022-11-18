namespace WheelOfFortune
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WheelImage = new System.Windows.Forms.PictureBox();
            this.spinButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WheelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WheelImage
            // 
            this.WheelImage.Image = ((System.Drawing.Image)(resources.GetObject("WheelImage.Image")));
            this.WheelImage.Location = new System.Drawing.Point(178, 81);
            this.WheelImage.Name = "WheelImage";
            this.WheelImage.Size = new System.Drawing.Size(431, 311);
            this.WheelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WheelImage.TabIndex = 0;
            this.WheelImage.TabStop = false;
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(50, 354);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(100, 29);
            this.spinButton.TabIndex = 1;
            this.spinButton.Text = "Spin Wheel";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.WheelImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WheelImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox WheelImage;
        private Button spinButton;
    }
}