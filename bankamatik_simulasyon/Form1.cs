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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3VB3SSC\MSSQLSERVERR;Initial Catalog=dbbankamatiktest;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form3 frr = new Form3();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblkisiler where hesapno = @p1 and sifre = @p2",baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frr.hesap_no = maskedTextBox1.Text;
                frr.Show();
                this.Hide();
            }
            baglanti.Close();
            
        }
    }
}
