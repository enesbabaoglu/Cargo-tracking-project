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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection(@"server=localhost;user id=root;database=kargotakip");

        private void btnara_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter getir = new MySqlDataAdapter("Select * From müsteribil", baglanti);
            baglanti.Open();
            getir.SelectCommand.CommandText = "Select * From musteribil" + " where(TCKimlik = '" + txttc.Text + "')";
            DataSet goster = new DataSet();
            getir.Fill(goster, "musteribil");
            goster.Tables["musteribil"].Clear();
            dataGridViewsonuc.DataSource = goster.Tables["musteribil"];
            getir.Fill(goster, "musteribil");
            baglanti.Close();

        }

        private void dataGridViewsonuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridViewsonuc.SelectedCells[0].RowIndex;
            string d;
            DialogResult s;
            d = dataGridViewsonuc.Rows[secili].Cells[9].Value.ToString();
            s = MessageBox.Show(d.ToString(), "YAZDIRMAK İSTER MİSİNİZ", MessageBoxButtons.OKCancel);
            if (s == DialogResult.OK)
            {
                MessageBox.Show("Yazdırıldı");

            }
        }
    }
}
