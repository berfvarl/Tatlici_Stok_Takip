using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatlıcı_Stok_Takip
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yardim = new yardim();
            yardim.Show();
            
        }

        private void kategoriOluşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kategori = new kategori();
            kategori.Show();
        }

      

        private void tatlıTürüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form urunTuru = new urunTuru();
            urunTuru.Show();
        }

        private void tatlılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form urunEkle = new urunEkle();
            urunEkle.Show();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kullaniciEkle = new kullaniciEkle();
            kullaniciEkle.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form musteriEkle = new musteriEkle();
            musteriEkle.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menuekle = new menuekle();
            menuekle.Show();
        }

        private void menüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menusil = new menusil();
            menusil.Show();
        }

        private void menüGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form menuduzenle = new menuduzenle();
            menuduzenle.Show();
        }

        private void aramaYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aramayap = new aramayap();
            aramayap.Show();
        }
    }
}
