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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;user id=root;database=kargotakip");

        private void button1_Click(object sender, EventArgs e)
        {
            string d;
            baglanti.Open();
            MySqlCommand guncel = new MySqlCommand("UPDATE musteribil SET TCKimlik='"+txttc.Text+ "',Ad='"+txtad.Text+"',Soyad='"+txtsoyad.Text+"',CepTel='"+txttel.Text+"',Email='"+txtmail.Text+"',Adres='"+txtadres.Text+"',GonderilecekAdres='"+txtgonadres.Text+"',Fiyat='"+textBox2.Text+"',Durum='"+comboBox1.Text+"',KargoNo='"+textBox1.Text+"' WHERE KargoNo='"+textBox1.Text+"' ", baglanti);
            guncel.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("başarıyı ile güncellendi");
            scmc();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmc();
            scmc();
        }
        void cmc()
        {
            string sorgu = "Select * From musteribil";
            baglanti.Open();
            MySqlDataAdapter getir = new MySqlDataAdapter(sorgu, baglanti);
            DataSet göster = new DataSet();
            getir.Fill(göster, "musteribil");
            dataGridView2.DataSource = göster.Tables["musteribil"];
            getir.Dispose();
            baglanti.Close();
        }
        void scmc()
        {
            string sorgu = "Select * From musteribil";
            baglanti.Open();
            MySqlDataAdapter getir = new MySqlDataAdapter(sorgu, baglanti);
            DataSet göster = new DataSet();
            getir.Fill(göster, "musteribil");
            dataGridView1.DataSource = göster.Tables["musteribil"];
            getir.Dispose();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("delete From musteribil Where KargoNo=@k", baglanti);
            sil.Parameters.AddWithValue("@k", textBox1.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi");
            baglanti.Close();
            cmc();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView2.SelectedCells[0].RowIndex;
            txttc.Text = dataGridView2.Rows[secili].Cells[3].Value.ToString();
            txtad.Text = dataGridView2.Rows[secili].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView2.Rows[secili].Cells[2].Value.ToString();
            txttel.Text = dataGridView2.Rows[secili].Cells[4].Value.ToString();
            txtmail.Text = dataGridView2.Rows[secili].Cells[5].Value.ToString();
            textBox1.Text = dataGridView2.Rows[secili].Cells[0].Value.ToString();
            txtadres.Text = dataGridView2.Rows[secili].Cells[6].Value.ToString();

            txtgonadres.Text = dataGridView2.Rows[secili].Cells[7].Value.ToString();
            textBox2.Text = dataGridView2.Rows[secili].Cells[8].Value.ToString();
           
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
        }
    }
}
