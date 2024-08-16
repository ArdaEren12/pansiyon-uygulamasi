using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyon_kayıt_uygulaması
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOdalar Odalar=new frmOdalar();
            Odalar.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr=new Form1();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri MusteriEkleForm = new FrmYeniMusteri();
            MusteriEkleForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMusterilercs musteriler = new frmMusterilercs();
            musteriler.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Papatya pansiyonuna hoş geldiniz");
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToLongDateString();
            label2.Text=DateTime.Now.ToLongTimeString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmgelirGider frmgelir = new frmgelirGider();
            frmgelir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmStoklar stoklar = new frmStoklar();
            stoklar.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmFaturalar faturalar = new frmFaturalar();
            faturalar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MüşteriMesajları xx =new MüşteriMesajları();
            xx.Show();
            
        }
    }
}
