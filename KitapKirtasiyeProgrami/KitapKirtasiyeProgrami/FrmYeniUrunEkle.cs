using System;
using System.Linq;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    public partial class FrmYeniUrunEkle : Form
    {
        public FrmYeniUrunEkle()
        {
            InitializeComponent();
        }

        private void FrmYeniUrunEkle_Load(object sender, EventArgs e)
        {
            cmbUrunKategorisi.DataSource = Sabitler.db.Kategoriler.ToList();
            cmbUrunKategorisi.ValueMember = "KategoriAdi";
            cmbUrunKategorisi.SelectedIndex = -1;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void temizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtBarkodNo.Clear();
            txtUrunAdi.Clear();
            txtUrunAciklamasi.Clear();
            txtStokMiktari.Clear();
            cmbUrunKategorisi.SelectedIndex = -1;
            txtUrunFiyati.Clear();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
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
                Urunler urunEkle = new Urunler();
                urunEkle.BarkodNo = txtBarkodNo.Text;
                urunEkle.UrunAdi = txtUrunAdi.Text;
                urunEkle.UrunAciklamasi = txtUrunAciklamasi.Text;
                urunEkle.StokMiktari = Convert.ToInt32(txtStokMiktari.Text);

                var kategoriId = Sabitler.db.Kategoriler.FirstOrDefault(x => x.KategoriAdi == cmbUrunKategorisi.Text);

                urunEkle.KategoriId = kategoriId?.KategoriId;
                urunEkle.Kategoriler = kategoriId;
                urunEkle.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
                urunEkle.EklenmeTarihi = DateTime.Now;

                Sabitler.db.Urunler.Add(urunEkle);
                Sabitler.db.SaveChanges();

                Sabitler.MesajGoster("Ürün oluşturuldu!");
            }
            catch (Exception ex)
            {
                Sabitler.MesajGoster($"Bir hata oluştu\n{ ex.Message}!", true);
            }
        }

        private void TxtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.TextLength > 0 && txtUrunAdi.TextLength > 0 && txtUrunAciklamasi.TextLength > 0 && txtStokMiktari.TextLength > 0 && cmbUrunKategorisi.SelectedIndex != -1 && txtUrunFiyati.TextLength > 0)
            {
                kaydetToolStripMenuItem.Enabled = true;
            }
            else
            {
                kaydetToolStripMenuItem.Enabled = false;
            }
        }
    }
}