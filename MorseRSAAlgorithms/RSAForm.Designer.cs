
namespace MorseRSAAlgorithms
{
    partial class RSAForm
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
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.DecryptedTextBox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PublicKeyText = new System.Windows.Forms.TextBox();
            this.PrivateKeyText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CopyKeys = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "RSA Encryption And Decryption";
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(9, 12);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(62, 36);
            this.Return.TabIndex = 39;
            this.Return.Text = "Return To Menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Plain Text";
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(9, 111);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(397, 92);
            this.PlainText.TabIndex = 41;
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Location = new System.Drawing.Point(9, 234);
            this.EncryptedTextBox.Multiline = true;
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(397, 92);
            this.EncryptedTextBox.TabIndex = 42;
            // 
            // DecryptedTextBox
            // 
            this.DecryptedTextBox.Location = new System.Drawing.Point(9, 349);
            this.DecryptedTextBox.Multiline = true;
            this.DecryptedTextBox.Name = "DecryptedTextBox";
            this.DecryptedTextBox.Size = new System.Drawing.Size(397, 92);
            this.DecryptedTextBox.TabIndex = 43;
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(412, 111);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(128, 92);
            this.Encrypt.TabIndex = 44;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(412, 234);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(128, 92);
            this.Decrypt.TabIndex = 45;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Encrypted Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Decrypted Text";
            // 
            // PublicKeyText
            // 
            this.PublicKeyText.Location = new System.Drawing.Point(414, 21);
            this.PublicKeyText.Name = "PublicKeyText";
            this.PublicKeyText.Size = new System.Drawing.Size(126, 20);
            this.PublicKeyText.TabIndex = 48;
            // 
            // PrivateKeyText
            // 
            this.PrivateKeyText.Location = new System.Drawing.Point(414, 63);
            this.PrivateKeyText.Name = "PrivateKeyText";
            this.PrivateKeyText.Size = new System.Drawing.Size(126, 20);
            this.PrivateKeyText.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Private Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Public Key";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "Gen Keys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(414, 349);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(128, 92);
            this.ResetButton.TabIndex = 52;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CopyKeys
            // 
            this.CopyKeys.Location = new System.Drawing.Point(9, 54);
            this.CopyKeys.Name = "CopyKeys";
            this.CopyKeys.Size = new System.Drawing.Size(126, 29);
            this.CopyKeys.TabIndex = 53;
            this.CopyKeys.Text = "Copy Keys From Gen";
            this.CopyKeys.UseVisualStyleBackColor = true;
            this.CopyKeys.Click += new System.EventHandler(this.CopyKeys_Click);
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 453);
            this.Controls.Add(this.CopyKeys);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrivateKeyText);
            this.Controls.Add(this.PublicKeyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.DecryptedTextBox);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.label1);
            this.Name = "RSAForm";
            this.Text = "RSAForm";
            this.Load += new System.EventHandler(this.RSAForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.TextBox DecryptedTextBox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PublicKeyText;
        private System.Windows.Forms.TextBox PrivateKeyText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button CopyKeys;
    }
}