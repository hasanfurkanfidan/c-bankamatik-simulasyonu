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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
         public string hesap_no;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3VB3SSC\MSSQLSERVERR;Initial Catalog=dbbankamatiktest;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            lblhesapno.Text = hesap_no;
            SqlCommand komut = new SqlCommand("select * from tblkisiler where hesapno = @p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap_no);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                txttc.Text = dr[3].ToString();
                txttelefon.Text = dr[4].ToString();
              
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblhesap set bakiye = bakiye+@p1 where hesapno = @p2",baglanti);
          
            komut.Parameters.AddWithValue("@p1", txttutar.Text);
            komut.Parameters.AddWithValue("@p2", mskhesapno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update tblhesap set bakiye = bakiye-@d1 where hesapno = @d2",baglanti);
            komut2.Parameters.AddWithValue("@d1", txttutar.Text);
            komut2.Parameters.AddWithValue("@d2", lblhesapno.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı...");


        }
    }
}
