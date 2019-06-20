using System;
using System.Linq;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    public partial class FrmProfiliDuzenle : Form
    {
        public FrmProfiliDuzenle()
        {
            InitializeComponent();
        }

        private void FrmProfiliDuzenle_Load(object sender, EventArgs e)
        {
            var yoneticiBilgileri = Sabitler.db.Yonetici.FirstOrDefault();

            txtAdi.Text = yoneticiBilgileri.Adi;
            txtSoyadi.Text = yoneticiBilgileri.Soyadi;
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMevcutSifre.Text))
            {
                Sabitler.MesajGoster("Mevcut şifrenizi girin!");
                txtSoyadi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtAdi.Text))
            {
                Sabitler.MesajGoster("Adınızı girin!");
                txtAdi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtSoyadi.Text))
            {
                Sabitler.MesajGoster("Soyadınızı girin!");
                txtSoyadi.Focus();
                return;
            }

            try
            {
                if (String.IsNullOrWhiteSpace(txtYeniSifre.Text) || String.IsNullOrWhiteSpace(txtYeniSifreyiOnayla.Text))
                {
                    var yoneticiBilgileri = Sabitler.db.Yonetici.FirstOrDefault(x => x.Sifre == txtMevcutSifre.Text);

                    if (yoneticiBilgileri != null)
                    {
                        yoneticiBilgileri.Adi = txtAdi.Text;
                        yoneticiBilgileri.Soyadi = txtSoyadi.Text;
                        Sabitler.db.SaveChanges();

                        Sabitler.MesajGoster("Bilgileriniz güncellendi!");
                    }
                    else
                    {
                        Sabitler.MesajGoster("Mevcut şifreniz yanlış!");
                    }

                    return;
                }

                if (txtYeniSifre.Text == txtYeniSifreyiOnayla.Text)
                {
                    var yoneticiBilgileri = Sabitler.db.Yonetici.FirstOrDefault(x => x.Sifre == txtMevcutSifre.Text);

                    if (yoneticiBilgileri != null)
                    {
                        yoneticiBilgileri.Adi = txtAdi.Text;
                        yoneticiBilgileri.Soyadi = txtSoyadi.Text;
                        yoneticiBilgileri.Sifre = txtYeniSifre.Text;
                        Sabitler.db.SaveChanges();

                        Sabitler.MesajGoster("Bilgileriniz ve şifreniz güncellendi!");
                    }
                    else
                    {
                        Sabitler.MesajGoster("Mevcut şifreniz yanlış!");
                    }

                    return;
                }
                else
                {
                    Sabitler.MesajGoster("Yeni şifreniz yanlış!", true);
                }
            }
            catch (Exception ex)
            {
                Sabitler.MesajGoster($"Bir hata oluştu\n{ ex.Message}!", true);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProfiliDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sabitler.YoneticiAdiSoyadi = $"{txtAdi.Text} {txtSoyadi.Text}";
            DialogResult = DialogResult.Cancel;
        }
    }
}