using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikAraçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

            for (int i = 1; i <=5 ; i++) {
                Button bt = new Button();
                Point pt = new Point(100, i* 50);
                bt.Location = pt;
                bt.Text = i.ToString();
                bt.BackColor = Color.Violet;
                bt.AutoSize = true;
                bt.Name = "button"+ i;
                bt.Height = 20;
                bt.Width = 100;
                this.Controls.Add(bt);
            }
            for (int i = 1;i <=5 ; i++)
            {
                TextBox tb = new TextBox();
                Point tpt =new Point(300, i* 50);
                tb.Location = tpt;
                tb.Text = i.ToString();
                tb.BackColor = Color.DarkViolet;
                tb.AutoSize = true;
                tb.Name = "button"+ i;
                tb.Height = 20;
                tb.Width = 400;
                this.Controls.Add(tb);
            }

        }
    }
}
