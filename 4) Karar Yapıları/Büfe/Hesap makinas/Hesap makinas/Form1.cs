using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1,sayi2,deger;
             sayi1 = Convert.ToDouble(textBox1.Text);
             sayi2 = Convert.ToDouble(textBox3.Text);
           
            string islem = textBox2.Text;

            switch (islem) {

                case "+":
                    deger = (sayi1 + sayi2);
                    label2.Text = deger.ToString();
                    break;
                
                case "-":
                    deger = (sayi1 - sayi2);
                    label2.Text = deger.ToString();
                    break;
                
                case "/":
                    deger = (sayi1 / sayi2);
                    label2.Text = deger.ToString();
                    break;
                
                case "*":
                    deger = (sayi1 * sayi2);
                    label2.Text = deger.ToString();
                    break;
            }
        }
    }
}
