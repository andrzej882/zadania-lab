using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double variable;
        char sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void but2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void but3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void but4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void but5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void but6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void but7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void but8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void but9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void butPrzecinek_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(",");
        }

        private void but0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void butC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);
            sign = '+';

            textBox1.Text = "";
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);
            sign = '-';

            textBox1.Text = "";
        }

        private void butIloczyn_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);
            sign = '*';

            textBox1.Text = "";
        }

        private void butIloraz_Click(object sender, EventArgs e)
        {
            variable = double.Parse(textBox1.Text);
            sign = '/';

            textBox1.Text = "";
        }

        private void butRowna_Click(object sender, EventArgs e)
        {
            switch (sign)
            {

                case '+':

                    textBox1.Text = (variable + double.Parse(textBox1.Text)).ToString();

                    break;

                case '-':

                    textBox1.Text = (variable - double.Parse(textBox1.Text)).ToString();

                    break;

                case '/':

                    if (textBox1.TextLength == 1 && textBox1.Text[0].Equals('0'))

                    {

                        textBox1.Text = "Nie dizelimy przez 0";

                    }

                    else

                    {

                        textBox1.Text = ((double)variable / double.Parse(textBox1.Text)).ToString();

                    }

                    break;

                case '*':

                    textBox1.Text = (variable * double.Parse(textBox1.Text)).ToString();

                    break;

            }
        }
    }
}
