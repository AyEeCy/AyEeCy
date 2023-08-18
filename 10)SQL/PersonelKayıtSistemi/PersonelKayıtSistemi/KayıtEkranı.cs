using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelKayıtSistemi
{
    public partial class KayıtEkranı : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KLVSABI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        public KayıtEkranı()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris_sayfasi giris_Sayfasi = new Giris_sayfasi();
            giris_Sayfasi.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KullanıcıTablosu (PerKulAd,PerSifre)  values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşlemi Tamamlanmıştır.");
            baglanti.Close();
        }
    }
}
