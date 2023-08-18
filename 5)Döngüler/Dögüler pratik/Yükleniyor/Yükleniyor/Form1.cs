using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yükleniyor
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
            
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            progressBar1.Value = a;
            label2.Text = a.ToString();
            if (progressBar1.Value%2 ==  0) {
                this.BackColor = Color.MidnightBlue;
                    }
            if (progressBar1.Value %2 == 1 )
                this.BackColor = Color.MediumVioletRed;
            if (progressBar1.Value ==100) {
                timer1.Stop();
                MessageBox.Show("İşlem Tamamladı.");

            }

        }
    }
}
