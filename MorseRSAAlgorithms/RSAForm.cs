using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace MorseRSAAlgorithms
{
    public partial class RSAForm : Form
    {
        public RSAForm()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            var HomeScreen = new MainForm(); // Contects Variable to Mainform
            HomeScreen.Show(); // Makes the Main Form Visibile.
            this.Visible = false; // Makes the Current Form disappear.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var GenKeysScreen = new GenerateKeys(); // Contects Variable to Mainform
            GenKeysScreen.Show(); // Makes the Main Form Visibile.
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (PlainText.Text == "")
            {
                MessageBox.Show("Empty Box! Please Enter Text!");
                return;
            }
            string publicKey = PublicKeyText.Text; // Gets the Text from within the required Textbox.
            string[] KeySections = publicKey.Split(','); // Will split the Text using the character ',' for reference on where to split it. it will save the strings that were split into an array
            BigInteger N = int.Parse(KeySections[0]); // Will Take the first variable in string array and set it to N.
            int E = int.Parse(KeySections[1]); 

            // Will get text from textbox and split it using ' ' for reference. The split text will be saved in a string array.
            // The number of split sections will be counted up and saved in a variable to show amount of words.
            string text = PlainText.Text;
            string[] SplitWordText = text.Split(' ');
            int AmountofWords = SplitWordText.Length;

            // Creates a empty string list.
            List<string> EncryptedIntAscii = new List<string>();

            // A foor loop that will continue for the amount of words that was obtained earlier in the code.
            for (int x = 0; x < AmountofWords; x++)
            {
                // Used to Set a string to each word depending on the number of loops represented by x. For example. if x is 0, it will take the first word in the string array.
                string CurrentWord = SplitWordText[x];
                // Splits the currentword into characters.
                foreach(char c in CurrentWord)
                {
                    // Uses the Public key to encrypt the Character. then saves the encrypted character into the string array Called EncryptedIntAscii.
                    BigInteger ascii = (int)c;
                    BigInteger temp = BigInteger.Pow(ascii, E);
                    BigInteger X = temp % N;
                    char ConvertedAscii = (char)X;
                    EncryptedIntAscii.Add(ConvertedAscii.ToString());
                }
                EncryptedIntAscii.Add("/");
            }
            
            // Loops the string array and prints out the contents of it.
            foreach (string AsciiCharacter in EncryptedIntAscii)
            {
                EncryptedTextBox.Text += AsciiCharacter;
            } 

        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (EncryptedTextBox.Text == "")
            {
                MessageBox.Show("Empty Box! Please Enter Text!");
                return;
            }
            // Finds the Private Key and splits it using ',' for reference.
            string privateKey = PrivateKeyText.Text;
            string[] KeySections = privateKey.Split(',');
            BigInteger N = int.Parse(KeySections[0]);
            int D = int.Parse(KeySections[1]);

            // Finds the Encrypted Text and will split it using /. It will also count the amount of words that need to be decrypted.
            string EncryptedText = EncryptedTextBox.Text;
            string[] SplitWordText = EncryptedText.Split('/');
            int AmountofWords = SplitWordText.Length;

            // creates an empty string list
            List<string> DecryptedString = new List<string>();

            for (int x = 0; x < AmountofWords; x++)
            {
                // Used to Set a string to each word depending on the number of loops represented by x. For example. if x is 0, it will take the first word in the string array.
                string CurrentWord = SplitWordText[x];
                // Splits the currentword into characters.
                foreach(char c in CurrentWord)
                {
                    BigInteger ascii = (int)c;
                    BigInteger temp = BigInteger.Pow(ascii, D);
                    BigInteger X = temp % N;
                    char ConvertedAscii = (char)X;
                    DecryptedString.Add(ConvertedAscii.ToString());
                }
                DecryptedString.Add(" ");
            }

            // Loops the string array and prints out the contents of it.
            foreach (string TextCharacter in DecryptedString)
            {
                DecryptedTextBox.Text += TextCharacter;
            } 

        }

        // Resets all the Text boxs back to empty
        private void ResetButton_Click(object sender, EventArgs e)
        {
            DecryptedTextBox.Text = "";
            EncryptedTextBox.Text = "";
            PlainText.Text = "";
        }

        private void RSAForm_Load(object sender, EventArgs e)
        {

        }

        private void CopyKeys_Click(object sender, EventArgs e)
        {
            PublicKeyText.Text = GenerateKeys.PublicKeyValue; // Gets the public static string from the Generate Keys and will set the key input textboxs to them.
            PrivateKeyText.Text = GenerateKeys.PrivateKeyValue;
        }
    }
}
