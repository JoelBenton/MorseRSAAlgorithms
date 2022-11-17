
namespace MorseRSAAlgorithms
{
    partial class MorseCodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.inputMC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OutputMC = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.TexttoMC = new System.Windows.Forms.Button();
            this.MCtoText = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OpenFileEncrypt = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileDecrypt = new System.Windows.Forms.OpenFileDialog();
            this.EncryptFileOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EncryptFile = new System.Windows.Forms.Button();
            this.DecryptFile = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.FileText = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ClearFileText = new System.Windows.Forms.Button();
            this.SaveFileText = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MORSE CODE ENCRYPTION AND DECRYPTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decryption";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Text";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(15, 102);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(272, 56);
            this.InputText.TabIndex = 4;
            // 
            // inputMC
            // 
            this.inputMC.Location = new System.Drawing.Point(325, 102);
            this.inputMC.Multiline = true;
            this.inputMC.Name = "inputMC";
            this.inputMC.Size = new System.Drawing.Size(272, 56);
            this.inputMC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Morse Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Output";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Output";
            // 
            // OutputMC
            // 
            this.OutputMC.Location = new System.Drawing.Point(15, 239);
            this.OutputMC.Multiline = true;
            this.OutputMC.Name = "OutputMC";
            this.OutputMC.Size = new System.Drawing.Size(272, 67);
            this.OutputMC.TabIndex = 9;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(325, 239);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(272, 67);
            this.OutputText.TabIndex = 10;
            // 
            // TexttoMC
            // 
            this.TexttoMC.Location = new System.Drawing.Point(96, 164);
            this.TexttoMC.Name = "TexttoMC";
            this.TexttoMC.Size = new System.Drawing.Size(75, 23);
            this.TexttoMC.TabIndex = 11;
            this.TexttoMC.Text = "Convert";
            this.TexttoMC.UseVisualStyleBackColor = true;
            this.TexttoMC.Click += new System.EventHandler(this.TexttoMC_Click);
            // 
            // MCtoText
            // 
            this.MCtoText.Location = new System.Drawing.Point(430, 164);
            this.MCtoText.Name = "MCtoText";
            this.MCtoText.Size = new System.Drawing.Size(75, 23);
            this.MCtoText.TabIndex = 12;
            this.MCtoText.Text = "Convert";
            this.MCtoText.UseVisualStyleBackColor = true;
            this.MCtoText.Click += new System.EventHandler(this.MCtoText_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "File Encryption";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "File Decryption";
            // 
            // OpenFileEncrypt
            // 
            this.OpenFileEncrypt.FileName = "openFileDialog1";
            this.OpenFileEncrypt.ReadOnlyChecked = true;
            this.OpenFileEncrypt.ShowReadOnly = true;
            // 
            // OpenFileDecrypt
            // 
            this.OpenFileDecrypt.FileName = "openFileDialog2";
            this.OpenFileDecrypt.ReadOnlyChecked = true;
            this.OpenFileDecrypt.ShowReadOnly = true;
            // 
            // EncryptFileOpen
            // 
            this.EncryptFileOpen.Location = new System.Drawing.Point(273, 359);
            this.EncryptFileOpen.Name = "EncryptFileOpen";
            this.EncryptFileOpen.Size = new System.Drawing.Size(64, 23);
            this.EncryptFileOpen.TabIndex = 15;
            this.EncryptFileOpen.Text = "Select File";
            this.EncryptFileOpen.UseVisualStyleBackColor = true;
            this.EncryptFileOpen.Click += new System.EventHandler(this.EncryptFileOpen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(582, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "File Location";
            // 
            // EncryptFile
            // 
            this.EncryptFile.Location = new System.Drawing.Point(175, 442);
            this.EncryptFile.Name = "EncryptFile";
            this.EncryptFile.Size = new System.Drawing.Size(75, 23);
            this.EncryptFile.TabIndex = 21;
            this.EncryptFile.Text = "Encrypt File";
            this.EncryptFile.UseVisualStyleBackColor = true;
            this.EncryptFile.Click += new System.EventHandler(this.EncryptFile_Click);
            // 
            // DecryptFile
            // 
            this.DecryptFile.Location = new System.Drawing.Point(372, 440);
            this.DecryptFile.Name = "DecryptFile";
            this.DecryptFile.Size = new System.Drawing.Size(75, 23);
            this.DecryptFile.TabIndex = 22;
            this.DecryptFile.Text = "Decrypt File";
            this.DecryptFile.UseVisualStyleBackColor = true;
            this.DecryptFile.Click += new System.EventHandler(this.DecryptFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(739, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "File Text";
            // 
            // FileText
            // 
            this.FileText.Location = new System.Drawing.Point(636, 64);
            this.FileText.Multiline = true;
            this.FileText.Name = "FileText";
            this.FileText.ReadOnly = true;
            this.FileText.Size = new System.Drawing.Size(292, 357);
            this.FileText.TabIndex = 24;
            // 
            // ClearFileText
            // 
            this.ClearFileText.Location = new System.Drawing.Point(636, 441);
            this.ClearFileText.Name = "ClearFileText";
            this.ClearFileText.Size = new System.Drawing.Size(152, 23);
            this.ClearFileText.TabIndex = 25;
            this.ClearFileText.Text = "Clear";
            this.ClearFileText.UseVisualStyleBackColor = true;
            this.ClearFileText.Click += new System.EventHandler(this.ClearFileText_Click);
            // 
            // SaveFileText
            // 
            this.SaveFileText.Location = new System.Drawing.Point(794, 441);
            this.SaveFileText.Name = "SaveFileText";
            this.SaveFileText.Size = new System.Drawing.Size(134, 23);
            this.SaveFileText.TabIndex = 26;
            this.SaveFileText.Text = "Save";
            this.SaveFileText.UseVisualStyleBackColor = true;
            this.SaveFileText.Click += new System.EventHandler(this.SaveFileText_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(12, 12);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 36);
            this.Return.TabIndex = 27;
            this.Return.Text = "Return To Menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // MorseCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 514);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.SaveFileText);
            this.Controls.Add(this.ClearFileText);
            this.Controls.Add(this.FileText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DecryptFile);
            this.Controls.Add(this.EncryptFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EncryptFileOpen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MCtoText);
            this.Controls.Add(this.TexttoMC);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.OutputMC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputMC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MorseCodeForm";
            this.Text = "MorseCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox inputMC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OutputMC;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button TexttoMC;
        private System.Windows.Forms.Button MCtoText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog OpenFileEncrypt;
        private System.Windows.Forms.OpenFileDialog OpenFileDecrypt;
        private System.Windows.Forms.Button EncryptFileOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EncryptFile;
        private System.Windows.Forms.Button DecryptFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FileText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ClearFileText;
        private System.Windows.Forms.Button SaveFileText;
        private System.Windows.Forms.Button Return;
    }
}