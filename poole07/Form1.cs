using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poole07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pole = new int[listBox1.Items.Count];
            int i = 0;
            
            foreach(string a in listBox1.Items)
            {
                 
                int b = int.Parse(a);
                if (b == 0)
                {
                    break;
                }
                else
                {
                    pole[i] = b;
                    listBox2.Items.Add(a);
                }
                i++;
            }
            double first = pole.First();
            int last = pole.Last();
            double podil=first/last;
            listBox3.Items.Add("Prvky mesni nez "+last+" jsou ");
            for(int p=0;p<pole.Length;p++){
                if (pole[p] < last)
                {
                    listBox3.Items.Add(pole[p] + " na pozici " + p);
                }
            }
        }
    }
}
