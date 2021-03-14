using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSatışPaneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            caytbox.Text = " ";
            kahvetbox.Text = " ";
            kektbox.Text = " ";
            sutbox.Text = " ";
            toplampara.Text = "00";
        }
        
        int kasa = 0;
        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int cay, kahve, kek, su , toplam;

            cay = Convert.ToInt16(caytbox.Text);
            kahve = Convert.ToInt16(kahvetbox.Text);
            kek = Convert.ToInt16(kektbox.Text);
            su = Convert.ToInt16(sutbox.Text);
            

            toplam = cay * 2 + kahve * 3 + kek * 3 + su * 1;
            toplampara.Text = toplam.ToString();

            
            kasa = toplam + kasa;
            kasapara.Text = kasa.ToString();


        }
        private void paracek_Click(object sender, EventArgs e)
        {
            if (kasapara.Text == "00")
            {
                MessageBox.Show("Para Çekim İşlemi Gerçektirilemedi Kasanızda Para bulunmuyor." , "İşlem Başarısız!" ,MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else
            {
            kasapara.Text = "00";
            MessageBox.Show("Para Çekim İşleminiz Tamamlanmıştır." , "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
