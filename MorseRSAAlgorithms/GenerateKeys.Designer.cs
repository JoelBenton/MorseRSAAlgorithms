
namespace MorseRSAAlgorithms
{
    partial class GenerateKeys
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.GenKeysButton = new System.Windows.Forms.Button();
            this.PrivateKeyText = new System.Windows.Forms.TextBox();
            this.PublicKeyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(13, 13);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(192, 23);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Close";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // GenKeysButton
            // 
            this.GenKeysButton.Location = new System.Drawing.Point(13, 43);
            this.GenKeysButton.Name = "GenKeysButton";
            this.GenKeysButton.Size = new System.Drawing.Size(192, 23);
            this.GenKeysButton.TabIndex = 1;
            this.GenKeysButton.Text = "Generate Keys";
            this.GenKeysButton.UseVisualStyleBackColor = true;
            this.GenKeysButton.Click += new System.EventHandler(this.GenKeysButton_Click);
            // 
            // PrivateKeyText
            // 
            this.PrivateKeyText.Location = new System.Drawing.Point(15, 134);
            this.PrivateKeyText.Name = "PrivateKeyText";
            this.PrivateKeyText.ReadOnly = true;
            this.PrivateKeyText.Size = new System.Drawing.Size(193, 20);
            this.PrivateKeyText.TabIndex = 2;
            // 
            // PublicKeyText
            // 
            this.PublicKeyText.Location = new System.Drawing.Point(15, 95);
            this.PublicKeyText.Name = "PublicKeyText";
            this.PublicKeyText.ReadOnly = true;
            this.PublicKeyText.Size = new System.Drawing.Size(193, 20);
            this.PublicKeyText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Private";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Public";
            // 
            // GenerateKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PublicKeyText);
            this.Controls.Add(this.PrivateKeyText);
            this.Controls.Add(this.GenKeysButton);
            this.Controls.Add(this.ReturnButton);
            this.Name = "GenerateKeys";
            this.Text = "GenerateKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button GenKeysButton;
        private System.Windows.Forms.TextBox PrivateKeyText;
        private System.Windows.Forms.TextBox PublicKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}