using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] adlar = { "ahsen", "ahmet", "mehmet", "filiz", "hüseyin" };

            for (int i = 0; i < adlar.Length; i++){
                listBox1.Items.Add((b++)+")" + adlar[i]);
            }
            


        }
        int a = 0,b = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
