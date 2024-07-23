namespace Personel_Takip_Otomasyonu
{
    partial class frmPersonelMesaileri
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
            this.txtAdSoyadAra = new System.Windows.Forms.TextBox();
            this.txtMesaiIDAra = new System.Windows.Forms.TextBox();
            this.txtPersonelIDAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.dataGridViewMesailer = new System.Windows.Forms.DataGridView();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtAdSoyadAra.Location = new System.Drawing.Point(829, 119);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(185, 28);
            this.txtAdSoyadAra.TabIndex = 52;
            // 
            // txtMesaiIDAra
            // 
            this.txtMesaiIDAra.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtMesaiIDAra.Location = new System.Drawing.Point(829, 51);
            this.txtMesaiIDAra.Name = "txtMesaiIDAra";
            this.txtMesaiIDAra.Size = new System.Drawing.Size(185, 28);
            this.txtMesaiIDAra.TabIndex = 53;
            this.txtMesaiIDAra.TextChanged += new System.EventHandler(this.txtMesaiIDAra_TextChanged);
            // 
            // txtPersonelIDAra
            // 
            this.txtPersonelIDAra.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.txtPersonelIDAra.Location = new System.Drawing.Point(829, 85);
            this.txtPersonelIDAra.Name = "txtPersonelIDAra";
            this.txtPersonelIDAra.Size = new System.Drawing.Size(185, 28);
            this.txtPersonelIDAra.TabIndex = 54;
            this.txtPersonelIDAra.TextChanged += new System.EventHandler(this.txtPersonelIDAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label1.Location = new System.Drawing.Point(657, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mesai ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label2.Location = new System.Drawing.Point(657, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Personel ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.label3.Location = new System.Drawing.Point(657, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Personel Adı Soyadı";
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersoneller.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(27, 28);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.RowHeadersWidth = 51;
            this.dataGridViewPersoneller.RowTemplate.Height = 24;
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(510, 217);
            this.dataGridViewPersoneller.TabIndex = 58;
            this.dataGridViewPersoneller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersoneller_CellClick);
            // 
            // dataGridViewMesailer
            // 
            this.dataGridViewMesailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesailer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewMesailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesailer.Location = new System.Drawing.Point(27, 299);
            this.dataGridViewMesailer.Name = "dataGridViewMesailer";
            this.dataGridViewMesailer.RowHeadersWidth = 51;
            this.dataGridViewMesailer.RowTemplate.Height = 24;
            this.dataGridViewMesailer.Size = new System.Drawing.Size(1032, 338);
            this.dataGridViewMesailer.TabIndex = 59;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTutar.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.lblTutar.Location = new System.Drawing.Point(710, 227);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(216, 18);
            this.lblTutar.TabIndex = 60;
            this.lblTutar.Text = "Mesai Ücreti Tutarı=4545131665";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblKayitSayisi.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.lblKayitSayisi.Location = new System.Drawing.Point(710, 187);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(179, 18);
            this.lblKayitSayisi.TabIndex = 61;
            this.lblKayitSayisi.Text = "Toplam 25 kayıt listelendi.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMesaiIDAra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblKayitSayisi);
            this.panel1.Controls.Add(this.txtPersonelIDAra);
            this.panel1.Controls.Add(this.dataGridViewMesailer);
            this.panel1.Controls.Add(this.lblTutar);
            this.panel1.Controls.Add(this.dataGridViewPersoneller);
            this.panel1.Controls.Add(this.txtAdSoyadAra);
            this.panel1.Location = new System.Drawing.Point(42, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 676);
            this.panel1.TabIndex = 62;
            // 
            // frmPersonelMesaileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1197, 732);
            this.Controls.Add(this.panel1);
            this.Name = "frmPersonelMesaileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Mesaileri";
            this.Load += new System.EventHandler(this.frmPersonelMesaileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyadAra;
        private System.Windows.Forms.TextBox txtMesaiIDAra;
        private System.Windows.Forms.TextBox txtPersonelIDAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.DataGridView dataGridViewMesailer;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Panel panel1;
    }
}