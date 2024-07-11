namespace Personel_Takip_Otomasyonu
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.btnDepartmanlar = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaasZamlari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepartmanlar
            // 
            this.btnDepartmanlar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDepartmanlar.Location = new System.Drawing.Point(320, 314);
            this.btnDepartmanlar.Name = "btnDepartmanlar";
            this.btnDepartmanlar.Size = new System.Drawing.Size(151, 83);
            this.btnDepartmanlar.TabIndex = 0;
            this.btnDepartmanlar.Text = "DEPARTMANLAR";
            this.btnDepartmanlar.UseVisualStyleBackColor = false;
            this.btnDepartmanlar.Click += new System.EventHandler(this.btnDepartmanlar_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnPersonelEkle.Location = new System.Drawing.Point(477, 314);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(151, 83);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "PERSONEL EKLE\r\n";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.BackColor = System.Drawing.SystemColors.Control;
            this.btnPersonelListele.Location = new System.Drawing.Point(634, 314);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(151, 83);
            this.btnPersonelListele.TabIndex = 2;
            this.btnPersonelListele.Text = "PERSONEL LİSTELE";
            this.btnPersonelListele.UseVisualStyleBackColor = false;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(371, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "PERSONEL TAKİP SİSTEMİ";
            // 
            // btnMaasZamlari
            // 
            this.btnMaasZamlari.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaasZamlari.Location = new System.Drawing.Point(320, 403);
            this.btnMaasZamlari.Name = "btnMaasZamlari";
            this.btnMaasZamlari.Size = new System.Drawing.Size(151, 83);
            this.btnMaasZamlari.TabIndex = 6;
            this.btnMaasZamlari.Text = "MAAŞ ZAMLARI";
            this.btnMaasZamlari.UseVisualStyleBackColor = false;
            this.btnMaasZamlari.Click += new System.EventHandler(this.btnMaasZamlari_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1095, 612);
            this.Controls.Add(this.btnMaasZamlari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnDepartmanlar);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepartmanlar;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaasZamlari;
    }
}

