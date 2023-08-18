using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Kitaplar"].Points.AddXY("Akdeniz", 15);
            chart1.Series["Kitaplar"].Points.AddXY("Karadeniz", 5);
            chart1.Series["Kitaplar"].Points.AddXY("İçAnadolu", 7);
            chart1.Series["Kitaplar"].Points.AddXY("GüneyDoğu Anadolu", 3);
            chart1.Series["Kitaplar"].Points.AddXY("Ege", 13);
        }
    }
}
