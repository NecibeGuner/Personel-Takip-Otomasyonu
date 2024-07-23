namespace Personel_Takip_Otomasyonu
{
    partial class frmMesailer
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMesaiSil = new System.Windows.Forms.Button();
            this.btnMesaiGuncelle = new System.Windows.Forms.Button();
            this.btnMesaiOde = new System.Windows.Forms.Button();
            this.btnTumMesaileriOde = new System.Windows.Forms.Button();
            this.btnPersonelMesaileri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label8.Location = new System.Drawing.Point(1043, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "/";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtAciklama.Location = new System.Drawing.Point(935, 437);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(241, 69);
            this.txtAciklama.TabIndex = 35;
            // 
            // comboYil
            // 
            this.comboYil.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(1065, 395);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(111, 29);
            this.comboYil.TabIndex = 34;
            // 
            // comboAy
            // 
            this.comboAy.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(935, 395);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(102, 29);
            this.comboAy.TabIndex = 33;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtTutar.Location = new System.Drawing.Point(935, 353);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(241, 28);
            this.txtTutar.TabIndex = 32;
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(583, 440);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(223, 28);
            this.txtMesaiSaatUcreti.TabIndex = 31;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.CustomFormat = "dd MMM yyyy";
            this.dateTimeBitis.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(583, 397);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(140, 28);
            this.dateTimeBitis.TabIndex = 29;
            this.dateTimeBitis.Value = new System.DateTime(2024, 7, 22, 0, 0, 0, 0);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.CustomFormat = "dd MMM yyyy";
            this.dateTimeBaslangic.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(583, 353);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(140, 28);
            this.dateTimeBaslangic.TabIndex = 27;
            this.dateTimeBaslangic.Value = new System.DateTime(2024, 7, 22, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label7.Location = new System.Drawing.Point(856, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label6.Location = new System.Drawing.Point(871, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Dönem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label5.Location = new System.Drawing.Point(886, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label2.Location = new System.Drawing.Point(463, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label4.Location = new System.Drawing.Point(440, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mesaai Saat Ücreti:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label11.Location = new System.Drawing.Point(127, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 18);
            this.label11.TabIndex = 47;
            this.label11.Text = "Personel ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label12.Location = new System.Drawing.Point(71, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 18);
            this.label12.TabIndex = 48;
            this.label12.Text = "Personel Adı Soyadı:";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtMesaiID.Location = new System.Drawing.Point(220, 353);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(185, 28);
            this.txtMesaiID.TabIndex = 49;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtPersonelID.Location = new System.Drawing.Point(220, 395);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(185, 28);
            this.txtPersonelID.TabIndex = 50;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(220, 437);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(185, 28);
            this.txtPersonelAdSoyad.TabIndex = 51;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageKey = "exit.png";
            this.btnCikis.Location = new System.Drawing.Point(1003, 582);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(122, 87);
            this.btnCikis.TabIndex = 58;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMesaiSil
            // 
            this.btnMesaiSil.Location = new System.Drawing.Point(722, 582);
            this.btnMesaiSil.Name = "btnMesaiSil";
            this.btnMesaiSil.Size = new System.Drawing.Size(122, 87);
            this.btnMesaiSil.TabIndex = 57;
            this.btnMesaiSil.Text = "Mesai Sil";
            this.btnMesaiSil.UseVisualStyleBackColor = true;
            this.btnMesaiSil.Click += new System.EventHandler(this.btnMesaiSil_Click);
            // 
            // btnMesaiGuncelle
            // 
            this.btnMesaiGuncelle.Location = new System.Drawing.Point(583, 582);
            this.btnMesaiGuncelle.Name = "btnMesaiGuncelle";
            this.btnMesaiGuncelle.Size = new System.Drawing.Size(122, 87);
            this.btnMesaiGuncelle.TabIndex = 56;
            this.btnMesaiGuncelle.Text = "Mesai Güncelle";
            this.btnMesaiGuncelle.UseVisualStyleBackColor = true;
            this.btnMesaiGuncelle.Click += new System.EventHandler(this.btnMesaiGuncelle_Click);
            // 
            // btnMesaiOde
            // 
            this.btnMesaiOde.Location = new System.Drawing.Point(443, 582);
            this.btnMesaiOde.Name = "btnMesaiOde";
            this.btnMesaiOde.Size = new System.Drawing.Size(122, 87);
            this.btnMesaiOde.TabIndex = 55;
            this.btnMesaiOde.Text = "Mesai Öde";
            this.btnMesaiOde.UseVisualStyleBackColor = true;
            this.btnMesaiOde.Click += new System.EventHandler(this.btnMesaiOde_Click);
            // 
            // btnTumMesaileriOde
            // 
            this.btnTumMesaileriOde.Location = new System.Drawing.Point(298, 582);
            this.btnTumMesaileriOde.Name = "btnTumMesaileriOde";
            this.btnTumMesaileriOde.Size = new System.Drawing.Size(122, 87);
            this.btnTumMesaileriOde.TabIndex = 54;
            this.btnTumMesaileriOde.Text = "Tüm Mesaileri Öde";
            this.btnTumMesaileriOde.UseVisualStyleBackColor = true;
            this.btnTumMesaileriOde.Click += new System.EventHandler(this.btnTumMesaileriOde_Click);
            // 
            // btnPersonelMesaileri
            // 
            this.btnPersonelMesaileri.Location = new System.Drawing.Point(148, 582);
            this.btnPersonelMesaileri.Name = "btnPersonelMesaileri";
            this.btnPersonelMesaileri.Size = new System.Drawing.Size(122, 87);
            this.btnPersonelMesaileri.TabIndex = 59;
            this.btnPersonelMesaileri.Text = "Personel Mesaileri";
            this.btnPersonelMesaileri.UseVisualStyleBackColor = true;
            this.btnPersonelMesaileri.Click += new System.EventHandler(this.btnPersonelMesaileri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(859, 582);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(122, 87);
            this.btnTemizle.TabIndex = 60;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 317);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label3.Location = new System.Drawing.Point(497, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Bitiş Saati:";
            // 
            // maskedTxtBitis
            // 
            this.maskedTxtBitis.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.maskedTxtBitis.Location = new System.Drawing.Point(751, 395);
            this.maskedTxtBitis.Mask = "00:00";
            this.maskedTxtBitis.Name = "maskedTxtBitis";
            this.maskedTxtBitis.Size = new System.Drawing.Size(55, 28);
            this.maskedTxtBitis.TabIndex = 30;
            this.maskedTxtBitis.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTxtBaslangic
            // 
            this.maskedTxtBaslangic.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.maskedTxtBaslangic.Location = new System.Drawing.Point(751, 353);
            this.maskedTxtBaslangic.Mask = "00:00";
            this.maskedTxtBaslangic.Name = "maskedTxtBaslangic";
            this.maskedTxtBaslangic.Size = new System.Drawing.Size(55, 28);
            this.maskedTxtBaslangic.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label1.Location = new System.Drawing.Point(133, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mesai ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label9.Location = new System.Drawing.Point(729, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 21);
            this.label9.TabIndex = 65;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.label10.Location = new System.Drawing.Point(729, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 21);
            this.label10.TabIndex = 66;
            this.label10.Text = "/";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 530);
            this.panel1.TabIndex = 67;
            // 
            // frmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1307, 737);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTxtBaslangic);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.maskedTxtBitis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMesaiSaatUcreti);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPersonelMesaileri);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMesaiSil);
            this.Controls.Add(this.btnMesaiGuncelle);
            this.Controls.Add(this.btnMesaiOde);
            this.Controls.Add(this.btnTumMesaileriOde);
            this.Controls.Add(this.panel1);
            this.Name = "frmMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMesailer";
            this.Load += new System.EventHandler(this.frmMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMesaiSil;
        private System.Windows.Forms.Button btnMesaiGuncelle;
        private System.Windows.Forms.Button btnMesaiOde;
        private System.Windows.Forms.Button btnTumMesaileriOde;
        private System.Windows.Forms.Button btnPersonelMesaileri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTxtBitis;
        private System.Windows.Forms.MaskedTextBox maskedTxtBaslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}