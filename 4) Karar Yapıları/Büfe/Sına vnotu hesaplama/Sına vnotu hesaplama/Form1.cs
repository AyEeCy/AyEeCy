using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sına_vnotu_hesaplama
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  sınav1, sınav2, sınav3, ortalama;
            sınav1 = Convert.ToInt32(textBox1.Text) ;
            sınav2 = Convert.ToInt32(textBox2.Text);
            sınav3 = Convert.ToInt32(textBox3.Text);

            ortalama = (sınav1 + sınav2 + sınav3) / 3;

            textBox4.Text = ortalama.ToString();
        }
    }
}
