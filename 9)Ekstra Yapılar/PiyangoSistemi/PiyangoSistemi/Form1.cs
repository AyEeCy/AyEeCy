using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiyangoSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2, s3, s4;

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            button1_Click(sender, e);
           
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
            timer1.Start();
            Random rand = new Random(); 
            s1 = rand.Next(1,4);
            s2 = rand.Next(1,4);
            s3 = rand.Next(1,4);
            s4 = rand.Next(1,4);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            


            //1.sayı
            if (label1.Text == textBox1.Text) {

                textBox1.BackColor = Color.Green;
                label1.BackColor = Color.Green;

            }
            else
            {
                textBox1.BackColor = Color.Red; 
                label1.BackColor = Color.Red;
            }

            //2.sayı
            if (label2.Text == textBox2.Text)
            {

                textBox2.BackColor = Color.Green;
                label2.BackColor = Color.Green;

            }
            else
            {
                textBox2.BackColor = Color.Red;
                label2.BackColor = Color.Red;
            }

            //3.sayı
            if (label3.Text == textBox3.Text)
            {

                textBox3.BackColor = Color.Green;
                label3.BackColor = Color.Green;

            }
            else
            {
                textBox3.BackColor = Color.Red;
                label3.BackColor = Color.Red;
            }

            //4.sayı
            if (label4.Text == textBox4.Text)
            {

                textBox4.BackColor = Color.Green;
                label4.BackColor = Color.Green;

            }
            else
            {
                textBox4.BackColor = Color.Red;
                label4.BackColor = Color.Red;
            }
        }
    }
}
