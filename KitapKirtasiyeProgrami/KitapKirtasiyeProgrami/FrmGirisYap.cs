using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    public partial class FrmGirisYap : Form
    {
        public FrmGirisYap()
        {
            InitializeComponent();
        }

        private void FrmGirisYap_Load(object sender, EventArgs e)
        {
            chkBeniHatirla.Checked = Properties.Settings.Default.BeniHatirla;

            if (chkBeniHatirla.Checked)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtSifre.Text = Properties.Settings.Default.Sifre;
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                Sabitler.MesajGoster("Kullanıcı adını girin!");
                txtKullaniciAdi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtSifre.Text))
            {
                Sabitler.MesajGoster("Şifrenizi girin!");
                txtSifre.Focus();
                return;
            }

            try
            {
                var girisYapSorgu = Sabitler.db.Yonetici.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text).ToList();

                if (girisYapSorgu.Count == 1)
                {
                    if (chkBeniHatirla.Checked)
                    {
                        Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                        Properties.Settings.Default.Sifre = txtSifre.Text;
                        Properties.Settings.Default.BeniHatirla = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.KullaniciAdi = String.Empty;
                        Properties.Settings.Default.Sifre = String.Empty;
                        Properties.Settings.Default.BeniHatirla = false;
                        Properties.Settings.Default.Save();
                    }

                    Sabitler.YoneticiAdiSoyadi = $"{girisYapSorgu[0].Adi} {girisYapSorgu[0].Soyadi}";
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    Sabitler.MesajGoster("Kullanıcı adı ya da şifreniz yanlış!");
                }
            }
            catch (Exception ex)
            {
                Sabitler.MesajGoster($"Bir hata oluştu\n{ ex.Message}!", true);
            }
        }
    }
}