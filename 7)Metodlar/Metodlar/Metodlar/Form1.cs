using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;

            textBox1.Focus();
        }
        private void renklendir()
        {
            textBox1.BackColor = Color.Aquamarine;
            textBox2.BackColor = Color.DarkRed;
            textBox3.BackColor = Color.Beige;
            textBox4.BackColor = Color.DarkTurquoise;

        }
        private void doldur()
        {
            textBox1.Text = "Ahsen";
            textBox2.Text = "Can";
            textBox3.Text = "07.08.2018";
            textBox4.Text = "Burdur";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Rem_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void Dol_Click(object sender, EventArgs e)
        {
            doldur();
        }
    }
}
