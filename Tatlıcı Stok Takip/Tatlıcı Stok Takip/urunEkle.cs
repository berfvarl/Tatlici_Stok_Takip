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
    public partial class urunEkle : Form
    {
        public urunEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\berfi\\OneDrive\\Masaüstü\\StokTakip.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand urunEkle = new OleDbCommand("insert into urunlertablo (id,urun) values ('" + textBox1.Text + "','" + textBox2.Text + "')", baglanti);
            urunEkle.ExecuteNonQuery();
            baglanti.Close();
            label3.Text = textBox2.Text + " ürünü başarıyla eklendi ";
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
