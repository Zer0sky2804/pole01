using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            double[] pole = new double[n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (1000 + 1000) - 1000;
                listBox1.Items.Add(pole[i].ToString("F2"));
            }
            double ap = pole.Average();
            double max = -2000;
            foreach(double a  in pole)
            {
                if (a > max && a <= ap)
                {
                    max = a;
                }
            }
            listBox1.Items.Add("Prumer prvku v poly je " + ap.ToString("F2"));
            listBox1.Items.Add("Maximum prvku mensi nez prumer je" + max.ToString("F2"));
        }
    }
}
