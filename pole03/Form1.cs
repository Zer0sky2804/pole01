using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole03
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
            int[] polea = new int[n];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                polea[i] = rnd.Next(2, 11);
                listBox1.Items.Add(polea[i]);
            }
            int m = int.Parse(textBox2.Text);
            int[] poleb = new int[m];
            
            for (int i = 0; i < m; i++)
            {
                poleb[i] = rnd.Next(2, 11);
                listBox2.Items.Add(poleb[i]);
            }
            int[] polec=polea.Concat(poleb).ToArray();
            for (int i=0;i<polec.Length;i++)
            {
                listBox3.Items.Add(polec[i]);
            }
            int[] poled = polea.Intersect(poleb).ToArray();
            for(int i = 0; i <poled.Length; i++)
            {
                listBox4.Items.Add(poled[i]);
            }
            int[] polee = polea.Union(poleb).ToArray();
            for(int i = 0; i < poled.Length; i++)
            {
                listBox5.Items.Add(polee[i]);
            }
            
        }
    }
}
