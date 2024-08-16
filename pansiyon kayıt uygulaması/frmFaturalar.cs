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
    public partial class frmFaturalar : Form
    {
        public frmFaturalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QJKSVIR0; Initial Catalog=PapatyaPansiyon; Integrated Security=True; TrustServerCertificate=True");

        private void veriler2()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektirik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["Internet"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void frmFaturalar_Load(object sender, EventArgs e)
        {
            veriler2 ();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Faturalar (Elektirik, Su, Internet) VALUES (@Elektirik, @Su, @Internet)", baglanti);
                komut.Parameters.AddWithValue("@Elektirik", gida.Text);
                komut.Parameters.AddWithValue("@Su", icecek.Text);
                komut.Parameters.AddWithValue("@Internet", cerez.Text);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Hata mesajı gösterebilirsiniz
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                veriler2();
            }
        }
    }
}
