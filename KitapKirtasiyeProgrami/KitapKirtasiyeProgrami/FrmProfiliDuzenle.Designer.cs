namespace KitapKirtasiyeProgrami
{
    partial class FrmProfiliDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfiliDuzenle));
            this.msAnaMenu = new System.Windows.Forms.MenuStrip();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblMevcutSifre = new System.Windows.Forms.Label();
            this.txtMevcutSifre = new System.Windows.Forms.TextBox();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblYeniSifreyiOnayla = new System.Windows.Forms.Label();
            this.txtYeniSifreyiOnayla = new System.Windows.Forms.TextBox();
            this.msAnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAnaMenu
            // 
            this.msAnaMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncelleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.msAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.msAnaMenu.Name = "msAnaMenu";
            this.msAnaMenu.Size = new System.Drawing.Size(661, 29);
            this.msAnaMenu.TabIndex = 0;
            this.msAnaMenu.Text = "menuStrip1";
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guncelleToolStripMenuItem.Image")));
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(154, 25);
            this.guncelleToolStripMenuItem.Text = "Bilgileri Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kapatToolStripMenuItem.Image")));
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(329, 29);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(36, 20);
            this.lblAdi.TabIndex = 7;
            this.lblAdi.Text = "Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(333, 52);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(307, 26);
            this.txtAdi.TabIndex = 8;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(329, 81);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(61, 20);
            this.lblSoyadi.TabIndex = 9;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(333, 104);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(307, 26);
            this.txtSoyadi.TabIndex = 10;
            // 
            // lblMevcutSifre
            // 
            this.lblMevcutSifre.AutoSize = true;
            this.lblMevcutSifre.Location = new System.Drawing.Point(12, 29);
            this.lblMevcutSifre.Name = "lblMevcutSifre";
            this.lblMevcutSifre.Size = new System.Drawing.Size(101, 20);
            this.lblMevcutSifre.TabIndex = 1;
            this.lblMevcutSifre.Text = "Mevcut Şifre:";
            // 
            // txtMevcutSifre
            // 
            this.txtMevcutSifre.Location = new System.Drawing.Point(12, 52);
            this.txtMevcutSifre.Name = "txtMevcutSifre";
            this.txtMevcutSifre.PasswordChar = '*';
            this.txtMevcutSifre.Size = new System.Drawing.Size(307, 26);
            this.txtMevcutSifre.TabIndex = 2;
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(12, 81);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(82, 20);
            this.lblYeniSifre.TabIndex = 3;
            this.lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(12, 104);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(307, 26);
            this.txtYeniSifre.TabIndex = 4;
            // 
            // lblYeniSifreyiOnayla
            // 
            this.lblYeniSifreyiOnayla.AutoSize = true;
            this.lblYeniSifreyiOnayla.Location = new System.Drawing.Point(12, 133);
            this.lblYeniSifreyiOnayla.Name = "lblYeniSifreyiOnayla";
            this.lblYeniSifreyiOnayla.Size = new System.Drawing.Size(145, 20);
            this.lblYeniSifreyiOnayla.TabIndex = 5;
            this.lblYeniSifreyiOnayla.Text = "Yeni Şifreyi Onayla:";
            // 
            // txtYeniSifreyiOnayla
            // 
            this.txtYeniSifreyiOnayla.Location = new System.Drawing.Point(12, 156);
            this.txtYeniSifreyiOnayla.Name = "txtYeniSifreyiOnayla";
            this.txtYeniSifreyiOnayla.PasswordChar = '*';
            this.txtYeniSifreyiOnayla.Size = new System.Drawing.Size(307, 26);
            this.txtYeniSifreyiOnayla.TabIndex = 6;
            // 
            // FrmProfiliDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 195);
            this.Controls.Add(this.lblYeniSifreyiOnayla);
            this.Controls.Add(this.txtYeniSifreyiOnayla);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblMevcutSifre);
            this.Controls.Add(this.txtMevcutSifre);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.msAnaMenu);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(677, 234);
            this.MinimumSize = new System.Drawing.Size(677, 234);
            this.Name = "FrmProfiliDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profili Düzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProfiliDuzenle_FormClosing);
            this.Load += new System.EventHandler(this.FrmProfiliDuzenle_Load);
            this.msAnaMenu.ResumeLayout(false);
            this.msAnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label lblMevcutSifre;
        private System.Windows.Forms.TextBox txtMevcutSifre;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblYeniSifreyiOnayla;
        private System.Windows.Forms.TextBox txtYeniSifreyiOnayla;
    }
}