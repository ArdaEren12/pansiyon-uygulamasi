using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.Sql;



namespace pansiyon_kayıt_uygulaması
{
    public partial class frmgelirGider : Form
    {
        public frmgelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QJKSVIR0; Initial Catalog=PapatyaPansiyon; Integrated Security=True; TrustServerCertificate=True");


        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum (Ucret)as toplam from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) 
                {
                lblToplamTutar.Text = oku["toplam"].ToString();
                }
            baglanti.Close();

            //gıda giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum (Gida)as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                gida.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();
            //icecek giderleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum (Icecek)as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                icecek.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();


            //atıstırmalık giderleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum (Cerezler)as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                cerez.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();



            //faturalar kısmı

            //internet
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum (Elektirik)as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblElektirik.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum (Su)as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblSu.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();

            //Internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum (Internet)as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblInternet.Text = oku7["toplam7"].ToString();
            }
            baglanti.Close();

            int personel;
            personel = Convert.ToInt16(txtBxPersonelSayisi.Text);
            lblPersonelmaas.Text=(personel * 20000).ToString();



            int toplamTutar = Convert.ToInt32(lblToplamTutar.Text);
            int personelMaas = Convert.ToInt32(lblPersonelmaas.Text);
            int elektrik = Convert.ToInt32(lblElektirik.Text);
            int su = Convert.ToInt32(lblSu.Text);
            int internet = Convert.ToInt32(lblInternet.Text);
            int degiskenCerez = Convert.ToInt32(cerez.Text);
            int degislkenIcecek = Convert.ToInt32(icecek.Text);
            int degiskenGida = Convert.ToInt32(gida.Text);

            int sonuc = toplamTutar - (personelMaas + elektrik + su + internet + degiskenCerez + degislkenIcecek + degiskenGida);

            lblSonuc.Text = sonuc.ToString();

        }
    }
}
