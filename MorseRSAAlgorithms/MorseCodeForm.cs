using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    public partial class MorseCodeForm : Form
    {
        void OpenAndReadFile()
        {
            OpenFileDialog OpenFileEncryption = new OpenFileDialog // Sets up The OpenFileEncryption file dialog.
            {
                InitialDirectory = @"C:\University work\Application development in C#\Assessment", // Sets the starting location of the file explorer that will open on button press
                Title = "Browse Text Files", // Sets the title of the file explorer to the text
            };

            Stream stream = null; // Stream a concept that can have infinite length. Cant tell when its going to stop. takes and Read chunks of data at a time and process them instead of all of it at the same time.
            DialogResult result = OpenFileEncryption.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox1.Text = OpenFileEncryption.FileName; // Sets the file location that the user selected to the TextBox

                if ((stream = OpenFileEncryption.OpenFile()) != null)
                {
                    using (StreamReader sr = new StreamReader(stream)) // 
                    {
                        FileText.Text = sr.ReadToEnd(); // Using a stream reader it will take all the data from the variable stream. This will take places in parts depending on the size.
                    }
                }
            }
        }

        static Dictionary<string, string> createDictionary()
        {
            // Created a dictionary that contains 2 strings. Dictionary is being used to hold the conversion table for characters to morse.
             Dictionary<string, string> morse = new Dictionary<string, string>()
            {
                {"A" , ".-"},
                {"B", "-..."},
                {"C" , "-.-."},
                {"D" , "-.."},
                {"E" , "."},
                {"F" , "..-."},
                {"G" , "--."},
                {"H" , "...."},
                {"I" , ".."},
                {"J" , ".---"},
                {"K" , "-.-"},
                {"L" , ".-.."},
                {"M" , "--"},
                {"N" , "-."},
                {"O" , "---"},
                {"P" , ".--."},
                {"Q" , "--.-"},
                {"R" , ".-."},
                {"S" , "..."},
                {"T" , "-"},
                {"U" , "..-"},
                {"V" , "...-"},
                {"W" , ".--"},
                {"X" , "-..-"},
                {"Y" , "-.--"},
                {"Z" , "--.."},
                {"0" , "-----"},
                {"1" , ".----"},
                {"2" , "..---"},
                {"3" , "...--"},
                {"4" , "....-"},
                {"5" , "....."},
                {"6" , "-...."},
                {"7" , "--..."},
                {"8" , "---.."},
                {"9" , "----."},
                {".", ".-.-.-"},
                {",", "--..--" },
                {":", "---..." },
                {"=", "-...-" },
                {"-", "-....-" },
                {"(", "-.--." },
                {")", "-.--.-" },
                {"/n", "/n" },
                
            };

            return morse;
        }

        public MorseCodeForm()
        {
            InitializeComponent();


        }
        // Code For converting text to morse code.
        private void TexttoMC_Click(object sender, EventArgs e)
        {
            if (InputText.Text == "")
            {
                MessageBox.Show("Empty Box! Please Enter Text!");
                return;
            }
            // Gets the dictionary created at the top of the code and sets it up for use in this method.
            Dictionary<string, string> morse = createDictionary();
            string textToMorse = InputText.Text; // Sets the string value to the inputted value from a selected text box.
            morse.Add(" ", "");
            string morseOutput = "";

            foreach (char c in textToMorse) // loops for each charcter in the string textToMorse.
            {
                morseOutput += morse[c.ToString().ToUpper()] + " "; // Using the current character in the loop it will find it in the dictionary and add the morse code equivilant to the string morseOutput
            }

            OutputMC.Text = morseOutput; // Sets the text of a textbox to the string morseOutput which contains the morse code which we just converted to.
        }
        // Code for Converting more to text.
        private void MCtoText_Click(object sender, EventArgs e)
        {
            if (inputMC.Text == "")
            {
                MessageBox.Show("Empty Box! Please Enter Text!");
                return;
            }
            Dictionary<string, string> morse = createDictionary(); // Gets the dictionary created at the top.
            string morseToText = inputMC.Text;
            var morse2 = morse.ToDictionary((kv) => kv.Value, (kv) => kv.Key); // Inverts Dictionary so that we can compare the morse code part instead of the characters part.
            char[] seperator = { ' ' }; // setting the char for how the split below will tell where to split the string up.
            string[] morseList = morseToText.Split(seperator); // splits the string into a string[] list that will contain all the different morse code sections
            string morseOutput = "";
            morse2.Add("", " ");

            foreach (string Morse in morseList)
            {
                morseOutput += morse2[Morse]; // Finds the character equivilant for each more code section and adds it to a pre made string
            }

            OutputText.Text = morseOutput.ToLower(); // Sets the string to lowercase and sets the textbox text to the string.


        }

        private void EncryptFileOpen_Click(object sender, EventArgs e)
        {
            label12.Text = ("Encrypted Text From File");
            OpenAndReadFile();
        }

        private void DecryptFileOpen_Click(object sender, EventArgs e)
        {
            label12.Text = ("Decrypted Text From File");
            OpenAndReadFile();
        }

        private void ClearFileText_Click(object sender, EventArgs e)
        {
            FileText.Text = "";
            textBox1.Text = "";
        }

        private void EncryptFile_Click(object sender, EventArgs e)
        {
            string TextFileToMorse = FileText.Text;
            // Gets the dictionary created at the top of the code and sets it up for use in this method.
            Dictionary<string, string> morse = createDictionary();
            morse.Add(" ", "");
            string morseOutput = "";

            foreach (char c in TextFileToMorse) // loops for each charcter in the string textToMorse.
            {
                try { morseOutput += morse[c.ToString().ToUpper()] + " "; } // Using the current character in the loop it will find it in the dictionary and add the morse code equivilant to the string morseOutput
                catch { morseOutput += c;  };
            }
            FileText.Text = "";
            FileText.Text = morseOutput; // Sets the text of a textbox to the string morseOutput which contains the morse code which we just converted to.
        }

        private void DecryptFile_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> morse = createDictionary(); // Gets the dictionary created at the top.
            string morseToText = FileText.Text;
            var morse2 = morse.ToDictionary((kv) => kv.Value, (kv) => kv.Key); // Inverts Dictionary so that we can compare the morse code part instead of the characters part.
            char[] seperator = { ' ' }; // setting the char for how the split below will tell where to split the string up.
            string[] morseList = morseToText.Split(seperator); // splits the string into a string[] list that will contain all the different morse code sections
            string morseOutput = "";
            morse2.Add("/", " ");
            morse.Add("", " ");

            foreach (string Morse in morseList)
            {
                try { morseOutput += morse2[Morse]; } // Finds the character equivilant for each more code section and adds it to a pre made string
                catch { morseOutput += Morse + " "; }
            }

            FileText.Text = morseOutput.ToLower(); // Sets the string to lowercase and sets the textbox text to the string.
        }

        private void SaveFileText_Click(object sender, EventArgs e)
        {
            // Used to Open up a file directory to allow the user to save the encrypted or decrypted text from the files to a new text file.
            SaveFileDialog SaveText = new SaveFileDialog();
            SaveText.Title = "Save";
            SaveText.Filter = "Text Files (*.txt) | *.txt"; // Sets it so that the file will be saved as a .txt file as default.

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, FileText.Text); // Used to move all the text from the textbox to the file.
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            var HomeScreen = new MainForm(); // Creates A variable That links to the MainForm.
            HomeScreen.Show(); // Makes it so the MainForm is Visible.
            this.Visible = false; // Hides The Current Form
        }
    }
}