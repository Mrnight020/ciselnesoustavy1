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
            DecToBin(textBox1, label1);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            BinToDec(textBox1, label1);
        }

        void BinToDec(TextBox textbox, Label label)
        {
            string kod = textbox.Text;
            bool jebinarni = true;
            for(int a = 0; a < kod.Length; a++)
            {
                if (kod[a] != '0' && kod[a] != '1')
                {
                    jebinarni = false;
                    break;
                }
                   
            }
            try
            {
                int deckod = 0;
                int i = 0;
                if (jebinarni)
                {
                    for (int mocnina = kod.Length - 1; mocnina >= 0; mocnina--, i++)
                    {
                        int nulajedna = kod[i] - '0';

                        checked { deckod += nulajedna * Convert.ToInt32(Math.Pow(2, mocnina)); }
                            
                    }

                    label.Text = deckod.ToString();
                }
                else
                {
                    MessageBox.Show("Zadej platný binarni kod !!");
                }
            }
            catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
        void DecToBin(TextBox textbox,Label label)
        {
            List<int>list = new List<int>();

            if (int.TryParse(textbox.Text, out int cislo))
            {
                if(cislo <= 0)
                {
                    MessageBox.Show("Zadej vetsi cislo !!");
                }
                else
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
            else
            {
                MessageBox.Show("Chyba");
            }
        }
    }
}
