using KitapKirtasiyeProgrami.Properties;
using System;
using System.Data.Objects.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void tmrTarihSaat_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString("G");
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            tmrTarihSaat.Enabled = true;
            tmrTarihSaat.Interval = 1000;

            HosGeldinYenile();
            DgvUrunlerYenile();
            CmbKategorilerYenile();
        }

        private void yeniÜrünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniUrunEkle frm = new FrmYeniUrunEkle();

            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                DgvUrunlerYenile();
            }
        }

        private void seçilenÜrünüDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUrunDuzenle frm = new FrmUrunDuzenle();
                frm.cmbUrunKategorisi.DataSource = Sabitler.db.Kategoriler.ToList();
                frm.cmbUrunKategorisi.ValueMember = "KategoriAdi";
                frm.secilenUrunId = Convert.ToInt32(dgvUrunler.CurrentRow?.Cells[0].Value);
                frm.txtBarkodNo.Text = dgvUrunler.CurrentRow?.Cells[1].Value.ToString();
                frm.txtUrunAdi.Text = dgvUrunler.CurrentRow?.Cells[2].Value.ToString();
                frm.txtUrunAciklamasi.Text = dgvUrunler.CurrentRow?.Cells[3].Value.ToString();
                frm.cmbUrunKategorisi.SelectedIndex = frm.cmbUrunKategorisi.FindStringExact(dgvUrunler.CurrentRow?.Cells[4].Value.ToString());
                frm.txtUrunFiyati.Text = dgvUrunler.CurrentRow?.Cells[5].Value.ToString();
                frm.txtStokMiktari.Text = dgvUrunler.CurrentRow?.Cells[6].Value.ToString();
                frm.label7.Text = "Eklenme Tarihi: " + dgvUrunler.CurrentRow?.Cells[7].Value;
                frm.label8.Text = "Güncellenme Tarihi: " + dgvUrunler.CurrentRow?.Cells[8].Value;
                string resimYolu = AppDomain.CurrentDomain.BaseDirectory + @"Resim\" + dgvUrunler.CurrentRow?.Cells[0].Value + ".jpg";
                frm.picUrunResmi.Image = File.Exists(resimYolu) ? Image.FromFile(resimYolu) : Resources.VarsayilanResim;

                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    DgvUrunlerYenile();
                    seçilenÜrünüDüzenleToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Sabitler.MesajGoster($"Bir hata oluştu\n{ ex.Message}!", true);
            }
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();

            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                CmbKategorilerYenile();
            }
        }

        private void profiliDuzenleDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfiliDuzenle frm = new FrmProfiliDuzenle();

            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                HosGeldinYenile();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sabitler.MesajGoster("Kitap, Kırtasiye Programı v1.0\nProgramı Yazan: Abdulhalik Kaya - 16300031019");
        }

        private void HosGeldinYenile()
        {
            lblHosGeldin.Text = $"Hoş Geldin {Sabitler.YoneticiAdiSoyadi}!";
        }

        private void DgvUrunlerYenile()
        {
            dgvUrunler.DataSource = Sabitler.db.Urunler.Select(i => new { i.Id, i.BarkodNo, i.UrunAdi, i.UrunAciklamasi, i.Kategoriler.KategoriAdi, i.UrunFiyati, i.StokMiktari, i.EklenmeTarihi, i.GuncellemeTarihi }).OrderByDescending(x => x.Id).ToList();
        }

        private void CmbKategorilerYenile()
        {
            cmbKategoriler.ComboBox.DataSource = Sabitler.db.Kategoriler.ToList();
            cmbKategoriler.ComboBox.ValueMember = "KategoriAdi";
            cmbKategoriler.ComboBox.SelectedIndex = -1;
        }

        private void DgvUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            seçilenÜrünüDüzenleToolStripMenuItem.Enabled = true;
        }

        private void ÜrünlerdeAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string yazi = toolStripTextBox1.Text.ToLower();
            string kategori = cmbKategoriler.Text;

            if (String.IsNullOrWhiteSpace(yazi) && String.IsNullOrWhiteSpace(kategori))
            {
                DgvUrunlerYenile();
                return;
            }

            if (String.IsNullOrWhiteSpace(kategori))
            {
                dgvUrunler.DataSource = Sabitler.db.Urunler
                    .Where(x => SqlFunctions.StringConvert((double)x.Id).Contains(yazi) ||
                                x.BarkodNo.Contains(yazi) ||
                                x.UrunAdi.Contains(yazi) ||
                                x.UrunAciklamasi.Contains(yazi) ||
                                SqlFunctions.StringConvert((double)x.UrunFiyati).Contains(yazi) ||
                                SqlFunctions.StringConvert((double)x.StokMiktari).Contains(yazi)
                    ).Select(i => new
                    {
                        i.Id,
                        i.BarkodNo,
                        i.UrunAdi,
                        i.UrunAciklamasi,
                        i.Kategoriler.KategoriAdi,
                        i.UrunFiyati,
                        i.StokMiktari,
                        i.EklenmeTarihi,
                        i.GuncellemeTarihi
                    }).OrderByDescending(x => x.Id).ToList();
                return;
            }

            var srg = Sabitler.db.Urunler.Where(x => x.Kategoriler.KategoriAdi == kategori);

            dgvUrunler.DataSource = srg
                .Where(x => SqlFunctions.StringConvert((double)x.Id).Contains(yazi) ||
                            x.BarkodNo.Contains(yazi) ||
                            x.UrunAdi.Contains(yazi) ||
                            x.UrunAciklamasi.Contains(yazi) ||
                            SqlFunctions.StringConvert((double)x.UrunFiyati).Contains(yazi) ||
                            SqlFunctions.StringConvert((double)x.StokMiktari).Contains(yazi)
              ).Select(i => new
              {
                  i.Id,
                  i.BarkodNo,
                  i.UrunAdi,
                  i.UrunAciklamasi,
                  i.Kategoriler.KategoriAdi,
                  i.UrunFiyati,
                  i.StokMiktari,
                  i.EklenmeTarihi,
                  i.GuncellemeTarihi
              }).OrderByDescending(x => x.Id).ToList();
        }

        private void SıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbKategoriler.ComboBox.SelectedIndex = -1;
            toolStripTextBox1.Clear();
        }

        private void FrmAnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}