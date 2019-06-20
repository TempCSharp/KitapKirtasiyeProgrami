namespace KitapKirtasiyeProgrami
{
    partial class FrmYeniUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniUrunEkle));
            this.msAnaMenu = new System.Windows.Forms.MenuStrip();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.lblUrunAciklamasi = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.lblUrunKategorisi = new System.Windows.Forms.Label();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.cmbUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.msAnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAnaMenu
            // 
            this.msAnaMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.temizleToolStripMenuItem1,
            this.kapatToolStripMenuItem});
            this.msAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.msAnaMenu.Name = "msAnaMenu";
            this.msAnaMenu.Size = new System.Drawing.Size(619, 29);
            this.msAnaMenu.TabIndex = 0;
            this.msAnaMenu.Text = "menuStrip1";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Enabled = false;
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem1
            // 
            this.temizleToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("temizleToolStripMenuItem1.Image")));
            this.temizleToolStripMenuItem1.Name = "temizleToolStripMenuItem1";
            this.temizleToolStripMenuItem1.Size = new System.Drawing.Size(89, 25);
            this.temizleToolStripMenuItem1.Text = "Temizle";
            this.temizleToolStripMenuItem1.Click += new System.EventHandler(this.temizleToolStripMenuItem1_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem.Image")));
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(16, 52);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(307, 26);
            this.txtBarkodNo.TabIndex = 2;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(12, 29);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(88, 20);
            this.lblBarkodNo.TabIndex = 1;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(16, 104);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(307, 26);
            this.txtUrunAdi.TabIndex = 4;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(12, 81);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(75, 20);
            this.lblUrunAdi.TabIndex = 3;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // txtUrunAciklamasi
            // 
            this.txtUrunAciklamasi.Location = new System.Drawing.Point(16, 156);
            this.txtUrunAciklamasi.Multiline = true;
            this.txtUrunAciklamasi.Name = "txtUrunAciklamasi";
            this.txtUrunAciklamasi.Size = new System.Drawing.Size(307, 115);
            this.txtUrunAciklamasi.TabIndex = 6;
            this.txtUrunAciklamasi.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblUrunAciklamasi
            // 
            this.lblUrunAciklamasi.AutoSize = true;
            this.lblUrunAciklamasi.Location = new System.Drawing.Point(12, 133);
            this.lblUrunAciklamasi.Name = "lblUrunAciklamasi";
            this.lblUrunAciklamasi.Size = new System.Drawing.Size(127, 20);
            this.lblUrunAciklamasi.TabIndex = 5;
            this.lblUrunAciklamasi.Text = "Ürün Açıklaması:";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(339, 104);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(264, 26);
            this.txtUrunFiyati.TabIndex = 10;
            this.txtUrunFiyati.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblUrunKategorisi
            // 
            this.lblUrunKategorisi.AutoSize = true;
            this.lblUrunKategorisi.Location = new System.Drawing.Point(335, 29);
            this.lblUrunKategorisi.Name = "lblUrunKategorisi";
            this.lblUrunKategorisi.Size = new System.Drawing.Size(122, 20);
            this.lblUrunKategorisi.TabIndex = 7;
            this.lblUrunKategorisi.Text = "Ürün Kategorisi:";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(339, 156);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(264, 26);
            this.txtStokMiktari.TabIndex = 12;
            this.txtStokMiktari.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(335, 133);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(96, 20);
            this.lblStokMiktari.TabIndex = 11;
            this.lblStokMiktari.Text = "Stok Miktarı:";
            // 
            // cmbUrunKategorisi
            // 
            this.cmbUrunKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunKategorisi.FormattingEnabled = true;
            this.cmbUrunKategorisi.Location = new System.Drawing.Point(339, 52);
            this.cmbUrunKategorisi.Name = "cmbUrunKategorisi";
            this.cmbUrunKategorisi.Size = new System.Drawing.Size(264, 28);
            this.cmbUrunKategorisi.TabIndex = 8;
            this.cmbUrunKategorisi.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Location = new System.Drawing.Point(335, 83);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(89, 20);
            this.lblUrunFiyati.TabIndex = 9;
            this.lblUrunFiyati.Text = "Ürün Fiyatı:";
            // 
            // FrmYeniUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 285);
            this.Controls.Add(this.lblUrunFiyati);
            this.Controls.Add(this.cmbUrunKategorisi);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.lblStokMiktari);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.lblUrunKategorisi);
            this.Controls.Add(this.msAnaMenu);
            this.Controls.Add(this.txtUrunAciklamasi);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblUrunAciklamasi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msAnaMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 324);
            this.MinimumSize = new System.Drawing.Size(635, 324);
            this.Name = "FrmYeniUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ürün Ekle";
            this.Load += new System.EventHandler(this.FrmYeniUrunEkle_Load);
            this.msAnaMenu.ResumeLayout(false);
            this.msAnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAciklamasi;
        private System.Windows.Forms.Label lblUrunAciklamasi;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label lblUrunKategorisi;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.ComboBox cmbUrunKategorisi;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}