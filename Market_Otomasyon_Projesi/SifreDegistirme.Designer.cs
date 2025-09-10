namespace Market_Otomasyon_Projesi
{
    partial class SifreDegistirme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbox_mailAlani = new System.Windows.Forms.GroupBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.txt_dogrulamaKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_dogrulamaGonder = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbox_sifreSegistirme = new System.Windows.Forms.GroupBox();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.txt_yeniSifreTkr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbox_mailAlani.SuspendLayout();
            this.grpbox_sifreSegistirme.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.btn_sorgula);
            this.groupBox1.Controls.Add(this.txt_guvenlikCevabi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbox_guvenlikSorusu);
            this.groupBox1.Controls.Add(this.txt_kullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik Sorusu İle Değiştir";
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgula.Location = new System.Drawing.Point(6, 242);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(278, 44);
            this.btn_sorgula.TabIndex = 6;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.UseVisualStyleBackColor = false;
            this.btn_sorgula.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(135, 195);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(149, 22);
            this.txt_guvenlikCevabi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güvenlik Sorusu::";
            // 
            // cmbox_guvenlikSorusu
            // 
            this.cmbox_guvenlikSorusu.FormattingEnabled = true;
            this.cmbox_guvenlikSorusu.Location = new System.Drawing.Point(135, 130);
            this.cmbox_guvenlikSorusu.Name = "cmbox_guvenlikSorusu";
            this.cmbox_guvenlikSorusu.Size = new System.Drawing.Size(149, 24);
            this.cmbox_guvenlikSorusu.TabIndex = 2;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(135, 76);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(149, 22);
            this.txt_kullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // grpbox_mailAlani
            // 
            this.grpbox_mailAlani.BackColor = System.Drawing.SystemColors.Desktop;
            this.grpbox_mailAlani.Controls.Add(this.btn_onayla);
            this.grpbox_mailAlani.Controls.Add(this.txt_dogrulamaKodu);
            this.grpbox_mailAlani.Controls.Add(this.label4);
            this.grpbox_mailAlani.Controls.Add(this.btn_dogrulamaGonder);
            this.grpbox_mailAlani.Controls.Add(this.txt_email);
            this.grpbox_mailAlani.Controls.Add(this.label6);
            this.grpbox_mailAlani.Location = new System.Drawing.Point(351, 12);
            this.grpbox_mailAlani.Name = "grpbox_mailAlani";
            this.grpbox_mailAlani.Size = new System.Drawing.Size(355, 307);
            this.grpbox_mailAlani.TabIndex = 1;
            this.grpbox_mailAlani.TabStop = false;
            this.grpbox_mailAlani.Text = "Mail İle Değiştir";
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_onayla.Location = new System.Drawing.Point(280, 162);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(69, 29);
            this.btn_onayla.TabIndex = 7;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_dogrulamaKodu
            // 
            this.txt_dogrulamaKodu.Location = new System.Drawing.Point(140, 169);
            this.txt_dogrulamaKodu.Name = "txt_dogrulamaKodu";
            this.txt_dogrulamaKodu.Size = new System.Drawing.Size(133, 22);
            this.txt_dogrulamaKodu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doğrulama Kodu:";
            // 
            // btn_dogrulamaGonder
            // 
            this.btn_dogrulamaGonder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dogrulamaGonder.Location = new System.Drawing.Point(167, 94);
            this.btn_dogrulamaGonder.Name = "btn_dogrulamaGonder";
            this.btn_dogrulamaGonder.Size = new System.Drawing.Size(182, 32);
            this.btn_dogrulamaGonder.TabIndex = 4;
            this.btn_dogrulamaGonder.Text = "Doğrulama Kodu Gönder";
            this.btn_dogrulamaGonder.UseVisualStyleBackColor = false;
            this.btn_dogrulamaGonder.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(131, 45);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(218, 22);
            this.txt_email.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email Adresiniz:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // grpbox_sifreSegistirme
            // 
            this.grpbox_sifreSegistirme.BackColor = System.Drawing.SystemColors.Desktop;
            this.grpbox_sifreSegistirme.Controls.Add(this.btn_degistir);
            this.grpbox_sifreSegistirme.Controls.Add(this.txt_yeniSifreTkr);
            this.grpbox_sifreSegistirme.Controls.Add(this.label7);
            this.grpbox_sifreSegistirme.Controls.Add(this.txt_yeniSifre);
            this.grpbox_sifreSegistirme.Controls.Add(this.label5);
            this.grpbox_sifreSegistirme.Location = new System.Drawing.Point(351, 350);
            this.grpbox_sifreSegistirme.Name = "grpbox_sifreSegistirme";
            this.grpbox_sifreSegistirme.Size = new System.Drawing.Size(355, 224);
            this.grpbox_sifreSegistirme.TabIndex = 2;
            this.grpbox_sifreSegistirme.TabStop = false;
            this.grpbox_sifreSegistirme.Text = "Şifre Değiştirme Alanı";
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_degistir.Location = new System.Drawing.Point(269, 131);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(69, 29);
            this.btn_degistir.TabIndex = 8;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.UseVisualStyleBackColor = false;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // txt_yeniSifreTkr
            // 
            this.txt_yeniSifreTkr.Location = new System.Drawing.Point(131, 87);
            this.txt_yeniSifreTkr.Name = "txt_yeniSifreTkr";
            this.txt_yeniSifreTkr.Size = new System.Drawing.Size(207, 22);
            this.txt_yeniSifreTkr.TabIndex = 7;
            this.txt_yeniSifreTkr.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Yeni Şifre Tkr";
            this.label7.UseWaitCursor = true;
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(131, 47);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.Size = new System.Drawing.Size(207, 22);
            this.txt_yeniSifre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yeni Şifre";
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 611);
            this.Controls.Add(this.grpbox_sifreSegistirme);
            this.Controls.Add(this.grpbox_mailAlani);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox_mailAlani.ResumeLayout(false);
            this.grpbox_mailAlani.PerformLayout();
            this.grpbox_sifreSegistirme.ResumeLayout(false);
            this.grpbox_sifreSegistirme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_guvenlikSorusu;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.GroupBox grpbox_mailAlani;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_dogrulamaGonder;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.TextBox txt_dogrulamaKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpbox_sifreSegistirme;
        private System.Windows.Forms.TextBox txt_yeniSifreTkr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_degistir;
    }
}