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
    public partial class Form4 : Form
    {
        Form2 frm2 = new Form2();
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a;
                double adet;

                double d;

                double k, y, m, c, b, l, p;
                adet = double.Parse(textBox4.Text);
                a = double.Parse(textBox6.Text);
                d = double.Parse(textBox5.Text);
                l = double.Parse(textBox2.Text);

                b = double.Parse(textBox1.Text);
                k = double.Parse(textBox3.Text);
                if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 18;

                    label15.Text = y.ToString();

                }

                if (comboBox1.Text == "Konya" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Konya" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 10;

                    label15.Text = y.ToString();

                }
                if (comboBox2.Text == "SOMA")
                {
                    int n = 0;

                    label15.Text = n.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 15;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 8;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 15;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 18;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 20;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 8;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 10;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 20;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 2;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Konya" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 2;

                    label15.Text = y.ToString();

                }
            }

            if (radioButton2.Checked)
            {
                double a;
                double adet;
                double d;
                double k, y, m, c, b, l, p;
                adet = double.Parse(textBox9.Text);
                d = double.Parse(textBox8.Text);
                a = double.Parse(textBox7.Text);
                l = double.Parse(textBox2.Text);
                b = double.Parse(textBox1.Text);
                k = double.Parse(textBox3.Text);
                /* m = k * d;
                p = l * adet;
                c = a * b;
                y = c + m + p;

               label1.Text = y.ToString();*/
                if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 18;

                    label15.Text = y.ToString();

                }

                if (comboBox1.Text == "Konya" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Konya" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 10;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 15;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 8;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 15;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 18;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 20;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 8;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 10;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 20;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Sivas" && comboBox2.Text == "Sivas")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 2;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "İstanbul" && comboBox2.Text == "İstanbul")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Ankara" && comboBox2.Text == "Ankara")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 5;

                    label15.Text = y.ToString();

                }
                if (comboBox1.Text == "Konya" && comboBox2.Text == "Konya")
                {
                    p = l * adet;

                    m = k * d;
                    c = a * b;
                    y = c + m + p + 2;

                    label15.Text = y.ToString();

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Form2 f = (Form2)this.Owner;
            frm2.lblfiyat.Text = label15.Text;
            frm2.Visible=true;
            this.Hide();
            //f.Show();
        }
    }
}
