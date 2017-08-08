using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WpfGameMyRPG
{
    public partial class TestRandomForm : Form
    {
        public TestRandomForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            double p1 = 0, p2 = 0, p3 = 0;
            int n1 = 0, n2 = 0, n3 = 0;
            double P1 = 0, P2 = 0, P3 = 0;
            int T = 0;
            int n = 0;
            try
            {
                p1 = Convert.ToDouble(textBox8.Text);
                p2 = Convert.ToDouble(textBox7.Text);
                p3 = Convert.ToDouble(textBox6.Text);
                n = Convert.ToInt32(textBox5.Text);
                T = Convert.ToInt32(textBoxt.Text);
                progressBar1.Maximum = n+5;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Random rand;
            int r = 0;
            textBox11.Clear();
            for (int i = 0; i < n; i++)
            {
                rand = RandomProvider.GetThreadRandom();
                r = rand.Next() % (100 * T);
                if (r >= 0 && r <= (p1 * T - 1))
                {
                    textBox11.Text += (i + 1).ToString() + " С1 ";
                    n1++;
                }
                else if (r >= p1 * T && r <= (p1 * T + p2 * T - 1))
                {
                    textBox11.Text += (i + 1).ToString() + " С2 ";
                    n2++;
                }
                else if (r >= (p1 * T + p2 * T) && r <= (100 * T - 1))
                {
                    textBox11.Text += (i + 1).ToString() + " С3 ";
                    n3++;
                }
                else MessageBox.Show("Error RANDOM");
                textBox11.Text += r.ToString() + "\r\n";
                progressBar1.Increment(+1);
            }
            textBoxn1.Text = n1.ToString();
            textBoxn2.Text = n2.ToString();
            textBoxn3.Text = n3.ToString();
            textBoxp1.Text = (100 * (double)n1 / n).ToString();
            textBoxp2.Text = (100 * (double)n2 / n).ToString();
            textBoxp3.Text = (100 * (double)n3 / n).ToString();
        }
    }
}
