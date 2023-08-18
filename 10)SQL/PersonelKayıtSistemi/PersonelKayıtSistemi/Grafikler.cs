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
    public partial class Grafikler : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KLVSABI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public Grafikler()
        {
            InitializeComponent();
        }

       
private void Grafikler_Load(object sender, EventArgs e)
        {
            //Şehirlerdeki insan sayısı

            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select PerSehir, count(*) from PersonelTablosu group by PerSehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();

            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglanti.Close();
            //Sehir Maas

            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("select PerMeslek, avg(PerMaas) from PersonelTablosu group by PerMeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglanti.Close();

        }
    }
}
