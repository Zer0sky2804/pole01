using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole02
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
                pole[i] = rnd.Next(1,11);
                textBox2.AppendText(pole[i].ToString() + Environment.NewLine);
            } 
            Array.Sort(pole);
            int max = pole[n - 1];
            int min = pole[0];
            int pmin = Array.LastIndexOf(pole,min);
            int min2 = pole[pmin + 1];
            int pmax = Array.IndexOf(pole, max);
            int max2 = pole[pmax - 1];
            if (radioButton2.Checked == true)
            {
                   Array.Reverse(pole);
            }
            for (int i = 0; i < n; i++)
            {
                    listBox1.Items.Add(pole[i]);
            }
            listBox1.Items.Add("2min je " + min2);
            listBox1.Items.Add("2max je " + max2);
        }
    }
}
