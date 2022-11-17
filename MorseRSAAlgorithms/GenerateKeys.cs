using System;
using System.Collections;
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
    public partial class GenerateKeys : Form
    {

        int[] generatePrimes(int toGenerate)
        {
            int[] PrimeList = new int[] {2,3,5,7,11,13,17,19,23,29,31,37,41,47,53,59,61,67,71,73,79,83,89,43,97}; // Creates an Integer array with the set length of 25.
            return PrimeList;
        }
            

        public GenerateKeys()
        {
            InitializeComponent();

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Makes the Current Form disappear.
        }

        // <Code> Found on https://www.geeksforgeeks.org/check-two-numbers-co-prime-not/.
        // GCD stands for Greatest Common Divisor
        static int GCD(int a, int b)
        {
            if (a == 0 || b == 0) { return 0; } // Checks if either a or b is 0. If either are it will return 0 meaning that they cant be Co-Primes.
            if (a == b) { return a; } // Checks if they are equal to each other and if they are will return the value of A.
            if (a > b) { return GCD(a - b, b); } // Checks if a > b and if a is bigger than b it will will minus b from a and return the new a value and the b value.
            return GCD(a, b - a); // if none of the checks above pass it will take a from b and return a value and the new b value.
        }
        // </Code>
        static bool coPrimes(int a, int b)
        {
            if (GCD(a, b) == 1) { return true; } // Checks if the return from GCD is 1 and if it is, that means that the two numbers are co-primes. If they are Co-Primes it will return True
            return false; // will return false.
        }
        static List<int> Totatives(int n)
        {
            List<int> totatives = new List<int>();
            for (int i = 0; i < n; i++) { if (GCD(n, i) == 1) { totatives.Add(i); } }

            return totatives;
        }
        static int LengthTotatives(int n) // Method used to get the Length of the Totatives list made in the method above.
        {
            List<int> totatives = Totatives(n);
            return totatives.Count();
        }

        // Creates Public Variables that can accessed through a different form
        public static string PrivateKeyValue = "";
        public static string PublicKeyValue = "";

        void GeneratePublicAndPrivateKeys()
        {
            int P = 0;
            int Q = 0;

            Random rnt = new Random(); // Creates a Random function.
            int[] PrimeNumbers = generatePrimes(25);

            bool loop = false;

            while (loop == false)
            {
                P = PrimeNumbers[rnt.Next(0, 24)]; // Selects one prime number at random from int array for both Variable P and Q
                Q = PrimeNumbers[rnt.Next(0, 24)];

                if (P != Q) { break; } // Checks to make sure that the two variables contain the same prime number.
            }

            int N = P * Q;
            int Top = (P - 1) * (Q - 1);
            int count = 2;
            List<int> CoPrimes = new List<int>();
            while (count > 1 && count < Top)
            {
                if (coPrimes(Top, count) == true) { CoPrimes.Add(count); count++; } // Checks if the return from coPrimes is True and if it is, it will add count to the list. 
                else { count++;  }
            }

            int e = CoPrimes[0];
            int length = LengthTotatives(N);

            int d = 0;
            List<int> Dvalue = new List<int>();

            while (Dvalue.Count != 5)
            {
                int temp = (d * e) % length;

                if (temp == 1) { Dvalue.Add(d); }
                d++;
            }

            foreach (int value in Dvalue)
            {
                PrivateKeyText.Text += value + " ";
            }

            int FinalD = Dvalue[0];

            PrivateKeyText.Text = (N + "," + FinalD);
            PublicKeyText.Text = (N + "," + e);
            PublicKeyValue = PublicKeyText.Text;
            PrivateKeyValue = PrivateKeyText.Text;
        }
        

        private void GenKeysButton_Click(object sender, EventArgs e)
        {
            GeneratePublicAndPrivateKeys();

        }
    }
}