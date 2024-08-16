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
using System.Data.Sql;

namespace pansiyon_kayıt_uygulaması
{
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QJKSVIR0; Initial Catalog=PapatyaPansiyon; Integrated Security=True; TrustServerCertificate=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from stoklar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Stoklar (Gida, Icecek, Cerezler) VALUES (@gida, @icecek, @cerez)", baglanti);
                komut.Parameters.AddWithValue("@gida", gida.Text);
                komut.Parameters.AddWithValue("@icecek", icecek.Text);
                komut.Parameters.AddWithValue("@cerez", cerez.Text);
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
                veriler();
            }
        }

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
