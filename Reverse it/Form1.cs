using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Reverse_it
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Reverse_Click(object sender, EventArgs e)
        {
            string output = "";
            int vowels = 0;
            int consonants = 0;
            for (int i = 0; i < TBX_Input.Text.Length; i++)
            {
                output = TBX_Input.Text[i] + output;
                if (TBX_Input.Text[i] == 'a' || TBX_Input.Text[i] == 'e' || TBX_Input.Text[i] == 'i' || TBX_Input.Text[i] == 'o' || TBX_Input.Text[i] == 'u')
                {
                    vowels += 1;
                }
                else
                {
                    consonants += 1;
                }
            }
            MessageBox.Show(output);
            MessageBox.Show("It has " + vowels + " vowels and " + consonants + " consonants.");
            if (output == TBX_Input.Text)
            {
                MessageBox.Show("Your input is a palindrome.");
            }
            else
            {
                MessageBox.Show("Your input is not a palindrome.");
            }
        }
    }
}