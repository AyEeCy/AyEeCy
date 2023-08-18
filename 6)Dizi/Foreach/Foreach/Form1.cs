using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sayilar = {32,56,87,54,23,67,78};
            foreach(int sa in sayilar) {

                listBox1.Items.Add(sa);
                toplam = toplam + sa;
                label1.Text = toplam.ToString();

             double  ortalama = toplam/ sayilar.Length;
                listBox2.Items.Add(ortalama);

             ortalama = toplam / sayilar.Length;
                label2.Text = ortalama.ToString();
            }

                
            }
        }
    }

