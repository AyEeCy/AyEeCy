using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikfonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            //label1.Text = Math.Abs(sayi1).ToString();
            //label1.Text = Math.Pow(sayi1).ToString();
            //label1.Text = Math.Sqrt(sayi1).ToString();
            //label1.Text = Math.Floor(sayi1).ToString();
            label1.Text = Math.Ceiling(sayi1).ToString();
        }
    }
}
/*
Abs = Mutlak
Ceil = Üste Yuvarlamak
Floor = Alta Yuvarlamak
Pow = Üs Almak
Sqrt = Kare Kök Almak
19:34 11.08.2023 
 */