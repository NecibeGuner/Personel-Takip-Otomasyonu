namespace Personel_Takip_Otomasyonu
{
    partial class frmPrimleriGoster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.btnTumPrimleriOde = new System.Windows.Forms.Button();
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(440, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "Açıklama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label4.Location = new System.Drawing.Point(425, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Prim Tutarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label3.Location = new System.Drawing.Point(80, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Personel ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label2.Location = new System.Drawing.Point(106, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Prim ID :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtAciklama.Location = new System.Drawing.Point(523, 100);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(338, 36);
            this.txtAciklama.TabIndex = 38;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtPrimTutari.Location = new System.Drawing.Point(523, 62);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(185, 26);
            this.txtPrimTutari.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(605, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label1.Location = new System.Drawing.Point(455, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Dönem :";
            // 
            // comboYil
            // 
            this.comboYil.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(626, 27);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(82, 26);
            this.comboYil.TabIndex = 34;
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
            this.comboAy.Location = new System.Drawing.Point(523, 27);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(76, 26);
            this.comboAy.TabIndex = 33;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(177, 100);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(221, 26);
            this.txtPersonelAdSoyad.TabIndex = 32;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtPersonelID.Location = new System.Drawing.Point(177, 62);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(221, 26);
            this.txtPersonelID.TabIndex = 31;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnDonemDegistir);
            this.panel1.Controls.Add(this.btnPrimSil);
            this.panel1.Controls.Add(this.btnPrimGuncelle);
            this.panel1.Controls.Add(this.btnPrimOde);
            this.panel1.Controls.Add(this.btnTumPrimleriOde);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPrimID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtPrimTutari);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboYil);
            this.panel1.Controls.Add(this.comboAy);
            this.panel1.Controls.Add(this.txtPersonelAdSoyad);
            this.panel1.Controls.Add(this.txtPersonelID);
            this.panel1.Location = new System.Drawing.Point(33, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 262);
            this.panel1.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.label6.Location = new System.Drawing.Point(32, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Personel Ad Soyad :";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.txtPrimID.Location = new System.Drawing.Point(177, 25);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(221, 26);
            this.txtPrimID.TabIndex = 43;
            // 
            // btnTumPrimleriOde
            // 
            this.btnTumPrimleriOde.Location = new System.Drawing.Point(177, 175);
            this.btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            this.btnTumPrimleriOde.Size = new System.Drawing.Size(107, 52);
            this.btnTumPrimleriOde.TabIndex = 45;
            this.btnTumPrimleriOde.Text = "Tüm Primleri Öde";
            this.btnTumPrimleriOde.UseVisualStyleBackColor = true;
            this.btnTumPrimleriOde.Click += new System.EventHandler(this.btnTumPrimleriOde_Click);
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.Location = new System.Drawing.Point(322, 175);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(107, 52);
            this.btnPrimOde.TabIndex = 46;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.UseVisualStyleBackColor = true;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.Location = new System.Drawing.Point(459, 173);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(111, 54);
            this.btnPrimGuncelle.TabIndex = 47;
            this.btnPrimGuncelle.Text = "Prim Güncelle";
            this.btnPrimGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.Location = new System.Drawing.Point(603, 173);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(111, 54);
            this.btnPrimSil.TabIndex = 48;
            this.btnPrimSil.Text = "Prim Sil";
            this.btnPrimSil.UseVisualStyleBackColor = true;
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.Location = new System.Drawing.Point(727, 28);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(134, 60);
            this.btnDonemDegistir.TabIndex = 49;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.UseVisualStyleBackColor = true;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // frmPrimleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(968, 696);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrimleriGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Personellerin Primleri";
            this.Load += new System.EventHandler(this.frmPrimleriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnTumPrimleriOde;
    }
}