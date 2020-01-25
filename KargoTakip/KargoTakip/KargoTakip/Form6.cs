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
    public partial class Form6 : Form
    {
        Form2 form13 = new Form2();
        public Form6()
        {

            InitializeComponent();


        }
        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;user id=root;database=kargotakip");

        private void Form6_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter getir = new MySqlDataAdapter("SELECT * From musteribil", baglanti);
            baglanti.Open();
            DataSet goster = new DataSet();
            getir.Fill(goster, "musteribil");
            dataGridView1.DataSource = goster.Tables["musteribil"];
            getir.Dispose();
            baglanti.Close();
        }
        int secili = 0;
        void gezinti()
        {
            textBox2.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            form13.txttc.Text = textBox2.Text;
            form13.txtad.Text = textBox3.Text;
            form13.txtsoyad.Text = textBox4.Text;
            form13.txttel.Text = textBox5.Text;
            form13.txtmail.Text = textBox6.Text;
           
            form13.txtadres.Text = richTextBox1.Text;
            form13.txtgonadres.Text = richTextBox2.Text;
            form13.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter getir = new MySqlDataAdapter("Select * From musteribil", baglanti);
            baglanti.Open();
            getir.SelectCommand.CommandText = "Select * From musteribil" + " where(TCKimlik like '%" + textBox1.Text + "%')";
            DataSet goster = new DataSet();
            getir.Fill(goster, "musteribil");
            goster.Tables["musteribil"].Clear();
            dataGridView1.DataSource = goster.Tables["musteribil"];
            getir.Fill(goster, "musteribil");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secili].Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secili].Cells[6].Value.ToString();
            richTextBox2.Text = dataGridView1.Rows[secili].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
