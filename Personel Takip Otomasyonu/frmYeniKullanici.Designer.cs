using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    partial class frmYeniKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniKullanici));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.TxtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSoru = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(206, 53);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(227, 28);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtSifre.Location = new System.Drawing.Point(206, 90);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(227, 28);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // TxtSifreTekrar
            // 
            this.TxtSifreTekrar.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.TxtSifreTekrar.Location = new System.Drawing.Point(206, 131);
            this.TxtSifreTekrar.Name = "TxtSifreTekrar";
            this.TxtSifreTekrar.Size = new System.Drawing.Size(227, 28);
            this.TxtSifreTekrar.TabIndex = 2;
            this.TxtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtAdSoyad.Location = new System.Drawing.Point(206, 171);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(227, 28);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre Tekrar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label4.Location = new System.Drawing.Point(24, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ad Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label5.Location = new System.Drawing.Point(25, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soru :";
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtCevap.Location = new System.Drawing.Point(206, 258);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(227, 56);
            this.txtCevap.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label6.Location = new System.Drawing.Point(24, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cevap :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // comboBoxSoru
            // 
            this.comboBoxSoru.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.comboBoxSoru.FormattingEnabled = true;
            this.comboBoxSoru.Items.AddRange(new object[] {
            "1) En sevdiğiniz renk nedir?",
            "2) En sevdiğiniz hayvan nedir?",
            "3) Uğurlu sayınız nedir?",
            "\t\t\t"});
            this.comboBoxSoru.Location = new System.Drawing.Point(206, 213);
            this.comboBoxSoru.Name = "comboBoxSoru";
            this.comboBoxSoru.Size = new System.Drawing.Size(227, 29);
            this.comboBoxSoru.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Eras Demi ITC", 9F);
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageKey = "kaydet.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(206, 427);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 70);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "       Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCikis.Font = new System.Drawing.Font("Eras Demi ITC", 9F);
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "exit.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(325, 427);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(108, 70);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "      Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtAciklama.Location = new System.Drawing.Point(206, 334);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(227, 56);
            this.txtAciklama.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label7.Location = new System.Drawing.Point(24, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Açıklama : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(72, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 362);
            this.panel1.TabIndex = 18;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "kaydet.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "exit.png");
            this.ımageList1.Images.SetKeyName(3, "update.png");
            // 
            // frmYeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(559, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBoxSoru);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.TxtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "frmYeniKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kullanıcı Kayıt Sayfası";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox TxtSifreTekrar;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCevap;
        private Label label6;
        private Label label1;
        private ComboBox comboBoxSoru;
        private Button btnEkle;
        private Button btnCikis;
        private TextBox txtAciklama;
        private Label label7;
        private Panel panel1;
        private ImageList ımageList1;
    }
}