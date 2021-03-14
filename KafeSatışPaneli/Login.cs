using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KafeSatışPaneli
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            stbox.PasswordChar = '*';
        }
        string kullaniciad = "Admin";
        string sifre = "1234";
        private void button1_Click(object sender, EventArgs e)
        {
            if (ktbox.Text == kullaniciad && stbox.Text == sifre)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Veya Kullanıcı Adı Tekrar Deneyiniz." , "Uyarı" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
