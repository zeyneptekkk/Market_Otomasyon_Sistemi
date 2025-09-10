namespace Market_Otomasyon_Projesi
{
    partial class KullaniciPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBox_kullaniciAdi = new System.Windows.Forms.GroupBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbox_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_emailadres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_bolge = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbox_yetki = new System.Windows.Forms.ComboBox();
            this.txt_sifrer = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox_kullaniciAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1221, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // grpBox_kullaniciAdi
            // 
            this.grpBox_kullaniciAdi.BackColor = System.Drawing.Color.MediumVioletRed;
            this.grpBox_kullaniciAdi.Controls.Add(this.btn_geri);
            this.grpBox_kullaniciAdi.Controls.Add(this.txt_id);
            this.grpBox_kullaniciAdi.Controls.Add(this.label8);
            this.grpBox_kullaniciAdi.Controls.Add(this.btn_kayitGuncelle);
            this.grpBox_kullaniciAdi.Controls.Add(this.btn_kayitSil);
            this.grpBox_kullaniciAdi.Controls.Add(this.btn_kayitEkle);
            this.grpBox_kullaniciAdi.Controls.Add(this.txt_guvenlikCevabi);
            this.grpBox_kullaniciAdi.Controls.Add(this.label7);
            this.grpBox_kullaniciAdi.Controls.Add(this.cmbox_guvenlikSorusu);
            this.grpBox_kullaniciAdi.Controls.Add(this.label6);
            this.grpBox_kullaniciAdi.Controls.Add(this.txt_emailadres);
            this.grpBox_kullaniciAdi.Controls.Add(this.label5);
            this.grpBox_kullaniciAdi.Controls.Add(this.cmbox_bolge);
            this.grpBox_kullaniciAdi.Controls.Add(this.label4);
            this.grpBox_kullaniciAdi.Controls.Add(this.cmbox_yetki);
            this.grpBox_kullaniciAdi.Controls.Add(this.txt_sifrer);
            this.grpBox_kullaniciAdi.Controls.Add(this.txt_kullaniciAdi);
            this.grpBox_kullaniciAdi.Controls.Add(this.label3);
            this.grpBox_kullaniciAdi.Controls.Add(this.label2);
            this.grpBox_kullaniciAdi.Controls.Add(this.label1);
            this.grpBox_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBox_kullaniciAdi.Location = new System.Drawing.Point(-5, 214);
            this.grpBox_kullaniciAdi.Name = "grpBox_kullaniciAdi";
            this.grpBox_kullaniciAdi.Size = new System.Drawing.Size(1227, 549);
            this.grpBox_kullaniciAdi.TabIndex = 1;
            this.grpBox_kullaniciAdi.TabStop = false;
            this.grpBox_kullaniciAdi.Text = "Kullanıcı Pannel";
            this.grpBox_kullaniciAdi.Enter += new System.EventHandler(this.grpBox_kullaniciAdi_Enter);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.Pink;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ImageKey = "geri.ico";
            this.btn_geri.ImageList = this.ımageList1;
            this.btn_geri.Location = new System.Drawing.Point(5, 472);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(80, 68);
            this.btn_geri.TabIndex = 15;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "geri.ico");
            this.ımageList1.Images.SetKeyName(1, "4115237_add_plus_icon.ico");
            this.ımageList1.Images.SetKeyName(2, "8111405_reset_reload_refresh_sync_arrow_icon.ico");
            this.ımageList1.Images.SetKeyName(3, "8664938_trash_can_delete_remove_icon.ico");
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Pink;
            this.txt_id.Location = new System.Drawing.Point(197, 89);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(285, 30);
            this.txt_id.TabIndex = 13;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(51, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Id:";
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.BackColor = System.Drawing.Color.Pink;
            this.btn_kayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_kayitGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitGuncelle.ImageKey = "8111405_reset_reload_refresh_sync_arrow_icon.ico";
            this.btn_kayitGuncelle.ImageList = this.ımageList1;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(450, 445);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(237, 76);
            this.btn_kayitGuncelle.TabIndex = 8;
            this.btn_kayitGuncelle.Text = "Kayıt  Güncelle";
            this.btn_kayitGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitGuncelle.UseVisualStyleBackColor = false;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.BackColor = System.Drawing.Color.Pink;
            this.btn_kayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitSil.ForeColor = System.Drawing.Color.Black;
            this.btn_kayitSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitSil.ImageKey = "8664938_trash_can_delete_remove_icon.ico";
            this.btn_kayitSil.ImageList = this.ımageList1;
            this.btn_kayitSil.Location = new System.Drawing.Point(726, 445);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(222, 74);
            this.btn_kayitSil.TabIndex = 9;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitSil.UseVisualStyleBackColor = false;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.BackColor = System.Drawing.Color.Pink;
            this.btn_kayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkle.ForeColor = System.Drawing.Color.Black;
            this.btn_kayitEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitEkle.ImageKey = "4115237_add_plus_icon.ico";
            this.btn_kayitEkle.ImageList = this.ımageList1;
            this.btn_kayitEkle.Location = new System.Drawing.Point(986, 443);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(206, 74);
            this.btn_kayitEkle.TabIndex = 7;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitEkle.UseVisualStyleBackColor = false;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.BackColor = System.Drawing.Color.Pink;
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(859, 291);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(321, 30);
            this.txt_guvenlikCevabi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(666, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Güvenlik Cevabı:";
            // 
            // cmbox_guvenlikSorusu
            // 
            this.cmbox_guvenlikSorusu.BackColor = System.Drawing.Color.Pink;
            this.cmbox_guvenlikSorusu.FormattingEnabled = true;
            this.cmbox_guvenlikSorusu.Location = new System.Drawing.Point(859, 231);
            this.cmbox_guvenlikSorusu.Name = "cmbox_guvenlikSorusu";
            this.cmbox_guvenlikSorusu.Size = new System.Drawing.Size(321, 33);
            this.cmbox_guvenlikSorusu.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(663, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Güvenlik Sorusu:";
            // 
            // txt_emailadres
            // 
            this.txt_emailadres.BackColor = System.Drawing.Color.Pink;
            this.txt_emailadres.Location = new System.Drawing.Point(859, 159);
            this.txt_emailadres.Name = "txt_emailadres";
            this.txt_emailadres.Size = new System.Drawing.Size(321, 30);
            this.txt_emailadres.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(663, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email Adres:";
            // 
            // cmbox_bolge
            // 
            this.cmbox_bolge.BackColor = System.Drawing.Color.Pink;
            this.cmbox_bolge.FormattingEnabled = true;
            this.cmbox_bolge.Location = new System.Drawing.Point(859, 84);
            this.cmbox_bolge.Name = "cmbox_bolge";
            this.cmbox_bolge.Size = new System.Drawing.Size(321, 33);
            this.cmbox_bolge.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(666, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bölge:";
            this.label4.UseMnemonic = false;
            // 
            // cmbox_yetki
            // 
            this.cmbox_yetki.BackColor = System.Drawing.Color.Pink;
            this.cmbox_yetki.FormattingEnabled = true;
            this.cmbox_yetki.Location = new System.Drawing.Point(197, 299);
            this.cmbox_yetki.Name = "cmbox_yetki";
            this.cmbox_yetki.Size = new System.Drawing.Size(285, 33);
            this.cmbox_yetki.TabIndex = 2;
            // 
            // txt_sifrer
            // 
            this.txt_sifrer.BackColor = System.Drawing.Color.Pink;
            this.txt_sifrer.Location = new System.Drawing.Point(197, 227);
            this.txt_sifrer.Name = "txt_sifrer";
            this.txt_sifrer.Size = new System.Drawing.Size(285, 30);
            this.txt_sifrer.TabIndex = 1;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.BackColor = System.Drawing.Color.Pink;
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(197, 157);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(285, 30);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(53, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(51, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yetki:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(51, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 752);
            this.Controls.Add(this.grpBox_kullaniciAdi);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox_kullaniciAdi.ResumeLayout(false);
            this.grpBox_kullaniciAdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpBox_kullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifrer;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_bolge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbox_yetki;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbox_guvenlikSorusu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_emailadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.ImageList ımageList1;
    }
}