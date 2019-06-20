using System;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    public partial class FrmKategoriEkle : Form
    {
        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                Sabitler.MesajGoster("Kategori adını girin!");
                txtKategoriAdi.Focus();
                return;
            }

            try
            {
                Kategoriler kategoriEkle = new Kategoriler();
                kategoriEkle.KategoriAdi = txtKategoriAdi.Text;
                Sabitler.db.Kategoriler.Add(kategoriEkle);
                Sabitler.db.SaveChanges();

                Sabitler.MesajGoster("Kategori oluşturuldu!");
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

        private void txtKategoriAdi_TextChanged(object sender, EventArgs e)
        {
            kaydetToolStripMenuItem.Enabled = txtKategoriAdi.TextLength > 0 ? true : false;
        }

        private void FrmKategoriEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}