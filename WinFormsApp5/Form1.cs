namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void yazdir()
        {
            textBox1.Text = "Atakan";
            textBox2.Text = "Arslan";
            textBox3.Text = "Amasya";
        }

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
