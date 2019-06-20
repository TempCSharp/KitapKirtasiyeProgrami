namespace KitapKirtasiyeProgrami
{
    partial class FrmAnaEkran
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaEkran));
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.lblHosGeldin = new System.Windows.Forms.Label();
            this.tmrTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.msAnaMenu = new System.Windows.Forms.MenuStrip();
            this.yeniÜrünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçilenÜrünüDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarDeğiştisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profiliDuzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbKategoriler = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ürünlerdeAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sıfırlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.msAnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToDeleteRows = false;
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUrunler.Location = new System.Drawing.Point(9, 22);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(1181, 371);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvUrunler_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUrunler);
            this.groupBox2.Location = new System.Drawing.Point(8, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ÜRÜNLER";
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.Location = new System.Drawing.Point(1084, 443);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(121, 16);
            this.lblTarihSaat.TabIndex = 3;
            this.lblTarihSaat.Text = "19.03.2019 15:05:23";
            // 
            // lblHosGeldin
            // 
            this.lblHosGeldin.AutoSize = true;
            this.lblHosGeldin.Location = new System.Drawing.Point(5, 443);
            this.lblHosGeldin.Name = "lblHosGeldin";
            this.lblHosGeldin.Size = new System.Drawing.Size(119, 16);
            this.lblHosGeldin.TabIndex = 2;
            this.lblHosGeldin.Text = "Hoş Geldin Admin!";
            // 
            // tmrTarihSaat
            // 
            this.tmrTarihSaat.Tick += new System.EventHandler(this.tmrTarihSaat_Tick);
            // 
            // msAnaMenu
            // 
            this.msAnaMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünEkleToolStripMenuItem,
            this.seçilenÜrünüDüzenleToolStripMenuItem,
            this.kategorilerToolStripMenuItem,
            this.ayarlarDeğiştisToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.cmbKategoriler,
            this.toolStripTextBox1,
            this.ürünlerdeAraToolStripMenuItem,
            this.sıfırlaToolStripMenuItem});
            this.msAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.msAnaMenu.Name = "msAnaMenu";
            this.msAnaMenu.Size = new System.Drawing.Size(1217, 33);
            this.msAnaMenu.TabIndex = 0;
            this.msAnaMenu.Text = "menuStrip1";
            // 
            // yeniÜrünEkleToolStripMenuItem
            // 
            this.yeniÜrünEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniÜrünEkleToolStripMenuItem.Image")));
            this.yeniÜrünEkleToolStripMenuItem.Name = "yeniÜrünEkleToolStripMenuItem";
            this.yeniÜrünEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.yeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle";
            this.yeniÜrünEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünEkleToolStripMenuItem_Click);
            // 
            // seçilenÜrünüDüzenleToolStripMenuItem
            // 
            this.seçilenÜrünüDüzenleToolStripMenuItem.Enabled = false;
            this.seçilenÜrünüDüzenleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seçilenÜrünüDüzenleToolStripMenuItem.Image")));
            this.seçilenÜrünüDüzenleToolStripMenuItem.Name = "seçilenÜrünüDüzenleToolStripMenuItem";
            this.seçilenÜrünüDüzenleToolStripMenuItem.Size = new System.Drawing.Size(195, 29);
            this.seçilenÜrünüDüzenleToolStripMenuItem.Text = "Seçilen Ürünü Düzenle";
            this.seçilenÜrünüDüzenleToolStripMenuItem.Click += new System.EventHandler(this.seçilenÜrünüDüzenleToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kategorilerToolStripMenuItem.Image")));
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // ayarlarDeğiştisToolStripMenuItem
            // 
            this.ayarlarDeğiştisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profiliDuzenleToolStripMenuItem});
            this.ayarlarDeğiştisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarDeğiştisToolStripMenuItem.Image")));
            this.ayarlarDeğiştisToolStripMenuItem.Name = "ayarlarDeğiştisToolStripMenuItem";
            this.ayarlarDeğiştisToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.ayarlarDeğiştisToolStripMenuItem.Text = "Ayarlar";
            // 
            // profiliDuzenleToolStripMenuItem
            // 
            this.profiliDuzenleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profiliDuzenleToolStripMenuItem.Image")));
            this.profiliDuzenleToolStripMenuItem.Name = "profiliDuzenleToolStripMenuItem";
            this.profiliDuzenleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.profiliDuzenleToolStripMenuItem.Text = "Profili Düzenle";
            this.profiliDuzenleToolStripMenuItem.Click += new System.EventHandler(this.profiliDuzenleDeğiştirToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hakkındaToolStripMenuItem.Image")));
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(175, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(175, 29);
            // 
            // ürünlerdeAraToolStripMenuItem
            // 
            this.ürünlerdeAraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ürünlerdeAraToolStripMenuItem.Image")));
            this.ürünlerdeAraToolStripMenuItem.Name = "ürünlerdeAraToolStripMenuItem";
            this.ürünlerdeAraToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.ürünlerdeAraToolStripMenuItem.Text = "Ürünlerde Ara";
            this.ürünlerdeAraToolStripMenuItem.Click += new System.EventHandler(this.ÜrünlerdeAraToolStripMenuItem_Click);
            // 
            // sıfırlaToolStripMenuItem
            // 
            this.sıfırlaToolStripMenuItem.Name = "sıfırlaToolStripMenuItem";
            this.sıfırlaToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.sıfırlaToolStripMenuItem.Text = "Sıfırla";
            this.sıfırlaToolStripMenuItem.Click += new System.EventHandler(this.SıfırlaToolStripMenuItem_Click);
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTarihSaat);
            this.Controls.Add(this.lblHosGeldin);
            this.Controls.Add(this.msAnaMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msAnaMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1233, 503);
            this.MinimumSize = new System.Drawing.Size(1233, 503);
            this.Name = "FrmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap, Kırtasiye Programı - Abdulhalik Kaya";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAnaEkran_FormClosing);
            this.Load += new System.EventHandler(this.FrmAnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.msAnaMenu.ResumeLayout(false);
            this.msAnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHosGeldin;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Timer tmrTarihSaat;
        private System.Windows.Forms.MenuStrip msAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçilenÜrünüDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarDeğiştisToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbKategoriler;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerdeAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profiliDuzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sıfırlaToolStripMenuItem;
    }
}