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
namespace bankamatik_simulasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3VB3SSC\MSSQLSERVERR;Initial Catalog=dbbankamatiktest;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblkisiler (ad,soyad,tc,telefon,hesapno,sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", mskhesapno.Text);
            komut.Parameters.AddWithValue("@p6", txtsifre.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt İşlemi Tamamlandi");
            baglanti.Close();
        }
        int sayi;
        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(100000, 1000000);
            mskhesapno.Text = sayi.ToString();
        }
    }
}
