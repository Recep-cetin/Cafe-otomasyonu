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
    public partial class FaturaSatis : Form
    {
        public FaturaSatis()
        {
            InitializeComponent();
        }

        DataRowView AktifKayitUst;
        DataRowView AktifKayitDetay;
        public static string ad, soyad, mid;
        public static string uid, uad, barkod, fiyat;
        public static int fustid = -1;

        private void FaturaSatis_Load(object sender, EventArgs e)
        {
            //// TODO: Bu kod satırı 'cafeOtomasyonuDataSet.Urun_Tanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.urun_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Urun_Tanim);
            //// TODO: Bu kod satırı 'cafeOtomasyonuDataSet.AlisUst' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.alisUstTableAdapter.Fill(this.cafeOtomasyonuDataSet.AlisUst);
            //// TODO: Bu kod satırı 'cafeOtomasyonuDataSet.AlisDetay' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.alisDetayTableAdapter.Fill(this.cafeOtomasyonuDataSet.AlisDetay);
            Button_Kontrol(true);
            Kayitlar(-111111);
        }

        private void Kayitlar(int id)
        {

            alisDetayTableAdapter.Fill(cafeOtomasyonuDataSet.AlisDetay, id);
            alisUstTableAdapter.Fill(cafeOtomasyonuDataSet.AlisUst, id);
            GenelToplam_Bul();

        }
        private void Button_Kontrol(Boolean durum)
        {
            btnYeni.Enabled = durum;
            btnDuzelt.Enabled = durum;
            btnSil.Enabled = durum;
            btnVazgec.Enabled = !durum;
            müşteriListesiToolStripMenuItem1.Enabled = !durum;
            ürünListesiToolStripMenuItem1.Enabled = !durum;
            satırSilToolStripMenuItem.Enabled = !durum;
            vazgeçToolStripMenuItem1.Enabled = !durum;
            kaydetToolStripMenuItem1.Enabled = !durum;
            btnKaydet.Enabled = !durum;
            dtpTarih.Enabled = !durum;
            txtAd.Enabled = !durum;
            txtSoyad.Enabled = !durum;
            txtNo.Enabled = !durum;
            txtSeri.Enabled = !durum;
            txtUrun.Enabled = !durum;
            txtFiyat.Enabled = !durum;
            txtMiktar.Enabled = !durum;
            txtKdv.Enabled = !durum;
            txtTutar.Enabled = !durum;
            txtBarkod.Enabled = !durum;
            txtArama.Enabled = !durum;

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Kayitlar(-111111);
            Button_Kontrol(false);
            txtAd.Focus();
            alisUstBindingSource.AddNew();
            alisUstBindingSource.EndEdit();
            AktifKayitUst = (DataRowView)alisUstBindingSource.Current;
            AktifKayitUst["tarih"] = DateTime.Today;
        }

        private void müşteriListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mid = "-1";
            MusteriListesi.GelenForm = "Fatura Alış";

            MusteriListesi yeni = new MusteriListesi();
            yeni.ShowDialog();

            if (mid != "-1")
            {
                AktifKayitUst["ad"] = ad;
                AktifKayitUst["soyad"] = soyad;
                AktifKayitUst["mid"] = mid;
            }
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Button_Kontrol(false);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Button_Kontrol(true);
            AktifKayitUst = (DataRowView)alisUstBindingSource.Current;
            fustid = Convert.ToInt32(AktifKayitUst["fustid"].ToString());
            Kayitlar(fustid);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;

            sil = MessageBox.Show("Bu kaydı silmek istediğinizden eminmisiniz", "Silme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {

                AktifKayitUst = (DataRowView)alisUstBindingSource.Current;
                fustid = Convert.ToInt32(AktifKayitUst["fustid"].ToString());

                alisDetayTableAdapter.DeleteQuery(fustid);
                alisUstTableAdapter.DeleteQuery(fustid);

                Kayitlar(fustid);

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string fustid;
            int kayitsayisi;
            alisUstBindingSource.EndEdit();
            alisUstTableAdapter.Update(cafeOtomasyonuDataSet.AlisUst);
            cafeOtomasyonuDataSet.AlisUst.AcceptChanges();

            AktifKayitUst = (DataRowView)alisUstBindingSource.Current;
            fustid = AktifKayitUst["fustid"].ToString();
            alisDetayBindingSource.MoveFirst();
            kayitsayisi = alisDetayBindingSource.Count;
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["fustid"] = fustid;
                alisDetayBindingSource.MoveNext();
            }
            alisDetayBindingSource.EndEdit();
            alisDetayTableAdapter.Update(cafeOtomasyonuDataSet.AlisDetay);
            cafeOtomasyonuDataSet.AlisDetay.AcceptChanges();
            GenelToplam_Bul();
            Button_Kontrol(true);
        }

        private void ürünListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uid = "-1";
            UrunListesi.GelenForm = "Fatura Alış";
            UrunListesi yeni = new UrunListesi();
            yeni.ShowDialog();
            if (uid != "-1")
            {
                alisDetayBindingSource.AddNew();
                alisDetayBindingSource.EndEdit();
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["uid"] = uid;
                AktifKayitDetay["barkod"] = barkod;
                AktifKayitDetay["uadi"] = uad;
                AktifKayitDetay["fiyat"] = fiyat;
                AktifKayitDetay["tutar"] = fiyat;
                AktifKayitDetay["miktar"] = 1;
                AktifKayitDetay["kdv"] = 18;
                GenelToplam_Bul();
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus;
            basilantus = Convert.ToInt32(e.KeyChar);
            if (basilantus == 13)
            {

                if (radioButton1.Checked)
                    urun_TanimTableAdapter.AdaGore(cafeOtomasyonuDataSet.Urun_Tanim, '%' + txtArama.Text + '%');
                else
                    urun_TanimTableAdapter.BarkodaGore(cafeOtomasyonuDataSet.Urun_Tanim, '%' + txtArama.Text + '%');

                if (urunTanimBindingSource.Count == 0)
                {
                    MessageBox.Show("ürün bulunamadı");
                    txtArama.Text = "";
                    return;
                }

                DataRowView AktifKayit;
                AktifKayit = (DataRowView)urunTanimBindingSource.Current;
                alisDetayBindingSource.AddNew();
                alisDetayBindingSource.EndEdit();
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                AktifKayitDetay["uid"] = AktifKayit["uid"].ToString();
                AktifKayitDetay["barkod"] = AktifKayit["barkodu"].ToString();
                AktifKayitDetay["uadi"] = AktifKayit["uadi"].ToString();

                if (AktifKayit["afiyat"].ToString().Trim() == "")
                    AktifKayitDetay["fiyat"] = "0";
                else
                    AktifKayitDetay["fiyat"] = AktifKayit["afiyat"].ToString();

                AktifKayitDetay["tutar"] = AktifKayitDetay["fiyat"];
                AktifKayitDetay["miktar"] = 1;
                AktifKayitDetay["kdv"] = 18;
                txtArama.Text = "";
                GenelToplam_Bul();
            }
        }

        private void satırSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alisDetayBindingSource.RemoveCurrent();
            GenelToplam_Bul();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            TutarBul();

        }

		private void button6_Click(object sender, EventArgs e)
		{
            Close();
		}

		private void TutarBul()
        {
            double miktar = 0, fiyat = 0, tutar = 0;
            if (txtFiyat.Text.Trim() == "")
                fiyat = 0;
            else
                fiyat = Convert.ToDouble(txtFiyat.Text);

            if (txtMiktar.Text.Trim() == "")
                miktar = 0;
            else
                miktar = Convert.ToDouble(txtMiktar.Text);

            tutar = miktar * fiyat;
            txtTutar.Text = tutar.ToString();
            GenelToplam_Bul();


        }
        private void GenelToplam_Bul()
        {
            Double AraToplam = 0, tutar = 0, kdv = 0, ToplamKdv = 0, GenelToplam = 0;
            int kayitsayisi, sirasi;
            kayitsayisi = alisDetayBindingSource.Count;
            sirasi = alisDetayBindingSource.Position;
            alisDetayBindingSource.MoveFirst();
            for (int i = 1; i <= kayitsayisi; i++)
            {
                AktifKayitDetay = (DataRowView)alisDetayBindingSource.Current;
                if (AktifKayitDetay["tutar"].ToString().Trim() == "")
                    tutar = 0;
                else
                    tutar = Convert.ToDouble(AktifKayitDetay["tutar"].ToString());
                if (AktifKayitDetay["kdv"].ToString().Trim() == "")
                    kdv = 0;
                else
                    kdv = Convert.ToDouble(AktifKayitDetay["kdv"].ToString());
                AraToplam = AraToplam + tutar;
                kdv = tutar * kdv / 100;
                ToplamKdv = ToplamKdv + kdv;
                alisDetayBindingSource.MoveNext();

            }
            GenelToplam = AraToplam + ToplamKdv;
            label15.Text = GenelToplam.ToString();
            label16.Text = ToplamKdv.ToString();
            label17.Text = AraToplam.ToString();

            alisDetayBindingSource.Position = sirasi;


        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus;
            basilantus = Convert.ToInt32(e.KeyChar);
            if (basilantus == 13)
            {
                TutarBul();
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void faturaAlışListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaSatisListesi.GelenForm = "Fatura Alış";
            FaturaSatisListesi yeni = new FaturaSatisListesi();
            yeni.ShowDialog();
            if (fustid != -1)
            {
                Kayitlar(fustid);
            }
        }
    }
}
