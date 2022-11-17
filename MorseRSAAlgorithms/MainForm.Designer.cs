
namespace MorseRSAAlgorithms
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MorseCodeButton = new System.Windows.Forms.Button();
            this.RSAButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MorseRSAAlgorithms.Properties.Resources.Home_Screen_Welcome;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MorseCodeButton
            // 
            this.MorseCodeButton.BackgroundImage = global::MorseRSAAlgorithms.Properties.Resources.MorseCodeEncryption;
            this.MorseCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MorseCodeButton.Location = new System.Drawing.Point(12, 235);
            this.MorseCodeButton.Name = "MorseCodeButton";
            this.MorseCodeButton.Size = new System.Drawing.Size(249, 74);
            this.MorseCodeButton.TabIndex = 1;
            this.MorseCodeButton.UseVisualStyleBackColor = true;
            this.MorseCodeButton.Click += new System.EventHandler(this.MorseCodeButton_Click);
            // 
            // RSAButton
            // 
            this.RSAButton.BackgroundImage = global::MorseRSAAlgorithms.Properties.Resources.RSAEncryption;
            this.RSAButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RSAButton.Location = new System.Drawing.Point(377, 235);
            this.RSAButton.Name = "RSAButton";
            this.RSAButton.Size = new System.Drawing.Size(249, 74);
            this.RSAButton.TabIndex = 2;
            this.RSAButton.UseVisualStyleBackColor = true;
            this.RSAButton.Click += new System.EventHandler(this.RSAButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 321);
            this.Controls.Add(this.RSAButton);
            this.Controls.Add(this.MorseCodeButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Morse and RSA Algorithm TestBench";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MorseCodeButton;
        private System.Windows.Forms.Button RSAButton;
    }
}

