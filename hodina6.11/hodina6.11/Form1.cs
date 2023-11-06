using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hodina6._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > '0' || e.KeyChar < '9' || e.KeyChar != 8))
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            List<int> binarnikod = new List<int>();
            DecToBin(textBox1, label1,ref binarnikod);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BinToDec(textBox1, label1);
        }

        void BinToDec(TextBox textbox, Label label)
        {
            string kod = textbox.Text;
            int deckod = 0;
            int i = 0;

            for (int mocnina = kod.Length-1; mocnina >= 0; mocnina--, i++)
            {
                int nulajedna = kod[i] - '0';
                //MessageBox.Show(" " + nulajedna);

                deckod += nulajedna * Convert.ToInt32(Math.Pow(2, mocnina));               
            }

            MessageBox.Show("" + deckod);
        }
        void DecToBin(TextBox textbox,Label label, ref List<int> list)
        {

            if (int.TryParse(textbox.Text, out int cislo))
            {
                for (; cislo > 0; cislo /= 2)
                {
                    list.Add(cislo % 2);
                }
                list.Reverse();
                foreach (int i in list)
                {
                    label.Text += i;
                }
            }
        }
    }
}
