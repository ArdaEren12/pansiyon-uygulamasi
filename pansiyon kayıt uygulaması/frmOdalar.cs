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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-QJKSVIR0; Initial Catalog=PapatyaPansiyon; Integrated Security=True; TrustServerCertificate=True");

        private void frmOdalar_Load(object sender, EventArgs e)
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