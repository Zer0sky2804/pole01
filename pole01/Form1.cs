using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text);
            double[] pole = new double[n];
            double max = -1;
            double min = 1001;
            int pmin = 0;
            int pmax = 0;
            double ap = 0;
            Random rnd = new Random();
            
            for(int i = 0; i < n; i++)
            {
                pole[i]=rnd.NextDouble() * (1000-1) +1;
                if (pole[i] < min)
                {
                    min = pole[i];
                    pmin = i;
                }
                if (pole[i] > max)
                {
                    max = pole[i];
                    pmax = i;
                }
                textBox3.AppendText(pole[i].ToString("F2") + Environment.NewLine);
                ap += pole[i];
            }
            pole[pmin] = max;
            pole[pmax] = min;
            for(int i = 0; i < n; i++)
            {
                textBox1.AppendText(pole[i].ToString("F2")+Environment.NewLine)  ;   
            }
            ap = ap - (min + max);
            ap = ap / (n - 2);
            label4.Text = "aritmeticky prumer je " + ap.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox2.Text);
            double[] pole = new double[n];
            double ap = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (1000 - 1) + 1;

                textBox3.AppendText(pole[i].ToString("F2") + Environment.NewLine);
                ap += pole[i];
            }
            double max = pole.Max();
            double min = pole.Min();
            int pmin = Array.IndexOf(pole, min);
            int pmax = Array.IndexOf(pole, max);
            pole[pmin] = max;
            pole[pmax] = min;
            for (int i = 0; i < n; i++)
            {
                textBox1.AppendText(pole[i].ToString("F2") + Environment.NewLine);
            }
            ap = ap - (min + max);
            ap = ap / (n - 2);
            label4.Text = "aritmeticky prumer je " + ap.ToString("F2");
        }
    }
}
