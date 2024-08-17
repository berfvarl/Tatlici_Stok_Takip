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
    public partial class menuekle : Form
    {
        public menuekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\berfi\\OneDrive\\Masaüstü\\StokTakip.mdb");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuekle_Load(object sender, EventArgs e)
        {
            //comboboxa kategori alma
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select kategori from kategori ", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["kategori"].ToString());

            }
            baglanti.Close();

            //comboboxa ürün türü alma

            baglanti.Open();
            OleDbCommand komutUrunTuru = new OleDbCommand("select urunturu from urunekle ", baglanti);
            OleDbDataReader okuUrunTuru = komutUrunTuru.ExecuteReader();
            while (okuUrunTuru.Read())
            {
                comboBox2.Items.Add(okuUrunTuru["urunturu"].ToString());

            }
            baglanti.Close();

            //comboboxa ürün alma
            baglanti.Open();
            OleDbCommand komutUrun = new OleDbCommand("select urun from urunlertablo", baglanti);
            OleDbDataReader okuUrun = komutUrun.ExecuteReader();
            while (okuUrun.Read())
            {
                comboBox3.Items.Add(okuUrun["urun"].ToString());

            }
            baglanti.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutMenuEkle = new OleDbCommand("insert into menu (barkodno,kategori,urunturu,urun,menuadi,adet,rafno,gtarihi) values ('" + textBox1.Text + "', '" + comboBox1.Text + "'  , '" + comboBox2.Text + "', '" + comboBox3.Text + "'  , '" + textBox2.Text + "' , '" + textBox3.Text + "', '"+textBox4.Text+"', '" + dateTimePicker1.Text + "')",baglanti);
            komutMenuEkle.ExecuteNonQuery();
            label8.Text = "Menü Başarıyla Eklendi";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            baglanti.Close();
           
        }
    }
}
