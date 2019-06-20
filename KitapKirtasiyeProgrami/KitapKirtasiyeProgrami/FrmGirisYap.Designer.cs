namespace KitapKirtasiyeProgrami
{
    partial class FrmGirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisYap));
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblNot = new System.Windows.Forms.Label();
            this.grpGirisYap = new System.Windows.Forms.GroupBox();
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.grpNot = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpGirisYap.SuspendLayout();
            this.grpNot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(15, 22);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(97, 20);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(15, 45);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(299, 26);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(330, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(15, 102);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(299, 26);
            this.txtSifre.TabIndex = 4;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(15, 79);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(46, 20);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnGirisYap.Image")));
            this.btnGirisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGirisYap.Location = new System.Drawing.Point(15, 134);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(299, 40);
            this.btnGirisYap.TabIndex = 5;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.ForeColor = System.Drawing.Color.Red;
            this.lblNot.Location = new System.Drawing.Point(22, 22);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(284, 20);
            this.lblNot.TabIndex = 6;
            this.lblNot.Text = "Varsayılan kulanıcı adı ve şifre admin\'dir\r\n";
            // 
            // grpGirisYap
            // 
            this.grpGirisYap.Controls.Add(this.chkBeniHatirla);
            this.grpGirisYap.Controls.Add(this.lblKullaniciAdi);
            this.grpGirisYap.Controls.Add(this.txtKullaniciAdi);
            this.grpGirisYap.Controls.Add(this.btnGirisYap);
            this.grpGirisYap.Controls.Add(this.lblSifre);
            this.grpGirisYap.Controls.Add(this.txtSifre);
            this.grpGirisYap.Location = new System.Drawing.Point(12, 138);
            this.grpGirisYap.Name = "grpGirisYap";
            this.grpGirisYap.Size = new System.Drawing.Size(330, 209);
            this.grpGirisYap.TabIndex = 0;
            this.grpGirisYap.TabStop = false;
            this.grpGirisYap.Text = "Giriş Yap";
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.AutoSize = true;
            this.chkBeniHatirla.Location = new System.Drawing.Point(144, 180);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(170, 24);
            this.chkBeniHatirla.TabIndex = 6;
            this.chkBeniHatirla.Text = "Giriş bilgilerini hatırla";
            this.chkBeniHatirla.UseVisualStyleBackColor = true;
            // 
            // grpNot
            // 
            this.grpNot.Controls.Add(this.lblNot);
            this.grpNot.Location = new System.Drawing.Point(12, 353);
            this.grpNot.Name = "grpNot";
            this.grpNot.Size = new System.Drawing.Size(330, 57);
            this.grpNot.TabIndex = 1;
            this.grpNot.TabStop = false;
            this.grpNot.Text = "NOT";
            // 
            // FrmGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 421);
            this.Controls.Add(this.grpNot);
            this.Controls.Add(this.grpGirisYap);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(374, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(374, 460);
            this.Name = "FrmGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap - Kitap, Kırtasiye Programı";
            this.Load += new System.EventHandler(this.FrmGirisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpGirisYap.ResumeLayout(false);
            this.grpGirisYap.PerformLayout();
            this.grpNot.ResumeLayout(false);
            this.grpNot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.GroupBox grpGirisYap;
        private System.Windows.Forms.GroupBox grpNot;
        private System.Windows.Forms.CheckBox chkBeniHatirla;
    }
}