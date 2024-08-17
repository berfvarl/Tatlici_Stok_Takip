using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Tatlıcı_Stok_Takip
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StokTakip.mdb;Jet OLEDB:Engine Type=5");

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Bütün Alanları Doldurun.");
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select * from kullanicibilgi where id='" + textBox1.Text + "'", baglanti);
                OleDbDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read()==true)
                {
                    if (textBox1.Text == okuyucu["id"].ToString() && textBox2.Text == okuyucu["sifre"].ToString())
                    {

                        MessageBox.Show("Hoş Geldin Sayın " + okuyucu["adsoyad"].ToString());
                        Form form = new anamenu();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriş Bilgilerinizi Kontrol Edin.");
                    }
              
                }
                else
                {
                    MessageBox.Show("Giriş Bilgilerinizi Kontrol Edin.");
                }

               baglanti.Close();
            }
        }
    }
}
