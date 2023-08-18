using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktöriyel_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long x = Convert.ToInt64(textBox1.Text);
            long deger = 1, fak = 1;
            long a = x , b= x;  

            for (long i = 1; i <= b; i++)
            {
                if (a == 1)
                {
                    break;
                }
                deger = x * (--a);
                x = deger;
                fak = x;

                
                
            }
            
            listBox1.Items.Add(fak);
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
