using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        private int kategoriId = -1;

        private void yeniKategoriEKleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKategoriEkle frm = new FrmKategoriEkle();

            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                DgvKategorilerYenile();
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                Sabitler.MesajGoster("Kategori adını girin!");
                txtKategoriAdi.Focus();
                return;
            }

            try
            {
                var kategoriDuzenle = Sabitler.db.Kategoriler.Where(x => x.KategoriId == kategoriId).ToList();

                kategoriDuzenle[0].KategoriAdi = txtKategoriAdi.Text;
                Sabitler.db.SaveChanges();

                Sabitler.MesajGoster("Kategori adı başarıyla düzenlendi!");
                DgvKategorilerYenile();
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            kategoriId = Convert.ToInt32(dgvKategoriler.CurrentRow?.Cells[0].Value);
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow?.Cells[1].Value.ToString();
            seçilenKategoriyiSilToolStripMenuItem.Enabled = true;
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            DgvKategorilerYenile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtKategoriAdi.TextLength > 0 && kategoriId != -1)
            {
                guncelleToolStripMenuItem.Enabled = true;
                seçilenKategoriyiSilToolStripMenuItem.Enabled = true;
                txtKategoriAdi.Enabled = true;
            }
            else
            {
                guncelleToolStripMenuItem.Enabled = false;
                seçilenKategoriyiSilToolStripMenuItem.Enabled = false;
                txtKategoriAdi.Enabled = false;
            }
        }

        public void DgvKategorilerYenile()
        {
            dgvKategoriler.DataSource = Sabitler.db.Kategoriler.Select(x => new { x.KategoriId, x.KategoriAdi }).ToList();
            kategoriId = -1;
            txtKategoriAdi.Text = String.Empty;
        }

        private void FrmKategoriler_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void seçilenKategoriyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var kategoriSil = Sabitler.db.Kategoriler.FirstOrDefault(x => x.KategoriId == kategoriId);

                if (MessageBox.Show($"{kategoriSil.KategoriAdi} adlı kategori silinsin mi?", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Sabitler.db.Kategoriler.Remove(kategoriSil);
                    Sabitler.db.SaveChanges();

                    Sabitler.MesajGoster("Kategori başarıyla silindi!");
                    DgvKategorilerYenile();
                }
            }
            catch (Exception ex)
            {
                Sabitler.MesajGoster($"Bir hata oluştu\n{ ex.Message}!", true);
            }
        }
    }
}