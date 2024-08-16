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
    public partial class MüşteriMesajları : Form
    {
        public MüşteriMesajları()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QJKSVIR0; Initial Catalog=PapatyaPansiyon; Integrated Security=True; TrustServerCertificate=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void VerileriGoster()
        {
            listView1.Items.Clear();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku["Mesaj"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                
                
                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void MüşteriMesajları_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
