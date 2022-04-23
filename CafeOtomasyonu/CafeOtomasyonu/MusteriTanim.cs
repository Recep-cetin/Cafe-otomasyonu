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
    public partial class MusteriTanim : Form
    {
        public MusteriTanim()
        {
            InitializeComponent();
        }

        private void MusteriTanim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeOtomasyonuDataSet.MusteriTanim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteri_TanimTableAdapter.Fill(this.cafeOtomasyonuDataSet.Musteri_Tanim);
            Buton_Kontrol(false);
        }
        private void Buton_Kontrol(bool durum)
        {
            TxtMadi.Enabled = durum;
            TxtMsoyadi.Enabled = durum;
            TxtMtelefon.Enabled = durum;
            TxtAdres.Enabled = durum;
            BtnYeni.Enabled = !durum;
            BtnDuzelt.Enabled = !durum;
            BtnSil.Enabled = !durum;
            BtnVazgec.Enabled = durum;
            BtnKaydet.Enabled = durum;
        }
        private void BtnYeni_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.AddNew();
            Buton_Kontrol(true);
        }

        private void BtnDuzelt_Click(object sender, EventArgs e)
        {
            Buton_Kontrol(true);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.CancelEdit();
            Buton_Kontrol(false);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil;
            sil = MessageBox.Show("Kayıt silinsin mi ?", "silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                musteriTanimBindingSource.RemoveCurrent();
                musteri_TanimTableAdapter.Update(cafeOtomasyonuDataSet.Musteri_Tanim);
                cafeOtomasyonuDataSet.AcceptChanges();
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.EndEdit();
            musteri_TanimTableAdapter.Update(cafeOtomasyonuDataSet.Musteri_Tanim);
            cafeOtomasyonuDataSet.AcceptChanges();
            Buton_Kontrol(false);
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            if (RbnAdaGore.Checked)
                musteri_TanimTableAdapter.AdaGore(cafeOtomasyonuDataSet.Musteri_Tanim, '%' + TxtArama.Text + '%');
            else if (RbnSoyadaGore.Checked)
                musteri_TanimTableAdapter.SoyadaGore(cafeOtomasyonuDataSet.Musteri_Tanim, '%' + TxtArama.Text + '%');
            else
                musteri_TanimTableAdapter.Arama(cafeOtomasyonuDataSet.Musteri_Tanim, '%' + TxtArama.Text + '%');
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MoveNext();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MovePrevious();
        }

        private void BtnIlkKayit_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MoveFirst();
        }

        private void BtnSonKayit_Click(object sender, EventArgs e)
        {
            musteriTanimBindingSource.MoveLast();
        }
    }
}
