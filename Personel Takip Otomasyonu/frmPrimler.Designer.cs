namespace Personel_Takip_Otomasyonu
{
    partial class frmPrimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimler));
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.radioKisiyeOzelPrim = new System.Windows.Forms.RadioButton();
            this.radioTumPersonelPrim = new System.Windows.Forms.RadioButton();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersoneleGorePrimler = new System.Windows.Forms.Button();
            this.btnPrimGoster = new System.Windows.Forms.Button();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtPersonelID.Location = new System.Drawing.Point(153, 54);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(221, 26);
            this.txtPersonelID.TabIndex = 0;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(153, 91);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(221, 26);
            this.txtPersonelAdSoyad.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(252, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label1.Location = new System.Drawing.Point(85, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dönem :";
            // 
            // comboYil
            // 
            this.comboYil.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(273, 129);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(101, 26);
            this.comboYil.TabIndex = 16;
            // 
            // comboAy
            // 
            this.comboAy.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
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
            this.comboAy.Location = new System.Drawing.Point(153, 129);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(91, 26);
            this.comboAy.TabIndex = 15;
            // 
            // radioKisiyeOzelPrim
            // 
            this.radioKisiyeOzelPrim.AutoSize = true;
            this.radioKisiyeOzelPrim.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.radioKisiyeOzelPrim.Location = new System.Drawing.Point(212, 13);
            this.radioKisiyeOzelPrim.Name = "radioKisiyeOzelPrim";
            this.radioKisiyeOzelPrim.Size = new System.Drawing.Size(139, 22);
            this.radioKisiyeOzelPrim.TabIndex = 19;
            this.radioKisiyeOzelPrim.TabStop = true;
            this.radioKisiyeOzelPrim.Text = "Kişiye Özel Prim";
            this.radioKisiyeOzelPrim.UseVisualStyleBackColor = true;
            // 
            // radioTumPersonelPrim
            // 
            this.radioTumPersonelPrim.AutoSize = true;
            this.radioTumPersonelPrim.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.radioTumPersonelPrim.Location = new System.Drawing.Point(394, 13);
            this.radioTumPersonelPrim.Name = "radioTumPersonelPrim";
            this.radioTumPersonelPrim.Size = new System.Drawing.Size(181, 22);
            this.radioTumPersonelPrim.TabIndex = 20;
            this.radioTumPersonelPrim.TabStop = true;
            this.radioTumPersonelPrim.Text = "Tüm Personel İçin Prim";
            this.radioTumPersonelPrim.UseVisualStyleBackColor = true;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtPrimTutari.Location = new System.Drawing.Point(550, 54);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(221, 26);
            this.txtPrimTutari.TabIndex = 21;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(550, 86);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(221, 62);
            this.txtAciklama.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(70, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 318);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label2.Location = new System.Drawing.Point(56, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Personel ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Personel Ad Soyad :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnPersoneleGorePrimler);
            this.panel1.Controls.Add(this.btnPrimGoster);
            this.panel1.Controls.Add(this.btnPrimEkle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtPrimTutari);
            this.panel1.Controls.Add(this.radioTumPersonelPrim);
            this.panel1.Controls.Add(this.radioKisiyeOzelPrim);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboYil);
            this.panel1.Controls.Add(this.comboAy);
            this.panel1.Controls.Add(this.txtPersonelAdSoyad);
            this.panel1.Controls.Add(this.txtPersonelID);
            this.panel1.Location = new System.Drawing.Point(70, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 270);
            this.panel1.TabIndex = 26;
            // 
            // btnPersoneleGorePrimler
            // 
            this.btnPersoneleGorePrimler.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.btnPersoneleGorePrimler.Location = new System.Drawing.Point(601, 195);
            this.btnPersoneleGorePrimler.Name = "btnPersoneleGorePrimler";
            this.btnPersoneleGorePrimler.Size = new System.Drawing.Size(110, 58);
            this.btnPersoneleGorePrimler.TabIndex = 30;
            this.btnPersoneleGorePrimler.Text = "Personele Göre Prim";
            this.btnPersoneleGorePrimler.UseVisualStyleBackColor = true;
            this.btnPersoneleGorePrimler.Click += new System.EventHandler(this.btnPersoneleGorePimler);
            // 
            // btnPrimGoster
            // 
            this.btnPrimGoster.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.btnPrimGoster.Location = new System.Drawing.Point(485, 195);
            this.btnPrimGoster.Name = "btnPrimGoster";
            this.btnPrimGoster.Size = new System.Drawing.Size(110, 58);
            this.btnPrimGoster.TabIndex = 29;
            this.btnPrimGoster.Text = "Prim Göster";
            this.btnPrimGoster.UseVisualStyleBackColor = true;
            this.btnPrimGoster.Click += new System.EventHandler(this.btnPrimGoster_Click);
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.btnPrimEkle.Location = new System.Drawing.Point(369, 195);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(110, 58);
            this.btnPrimEkle.TabIndex = 28;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(467, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Açıklama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label4.Location = new System.Drawing.Point(452, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prim Tutarı :";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCikis.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 2;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(726, 629);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(138, 66);
            this.btnCikis.TabIndex = 29;
            this.btnCikis.Text = "     ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
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
            // frmPrimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(949, 707);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primler Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.RadioButton radioKisiyeOzelPrim;
        private System.Windows.Forms.RadioButton radioTumPersonelPrim;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersoneleGorePrimler;
        private System.Windows.Forms.Button btnPrimGoster;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
    }
}