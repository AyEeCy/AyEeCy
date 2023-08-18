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
    public partial class İstatistik : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KLVSABI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public İstatistik()
        {
            InitializeComponent();
        }

        private void İstatistik_Load(object sender, EventArgs e)
        {

            //Personel sayısı

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select  Count (*) From PersonelTablosu ", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {

                lblTP.Text = dr1[0].ToString();

            }
            baglanti.Close();


            //Evli personel

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From PersonelTablosu where PerDurum = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                lblEP.Text = dr2[0].ToString();
            }

            baglanti.Close();

            // Bekar personel

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) from PersonelTablosu where PerDurum = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBP.Text = dr3[0].ToString();
            }

            baglanti.Close();

            //Şehir sayısı
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from PersonelTablosu", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblS.Text = dr4[0].ToString();
            }

            baglanti.Close();

            //Toplam Maas

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("select sum(PerMaas) from PersonelTablosu", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblTM.Text = dr5[0].ToString();
            }

            baglanti.Close();

            //Ortalama Maas

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(PerMaas) from PersonelTablosu", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOM.Text = dr6[0].ToString();
            }

            baglanti.Close();

        }

       
    }
}
