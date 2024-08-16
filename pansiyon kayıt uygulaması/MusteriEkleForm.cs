using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace pansiyon_kayıt_uygulaması
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QJKSVIR0; Initial Catalog=PapatyaPansiyon; Integrated Security=True; TrustServerCertificate=True");



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda101(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda102(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda103(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "201";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda201(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "202";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda202(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "203";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda203(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "301";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda301(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn302_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "302";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda302(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "303";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda303(ad,soyad) values('" + txtAd.Text + "','" + txtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil odalar boş odaları gösterir.");
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı odalar dolu odaları gösterir.");

        }

        private void dateTimeCikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;

            DateTime kucukTarih = dateTimeGiris.Value;
            DateTime buyukTarih = dateTimeCikis.Value;

            TimeSpan sonuc = buyukTarih - kucukTarih;
            label1.Text = sonuc.TotalDays.ToString("0");

            if (int.TryParse(label1.Text, out int days))
            {
                ucret = days * 5000;
                txtUcret.Text = ucret.ToString();
            }
            else if (buyukTarih < kucukTarih || buyukTarih == kucukTarih)
            {
                MessageBox.Show("Gün sayısı geçerli bir tamsayı değil.");
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Ad, Soyad, Cinsiyet, telefon, Mail, Tc, OdaNo, Ucret, GirisTarihi, CıkısTarihi) values(@Ad, @Soyad, @Cinsiyet, @Telefon, @Mail, @Tc, @OdaNo, @Ucret, @GirisTarihi, @CikisTarihi)", baglanti);

            // Parametrelerin eklenmesi
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", cbCinsiyet.Text);
            komut.Parameters.AddWithValue("@Telefon", maskedTextBoxTelefon.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Tc", txtTcNo.Text);
            komut.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text);
            komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
            komut.Parameters.AddWithValue("@GirisTarihi", dateTimeGiris.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@CikisTarihi", dateTimeCikis.Value.ToString("yyyy-MM-dd"));

            // Komutun çalıştırılması
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("müsteri kaydı yapıldı. ");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            void OdaButonGuncelle(string odaNumarasi, Button buton)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand($"select * from oda{odaNumarasi}", baglanti);
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        buton.Text = $"{oku["ad"]} {oku["soyad"]}";
                    }
                    else
                    {
                        buton.Text = odaNumarasi;
                    }

                    if (buton.Text != odaNumarasi)
                    {
                        buton.BackColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
                finally
                {
                    baglanti.Close();
                }
            }

            // Her oda için butonları güncelle
            OdaButonGuncelle("101", btn101);
            OdaButonGuncelle("102", btn102);
            OdaButonGuncelle("103", btn103);
            OdaButonGuncelle("201", btn201);
            OdaButonGuncelle("202", btn202);
            OdaButonGuncelle("203", btn203);
            OdaButonGuncelle("301", btn301);
            OdaButonGuncelle("302", btn302);
            OdaButonGuncelle("303", btn303);
        }
    }
}
//Data Source=LAPTOP-QJKSVIR0;Initial Catalog=PapatyaPansiyon;Integrated Security=True;Trust Server Certificate=True