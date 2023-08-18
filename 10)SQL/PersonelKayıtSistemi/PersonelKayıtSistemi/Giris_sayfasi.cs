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
    public partial class Giris_sayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KLVSABI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        public Giris_sayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select * from KullanıcıTablosu where PerKulAd=@k1 and PerSifre=@k2", baglanti);
            komut1.Parameters.AddWithValue("@k1", txtKulAd.Text);
            komut1.Parameters.AddWithValue("@k2", txtSifre.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                AnaForum anaForum = new AnaForum();
                anaForum.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Hatalı Şifre yada Kullanıcı Adı!!");
            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtEkranı geç = new KayıtEkranı();
            geç.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("select * from AdminPanel where KullanıcıAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                AnaForum anaForum = new AnaForum();
                anaForum.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Hatalı Şifre yada Kullanıcı Adı!!");
            }
            baglanti.Close();
        }
    }
}
