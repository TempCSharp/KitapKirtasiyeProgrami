namespace KitapKirtasiyeProgrami
{
    partial class FrmUrunDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunDuzenle));
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAnaMenu = new System.Windows.Forms.MenuStrip();
            this.ürünüSİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.cmbUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.picUrunResmi = new System.Windows.Forms.PictureBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.lblUrunKategorisi = new System.Windows.Forms.Label();
            this.txtUrunAciklamasi = new System.Windows.Forms.TextBox();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.lblUrunAciklamasi = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.msAnaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUrunResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guncelleToolStripMenuItem.Image")));
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // msAnaMenu
            // 
            this.msAnaMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncelleToolStripMenuItem,
            this.ürünüSİlToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.msAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.msAnaMenu.Name = "msAnaMenu";
            this.msAnaMenu.Size = new System.Drawing.Size(620, 29);
            this.msAnaMenu.TabIndex = 0;
            this.msAnaMenu.Text = "menuStrip1";
            // 
            // ürünüSİlToolStripMenuItem
            // 
            this.ürünüSİlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünüSİlToolStripMenuItem.Image")));
            this.ürünüSİlToolStripMenuItem.Name = "ürünüSİlToolStripMenuItem";
            this.ürünüSİlToolStripMenuItem.Size = new System.Drawing.Size(125, 25);
            this.ürünüSİlToolStripMenuItem.Text = "Bu Ürünü Sil";
            this.ürünüSİlToolStripMenuItem.Click += new System.EventHandler(this.ÜrünüSİlToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem.Image")));
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Eklenme Tarihi: 12.31.2019 15:31:12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Güncelleme Tarihi: 12.31.2019 15:31:12";
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Location = new System.Drawing.Point(335, 83);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(89, 20);
            this.lblUrunFiyati.TabIndex = 11;
            this.lblUrunFiyati.Text = "Ürün Fiyatı:";
            // 
            // cmbUrunKategorisi
            // 
            this.cmbUrunKategorisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunKategorisi.FormattingEnabled = true;
            this.cmbUrunKategorisi.Location = new System.Drawing.Point(339, 52);
            this.cmbUrunKategorisi.Name = "cmbUrunKategorisi";
            this.cmbUrunKategorisi.Size = new System.Drawing.Size(264, 28);
            this.cmbUrunKategorisi.TabIndex = 10;
            // 
            // picUrunResmi
            // 
            this.picUrunResmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUrunResmi.Image = ((System.Drawing.Image)(resources.GetObject("picUrunResmi.Image")));
            this.picUrunResmi.Location = new System.Drawing.Point(339, 136);
            this.picUrunResmi.Name = "picUrunResmi";
            this.picUrunResmi.Size = new System.Drawing.Size(264, 187);
            this.picUrunResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUrunResmi.TabIndex = 44;
            this.picUrunResmi.TabStop = false;
            this.picUrunResmi.Click += new System.EventHandler(this.PicUrunResmi_Click);
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(16, 297);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(311, 26);
            this.txtStokMiktari.TabIndex = 8;
            this.txtStokMiktari.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(12, 274);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(96, 20);
            this.lblStokMiktari.TabIndex = 7;
            this.lblStokMiktari.Text = "Stok Miktarı:";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(339, 104);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(264, 26);
            this.txtUrunFiyati.TabIndex = 12;
            this.txtUrunFiyati.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
            // 
            // lblUrunKategorisi
            // 
            this.lblUrunKategorisi.AutoSize = true;
            this.lblUrunKategorisi.Location = new System.Drawing.Point(335, 29);
            this.lblUrunKategorisi.Name = "lblUrunKategorisi";
            this.lblUrunKategorisi.Size = new System.Drawing.Size(122, 20);
            this.lblUrunKategorisi.TabIndex = 9;
            this.lblUrunKategorisi.Text = "Ürün Kategorisi:";
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
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Location = new System.Drawing.Point(12, 29);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(88, 20);
            this.lblBarkodNo.TabIndex = 1;
            this.lblBarkodNo.Text = "Barkod No:";
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
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(16, 52);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(307, 26);
            this.txtBarkodNo.TabIndex = 2;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.TxtBarkodNo_TextChanged);
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
            // FrmUrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 376);
            this.Controls.Add(this.lblUrunFiyati);
            this.Controls.Add(this.cmbUrunKategorisi);
            this.Controls.Add(this.picUrunResmi);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.lblStokMiktari);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.lblUrunKategorisi);
            this.Controls.Add(this.txtUrunAciklamasi);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.lblUrunAciklamasi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msAnaMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 415);
            this.MinimumSize = new System.Drawing.Size(636, 415);
            this.Name = "FrmUrunDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünü Güncelle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUrunDuzenle_FormClosing);
            this.Load += new System.EventHandler(this.FrmUrunDuzenle_Load);
            this.msAnaMenu.ResumeLayout(false);
            this.msAnaMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUrunResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünüSİlToolStripMenuItem;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.Label lblUrunKategorisi;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.Label lblUrunAciklamasi;
        private System.Windows.Forms.Label lblUrunAdi;
        public System.Windows.Forms.ComboBox cmbUrunKategorisi;
        public System.Windows.Forms.PictureBox picUrunResmi;
        public System.Windows.Forms.TextBox txtStokMiktari;
        public System.Windows.Forms.TextBox txtUrunFiyati;
        public System.Windows.Forms.TextBox txtUrunAciklamasi;
        public System.Windows.Forms.TextBox txtBarkodNo;
        public System.Windows.Forms.TextBox txtUrunAdi;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
    }
}