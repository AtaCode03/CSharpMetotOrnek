using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] dizi = new string[3];
        int sayac = 0;

        void ekle()
        {
            dizi[sayac] = textBox4.Text;
            sayac++;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ekle();
        }
        void yazdir()
        {
            textBox1.Text = dizi[0];
            textBox2.Text = dizi[1];
            textBox3.Text = dizi[2];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yazdir();
        }
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
