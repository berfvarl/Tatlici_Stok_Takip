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
    public partial class kullaniciEkle : Form
    {
        public kullaniciEkle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\berfi\\OneDrive\\Masaüstü\\StokTakip.mdb");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kullaniciEklekomutu = new OleDbCommand("insert into kullanicibilgi (id,sifre,adsoyad,gorevi) values ('"+textBox1.Text+"', '"+textBox2.Text+"' , '"+textBox3.Text+"', '"+textBox4.Text+"')",baglanti);
            kullaniciEklekomutu.ExecuteNonQuery();
            baglanti.Close();
            label5.Text = textBox3.Text + " Kullanıcı Başarıyla Kaydedildi";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
