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

namespace pansiyon_kayıt_uygulaması
{
    public partial class frmMusterilercs : Form
    {
        public frmMusterilercs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QJKSVIR0; Initial Catalog=PapatyaPansiyon; Integrated Security=True; TrustServerCertificate=True");

        private void VerileriGoster()
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku["MusteriId"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
        int id = 0;
        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
        private void listViev1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];

                try
                {
                    id = int.Parse(selectedItem.SubItems[0].Text);
                    txtAd.Text = selectedItem.SubItems[1].Text;
                    txtSoyad.Text = selectedItem.SubItems[2].Text;
                    cbCinsiyet.Text = selectedItem.SubItems[3].Text;
                    maskedTextBoxTelefon.Text = selectedItem.SubItems[4].Text;
                    txtMail.Text = selectedItem.SubItems[5].Text;
                    txtTcNo.Text = selectedItem.SubItems[6].Text;
                    txtOdaNo.Text = selectedItem.SubItems[7].Text;
                    txtUcret.Text = selectedItem.SubItems[8].Text;

                    // Tarihleri ayarlarken Value kullanın
                    dateTimeGiris.Value = DateTime.Parse(selectedItem.SubItems[9].Text);
                    dateTimeCikis.Value = DateTime.Parse(selectedItem.SubItems[10].Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }

            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update MusteriEkle set Ad ='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',Cinsiyet='" + cbCinsiyet.Text + "'where MusteriId=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "201")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda201", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "202")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda202", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "203")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda203", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "301")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda301", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "302")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda302", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
            if (txtOdaNo.Text == "303")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda303", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                VerileriGoster();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbCinsiyet.Text = "";
            txtMail.Text = "";
            txtTcNo.Clear();
            txtOdaNo.Clear();
            txtUcret.Clear();
            dateTimeGiris.Text = "";
            dateTimeCikis.Text = "";

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Ad like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku["MusteriId"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
    
    }
}
