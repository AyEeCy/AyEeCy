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
    public partial class AnaForum : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KLVSABI;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSehir.Text = "";
            txtMeslek.Text = "";
            mtxtMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();

        }


        public AnaForum()
        {
            InitializeComponent();
        }

        



        private void btnListele1_Click(object sender, EventArgs e)
        {
            this.personelTablosuTableAdapter.Fill(this.personelVeriTabaniDataSet.PersonelTablosu);

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into PersonelTablosu (PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",txtSehir.Text);
            komut.Parameters.AddWithValue("@p4",mtxtMaas.Text);
            komut.Parameters.AddWithValue("@p5",label1.Text);
            komut.Parameters.AddWithValue("@p6",txtMeslek.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi!","Kayıt İşlemleri",MessageBoxButtons.OK, MessageBoxIcon.Information);


            baglanti.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label2.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label2.Text = "False";
            }
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtxtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        
            
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label2.Text == "False") 
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From PersonelTablosu Where PerID=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1",txtID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silinmiştir");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update PersonelTablosu Set PerAd=@a1, PerSoyad=@a2, PerSehir=@a3, PerMaas=@a4, PerDurum=@a5, PerMeslek=@a6 where PerID=@a7",baglanti);
            guncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@a3", txtSehir.Text);
            guncelle.Parameters.AddWithValue("@a4", mtxtMaas.Text);
            guncelle.Parameters.AddWithValue("@a5", label2.Text);
            guncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            guncelle.Parameters.AddWithValue("@a7", txtID.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Güncellendi!!");
            baglanti.Close();

        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            İstatistik frm = new İstatistik();
            frm.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafikler gfk =new Grafikler();
            gfk .Show();
          
        }

        
    }
}
