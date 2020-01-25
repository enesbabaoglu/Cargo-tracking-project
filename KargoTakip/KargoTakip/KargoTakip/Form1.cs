using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kargoGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 y = new Form2();
            y.MdiParent = this;
            y.Show();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void fiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 y = new Form4();
            y.MdiParent = this;
            y.Show();
        }

        private void kargoTakipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 y = new Form3();
            y.MdiParent = this;
            y.Show();
        }

        private void adminGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 y = new Form5();
            y.MdiParent = this;
            y.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kargo Şirketimiz 2017 Aralık'ta kurulmuştur. Kurucumuz Enes BABAOĞLU 'dur");
        }
    }
}
