using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KargoTakip
{
    public partial class Form2 : Form
    {
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;user id=root;database=kargotakip");
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 y = new Form6();
            
            y.Show();
            this.Hide();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();                                                                                                                                                                    //`Ad`, `Soyad`, `TCKimlik`, `SeriNo`, `CepTel`, `Email`, `Adres`, `Gönderilecek Adres`, `Fiyat`, `Durum`)                                                                                 
            MySqlCommand kaydet = new MySqlCommand("INSERT INTO `musteribil`(`KargoNo`,`Ad`, `Soyad`, `TCKimlik`, `CepTel`, `Email`, `Adres`, `GonderilecekAdres`, `Fiyat`, `Durum`) VALUES (@kno,@ad,@soyad,@tc,@tel,@mail,@adres,@gadres,@fiyat,@durum)", baglanti);
            
            kaydet.Parameters.AddWithValue("@ad",txtad.Text);
            kaydet.Parameters.AddWithValue("@soyad",txtsoyad.Text);
            kaydet.Parameters.AddWithValue("@tc",txttc.Text);
            kaydet.Parameters.AddWithValue("@kno", txtkargo.Text);
            kaydet.Parameters.AddWithValue("@adres",txtadres.Text);
            kaydet.Parameters.AddWithValue("@tel", txttel.Text);
            kaydet.Parameters.AddWithValue("@mail", txtmail.Text);
            kaydet.Parameters.AddWithValue("@gadres",txtgonadres.Text);
            kaydet.Parameters.AddWithValue("@fiyat",lblfiyat.Text);
            kaydet.Parameters.AddWithValue("@durum","beklemede");
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kargo Kaydedildi.");
            this.Hide();
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            Form4 n = new Form4();
            n.Show();
            this.Hide();
        }

        private void btnyaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Yazıcıya gönderildi");
        }
    }
}
