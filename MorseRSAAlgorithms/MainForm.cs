using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MorseCodeButton_Click(object sender, EventArgs e)
        {
            // RSA encrpytion Button
            var MC = new MorseCodeForm();
            MC.Show();
            this.Visible = false;
        }

        private void RSAButton_Click(object sender, EventArgs e)
        {
            // RSA encrpytion Button
            var RSA = new RSAForm();
            RSA.Show();
            this.Visible = false;
        }
    }
}
