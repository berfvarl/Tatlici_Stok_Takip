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
    public partial class aramayap : Form
    {
        public aramayap()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\berfi\\OneDrive\\Masaüstü\\StokTakip.mdb");
        DataTable tablo = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Müşteri")
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter musteriAdapter = new OleDbDataAdapter("select * from musteri ", baglanti);
                musteriAdapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

            else if (comboBox1.Text =="Menü")
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter menuAdapter = new OleDbDataAdapter("select * from menu ", baglanti);
                menuAdapter.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

            }
        }

        
    }
}
