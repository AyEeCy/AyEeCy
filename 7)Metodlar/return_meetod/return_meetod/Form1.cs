using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace return_meetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1;
        int s2, s3;
        private int carpma(int s1,int s2) {
            int s3 = s1 * s2;
            return s3;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);

            
            label1.Text = carpma(s1, s2).ToString();
        }
    }
}
