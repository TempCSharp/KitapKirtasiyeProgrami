using KitapKirtasiyeProgrami.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    public partial class FrmUrunDuzenle : Form
    {
        public FrmUrunDuzenle()
        {
            InitializeComponent();
        }

        public int secilenUrunId = -1;
        private string resimYolu;
        private string resimKlasoruYolu;
        private string kaynakResimYolu;

        private void FrmUrunDuzenle_Load(object sender, EventArgs e)
        {
            resimKlasoruYolu =@"Resim\";
            resimYolu = resimKlasoruYolu + secilenUrunId + ".jpg";
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                Sabitler.MesajGoster("Barkod no boş!");
                txtBarkodNo.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                Sabitler.MesajGoster("Urun adı boş!");
                txtUrunAdi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtUrunAciklamasi.Text))
            {
                Sabitler.MesajGoster("Urun açıklaması boş!");
                txtUrunAciklamasi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtStokMiktari.Text))
            {
                Sabitler.MesajGoster("Stok miktarı boş!");
                txtStokMiktari.Focus();
                return;
            }

            if (cmbUrunKategorisi.SelectedIndex == -1)
            {
                Sabitler.MesajGoster("Urun kategorisi boş!");
                cmbUrunKategorisi.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtUrunFiyati.Text))
            {
                Sabitler.MesajGoster("Urun fiyatını girin!");
                txtUrunFiyati.Focus();
                return;
            }

            try
            {
                var urunuDuzenle = Sabitler.db.Urunler.FirstOrDefault(x => x.Id == secilenUrunId);
                urunuDuzenle.BarkodNo = txtBarkodNo.Text;
                urunuDuzenle.UrunAdi = txtUrunAdi.Text;
                urunuDuzenle.UrunAciklamasi = txtUrunAciklamasi.Text;
                urunuDuzenle.StokMiktari = Convert.ToInt32(txtStokMiktari.Text);

                var kategoriId = Sabitler.db.Kategoriler.FirstOrDefault(x => x.KategoriAdi == cmbUrunKategorisi.Text);

                urunuDuzenle.KategoriId = kategoriId?.KategoriId;
                urunuDuzenle.Kategoriler = kategoriId;
                urunuDuzenle.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
                urunuDuzenle.GuncellemeTarihi = DateTime.Now;

                if (File.Exists(kaynakResimYolu))
                {
                    urunuDuzenle.UrunResmi = resimYolu;
                    File.Copy(kaynakResimYolu, AppDomain.CurrentDomain.BaseDirectory + @"Resim\" + secilenUrunId + ".jpg", true);
                }

                Sabitler.db.SaveChanges();

                Sabitler.MesajGoster("Ürün güncellendi!");
            }
            catch (Exception ex)
            {
                Sabitler.MesajGoster($"Bir hata oluştu\n{ ex.Message}!", true);
            }
        }

        private void ÜrünüSİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var urunuSil = Sabitler.db.Urunler.FirstOrDefault(x => x.Id == secilenUrunId);

                if (MessageBox.Show($"{urunuSil?.UrunAdi} adlı ürün silinsin mi?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Sabitler.db.Urunler.Remove(urunuSil);
                    Sabitler.db.SaveChanges();

                    Sabitler.MesajGoster("Ürün başarıyla silindi!");
                    Close();
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

        private void TxtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.TextLength > 0 && txtUrunAdi.TextLength > 0 && txtUrunAciklamasi.TextLength > 0 && txtStokMiktari.TextLength > 0 && cmbUrunKategorisi.SelectedIndex != -1 && txtUrunFiyati.TextLength > 0)
            {
                guncelleToolStripMenuItem.Enabled = true;
            }
            else
            {
                guncelleToolStripMenuItem.Enabled = false;
            }
        }

        private void PicUrunResmi_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog resimSec = new OpenFileDialog())
            {
                resimSec.Title = "Ürün Resmini Seçin";
                resimSec.Filter = "Resim Dosyaları(*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (resimSec.ShowDialog() == DialogResult.OK)
                {
                    kaynakResimYolu = resimSec.FileName;
                    if (!Directory.Exists(resimKlasoruYolu))
                    {
                        Directory.CreateDirectory(resimKlasoruYolu);
                    }
                    try
                    {
                        picUrunResmi.Image?.Dispose();
                        picUrunResmi.Image = File.Exists(kaynakResimYolu) ? Image.FromFile(kaynakResimYolu) : Resources.VarsayilanResim;
                    }
                    catch
                    {
                        picUrunResmi.Image = Resources.VarsayilanResim;
                    }
                }
            }
        }

        private void FrmUrunDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}