using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capctha
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
            string[] harf1 = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string[] harf2 = { "A", "B", "C", "D", "E", "F", "G", "H" };
            string[] sembol3 = { "+", "-", "/", "$", "#", "<", "%", "&" };

            Random rand = new Random(); 

            int h1, h2, se3, s4, s5;

            h1 = rand.Next(0, harf1.Length);
            h2 = rand.Next(0, harf2.Length);
            se3 = rand.Next(0,sembol3.Length);
            s4 = rand.Next(0,8);
            s5 = rand.Next(0,8);
            this.BackColor = Color.Violet ;

            label1.Text = harf1[h1].ToString() + " " + s5.ToString() + " " + sembol3[se3].ToString() + " " + s4.ToString() + " " + harf2[h2].ToString();




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
            //veya this.close();
        }
    }
}
