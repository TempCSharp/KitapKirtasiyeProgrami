namespace KitapKirtasiyeProgrami
{
    partial class FrmKategoriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategoriler));
            this.lblKategoriAdi = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.msAnaMenu = new System.Windows.Forms.MenuStrip();
            this.yeniKategoriEKleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçilenKategoriyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.msAnaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKategoriAdi
            // 
            this.lblKategoriAdi.AutoSize = true;
            this.lblKategoriAdi.Location = new System.Drawing.Point(13, 31);
            this.lblKategoriAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategoriAdi.Name = "lblKategoriAdi";
            this.lblKategoriAdi.Size = new System.Drawing.Size(99, 20);
            this.lblKategoriAdi.TabIndex = 1;
            this.lblKategoriAdi.Text = "Kategori Adı:";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Enabled = false;
            this.txtKategoriAdi.Location = new System.Drawing.Point(14, 56);
            this.txtKategoriAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(337, 26);
            this.txtKategoriAdi.TabIndex = 2;
            this.txtKategoriAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // msAnaMenu
            // 
            this.msAnaMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKategoriEKleToolStripMenuItem,
            this.guncelleToolStripMenuItem,
            this.seçilenKategoriyiSilToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.msAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.msAnaMenu.Name = "msAnaMenu";
            this.msAnaMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msAnaMenu.Size = new System.Drawing.Size(545, 31);
            this.msAnaMenu.TabIndex = 0;
            this.msAnaMenu.Text = "menuStrip1";
            // 
            // yeniKategoriEKleToolStripMenuItem
            // 
            this.yeniKategoriEKleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniKategoriEKleToolStripMenuItem.Image")));
            this.yeniKategoriEKleToolStripMenuItem.Name = "yeniKategoriEKleToolStripMenuItem";
            this.yeniKategoriEKleToolStripMenuItem.Size = new System.Drawing.Size(161, 25);
            this.yeniKategoriEKleToolStripMenuItem.Text = "Yeni Kategori Ekle";
            this.yeniKategoriEKleToolStripMenuItem.Click += new System.EventHandler(this.yeniKategoriEKleToolStripMenuItem_Click);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Enabled = false;
            this.guncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guncelleToolStripMenuItem.Image")));
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // seçilenKategoriyiSilToolStripMenuItem
            // 
            this.seçilenKategoriyiSilToolStripMenuItem.Enabled = false;
            this.seçilenKategoriyiSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seçilenKategoriyiSilToolStripMenuItem.Image")));
            this.seçilenKategoriyiSilToolStripMenuItem.Name = "seçilenKategoriyiSilToolStripMenuItem";
            this.seçilenKategoriyiSilToolStripMenuItem.Size = new System.Drawing.Size(182, 25);
            this.seçilenKategoriyiSilToolStripMenuItem.Text = "Seçilen Kategoriyi Sil";
            this.seçilenKategoriyiSilToolStripMenuItem.Click += new System.EventHandler(this.seçilenKategoriyiSilToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem.Image")));
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.AllowUserToAddRows = false;
            this.dgvKategoriler.AllowUserToDeleteRows = false;
            this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKategoriler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKategoriler.Location = new System.Drawing.Point(12, 90);
            this.dgvKategoriler.MultiSelect = false;
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.RowHeadersVisible = false;
            this.dgvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriler.Size = new System.Drawing.Size(521, 150);
            this.dgvKategoriler.TabIndex = 3;
            this.dgvKategoriler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // FrmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 254);
            this.Controls.Add(this.dgvKategoriler);
            this.Controls.Add(this.lblKategoriAdi);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.msAnaMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(561, 293);
            this.MinimumSize = new System.Drawing.Size(561, 293);
            this.Name = "FrmKategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKategoriler_FormClosing);
            this.Load += new System.EventHandler(this.FrmKategoriler_Load);
            this.msAnaMenu.ResumeLayout(false);
            this.msAnaMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategoriAdi;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.MenuStrip msAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKategoriEKleToolStripMenuItem;
        public System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.ToolStripMenuItem seçilenKategoriyiSilToolStripMenuItem;
    }
}