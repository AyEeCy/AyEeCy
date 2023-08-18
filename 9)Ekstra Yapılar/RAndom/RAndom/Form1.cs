using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAndom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2, s3;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            label4.Text = i.ToString();
            //if (i == 0)
            //{
            //    timer1.Start();
            //}
            //else if (i > 10)
            //{
            //    timer1.Stop();
            //    i -= 10;
            //}
            Random rd = new Random();
            
            s1 = rd.Next(1,10);
            s2 = rd.Next(1,10);
            s3 = rd.Next(1,10);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            i += 1;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(sender, e);   
        }
    }
}
