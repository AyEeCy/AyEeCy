using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clasllar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.DeepPink;
           
            AnimeKizi ak1 = new AnimeKizi();


            ak1.ad = "Shouko";
            ak1.soyad = "Komi";
            ak1.durum = 'B';
            ak1.Sev = -1235323;
            ak1.yas = 17;

            label1.Text = ak1.soyad;
            label2.Text = ak1.ad;
            label3.Text = ak1.durum.ToString();
            label4.Text = ak1.Sev.ToString();
            label5.Text = ak1.yas.ToString();

        }

       
    }
}
