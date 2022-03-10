using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole04
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
                pole[i] = rnd.Next(0, 21);
                listBox1.Items.Add(pole[i]);
            }
            int max = pole.Max();
            pole = pole.Distinct().ToArray();
            for (int i = 0; i<pole.Length; i++)
            {
                if (pole[i] != max)
                {
                    listBox2.Items.Add(pole[i]);
                }

            }
        }
    }
}
