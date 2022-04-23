using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void müşteriTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriTanim yeni=new MusteriTanim();
            yeni.ShowDialog();
        }

        private void ürünTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunTanim yeni=new UrunTanim();
            yeni.ShowDialog();
        }

        private void firmaTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaTanim yeni=new FirmaTanim();
            yeni.ShowDialog();
        }

        private void personelTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelTanim yeni = new PersonelTanim();
            yeni.ShowDialog();
        }

        private void müşteriListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriListesi yeni = new MusteriListesi();
            yeni.ShowDialog();
        }

        private void UrunListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunListesi yeni = new UrunListesi();
            yeni.ShowDialog();
        }

        private void firmaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaListesi yeni = new FirmaListesi();
            yeni.ShowDialog();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListesi yeni = new PersonelListesi();
            yeni.ShowDialog();
        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaSatis yeni = new MasaSatis();
            yeni.ShowDialog();
        }

        private void faturaSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSatis yeni = new FaturaSatis();
            yeni.ShowDialog();
        }

        private void faturaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSatisListesi yeni = new FaturaSatisListesi();
            yeni.ShowDialog();
        }
    }
}
