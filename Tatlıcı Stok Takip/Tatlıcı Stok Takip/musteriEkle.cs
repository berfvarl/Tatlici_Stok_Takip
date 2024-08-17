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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tatlıcı_Stok_Takip
{
    public partial class musteriEkle : Form
    {
        public musteriEkle()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\berfi\\OneDrive\\Masaüstü\\StokTakip.mdb");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand musteriEklemekomutu = new OleDbCommand("insert into musteri (ad,soyad,adres,telefon,eposta) values ('" + textBox1.Text + "', '" + textBox2.Text + "' , '" + textBox5.Text + "', '" + textBox3.Text + "', '"+textBox4.Text+"')", baglanti);
            musteriEklemekomutu.ExecuteNonQuery();
            baglanti.Close();
            label6.Text = textBox1.Text +" "+ textBox2.Text+  " adlı müşteri başarıyla kaydedildi";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        
    }
}
