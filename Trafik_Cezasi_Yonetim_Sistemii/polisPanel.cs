using System;
using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetim_Sistemii
{
    public partial class polisPanel : Form
    {
        private Form1 _mainForm;

        public polisPanel(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        public polisPanel()
        {
            InitializeComponent();
        }

        private void polisPanel_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayıtlı_polis_ıd = "12345678910";
            string panel_sifre = "1234";

            string girilen_ıd = textBox1.Text;
            string girilen_sifre = textBox2.Text;


            
            if (girilen_ıd.Length != 11)
            {
                MessageBox.Show("TC kimlik numaranız 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Şifre kontrolü 
            if (girilen_ıd == kayıtlı_polis_ıd && girilen_sifre == panel_sifre)
            {
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cezaEkleForm cezaEkle = new cezaEkleForm(_mainForm);
                cezaEkle.Show();
                this.Close();
            }
            else if (girilen_sifre != panel_sifre)
            {
                MessageBox.Show("Girdiğiniz şifre hatalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Girdiğiniz ID hatalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }















        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
