using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";        
        }

        private void but9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
           
        }

        private void but00_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "00";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Text = "0";
        }

        private void deci_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {try
            {
                double str = double.Parse(textBox1.Text);
                textBox1.Text = String.Format("{0:#,#}", str);
                         
            }
            catch
            {
            }
            }
    }
}
