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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int faktoriyel(int sayi)
        {
            if(sayi == 0)
            {
                return 1;
            }
            return sayi * faktoriyel(sayi - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            label3.Text = faktoriyel(sayi).ToString();

        }
    }
}
