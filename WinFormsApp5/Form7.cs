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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        double ortalama(int sınav1,int sınav2)
        {
            double ortalama = (sınav1 + sınav2) / 2;
            return ortalama;
        }
        double ortalama(int sınav1, int sınav2, int sınav3)
        {
            double ortalama = (sınav1 + sınav2 + sınav3) / 3;
            return ortalama;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = ortalama(20, 30);
            label3.Text = sonuc.ToString();
        }
    }
}
