using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole05
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
            int[] pole = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(0, 20);
                listBox1.Items.Add(pole[i]);
            }
            Array.Sort(pole);
            int b = int.Parse(textBox2.Text);
            int pb = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                listBox2.Items.Add(pole[i]);
                if (pole[i] <= b)
                {
                    pb = i;
                }
            }
            int[] polemb = pole.Take(pb+1).ToArray();
            for (int i = 0; i < polemb.Length; i++)
            {
                listBox3.Items.Add(polemb[i]);
            }
            int[] polevb = pole.Skip(pb+1).ToArray();
            for (int i = 0; i < polevb.Length; i++)
            {
                listBox4.Items.Add(polevb[i]);
            }

        }
    }
}
