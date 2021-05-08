using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematyka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butSuma_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textX.Text);
                float y = float.Parse(textY.Text);
                float z = float.Parse(textZ.Text);
                textWynik.Text = (x + y + z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błedne dane", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void butIloczyn_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(textX.Text);
                float y = float.Parse(textY.Text);
                float z = float.Parse(textZ.Text);
                textWynik.Text = (x - y - z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błedne dane", "Uwaga", MessageBoxButtons.OK);
            }
        }

        private void textX_TextChanged(object sender, EventArgs e)
        {

        }

        private void butWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
