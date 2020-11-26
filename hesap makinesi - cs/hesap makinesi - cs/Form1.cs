using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi___cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = 0;


            if (checkBox1.Checked == true)
            {

                sonuc = sayi1 + sayi2;
                label2.Text = sonuc.ToString();

            }
            else if (checkBox2.Checked == true)
            {
                sonuc = sayi1 - sayi2;
                label2.Text = sonuc.ToString();
            }
            else if (checkBox3.Checked == true)
            {
                sonuc = sayi1 * sayi2;
                label2.Text = sonuc.ToString();
            }
            else if (checkBox4.Checked == true)
            {
                sonuc = sayi1 / sayi2;
                label2.Text = sonuc.ToString();
            }

        }
    }
}
