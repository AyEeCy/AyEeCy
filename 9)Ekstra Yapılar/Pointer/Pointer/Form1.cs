using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Random rand = new Random();
            int sayi1,sayi2;
            sayi1 = rand.Next(0,1000);
            sayi2 = rand.Next(0,800);

            Point point = new Point();
                point.X = sayi1;
                point.Y = sayi2;
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();

            panel1.Location = point;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
