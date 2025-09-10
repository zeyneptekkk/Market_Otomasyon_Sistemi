namespace Market_Otomasyon_Projesi
{
    partial class UrunPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunPanel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_urunPanel = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_kayitGuncelle = new System.Windows.Forms.Button();
            this.btn_kayitSil = new System.Windows.Forms.Button();
            this.btn_kayitEkle = new System.Windows.Forms.Button();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_urunisim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_barkodKod = new System.Windows.Forms.TextBox();
            this.txt_qrKod = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_olusturma = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_guncellem = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_urunPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox_urunPanel
            // 
            this.groupBox_urunPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox_urunPanel.Controls.Add(this.btn_geri);
            this.groupBox_urunPanel.Controls.Add(this.txt_fiyat);
            this.groupBox_urunPanel.Controls.Add(this.dateTimePicker_guncellem);
            this.groupBox_urunPanel.Controls.Add(this.label3);
            this.groupBox_urunPanel.Controls.Add(this.dateTimePicker_olusturma);
            this.groupBox_urunPanel.Controls.Add(this.txt_id);
            this.groupBox_urunPanel.Controls.Add(this.label8);
            this.groupBox_urunPanel.Controls.Add(this.btn_kayitGuncelle);
            this.groupBox_urunPanel.Controls.Add(this.btn_kayitSil);
            this.groupBox_urunPanel.Controls.Add(this.btn_kayitEkle);
            this.groupBox_urunPanel.Controls.Add(this.txt_ciro);
            this.groupBox_urunPanel.Controls.Add(this.label7);
            this.groupBox_urunPanel.Controls.Add(this.label6);
            this.groupBox_urunPanel.Controls.Add(this.txt_kilo);
            this.groupBox_urunPanel.Controls.Add(this.label5);
            this.groupBox_urunPanel.Controls.Add(this.cmbox_urunisim);
            this.groupBox_urunPanel.Controls.Add(this.label4);
            this.groupBox_urunPanel.Controls.Add(this.txt_barkodKod);
            this.groupBox_urunPanel.Controls.Add(this.txt_qrKod);
            this.groupBox_urunPanel.Controls.Add(this.labe);
            this.groupBox_urunPanel.Controls.Add(this.label2);
            this.groupBox_urunPanel.Controls.Add(this.label1);
            this.groupBox_urunPanel.Location = new System.Drawing.Point(2, 207);
            this.groupBox_urunPanel.Name = "groupBox_urunPanel";
            this.groupBox_urunPanel.Size = new System.Drawing.Size(1233, 517);
            this.groupBox_urunPanel.TabIndex = 0;
            this.groupBox_urunPanel.TabStop = false;
            this.groupBox_urunPanel.Text = "UrunPanel";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(278, 65);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(240, 22);
            this.txt_id.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(76, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Id:";
            // 
            // btn_kayitGuncelle
            // 
            this.btn_kayitGuncelle.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_kayitGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitGuncelle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_kayitGuncelle.ImageKey = "8111405_reset_reload_refresh_sync_arrow_icon.ico";
            this.btn_kayitGuncelle.ImageList = this.ımageList1;
            this.btn_kayitGuncelle.Location = new System.Drawing.Point(946, 419);
            this.btn_kayitGuncelle.Name = "btn_kayitGuncelle";
            this.btn_kayitGuncelle.Size = new System.Drawing.Size(267, 76);
            this.btn_kayitGuncelle.TabIndex = 10;
            this.btn_kayitGuncelle.Text = "Kayıt  Güncelle";
            this.btn_kayitGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitGuncelle.UseVisualStyleBackColor = false;
            this.btn_kayitGuncelle.Click += new System.EventHandler(this.btn_kayitGuncelle_Click);
            // 
            // btn_kayitSil
            // 
            this.btn_kayitSil.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_kayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kayitSil.ImageKey = "8664938_trash_can_delete_remove_icon.ico";
            this.btn_kayitSil.ImageList = this.ımageList1;
            this.btn_kayitSil.Location = new System.Drawing.Point(946, 319);
            this.btn_kayitSil.Name = "btn_kayitSil";
            this.btn_kayitSil.Size = new System.Drawing.Size(267, 77);
            this.btn_kayitSil.TabIndex = 11;
            this.btn_kayitSil.Text = "Kayıt Sil";
            this.btn_kayitSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitSil.UseVisualStyleBackColor = false;
            this.btn_kayitSil.Click += new System.EventHandler(this.btn_kayitSil_Click);
            // 
            // btn_kayitEkle
            // 
            this.btn_kayitEkle.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_kayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitEkle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_kayitEkle.ImageKey = "4115237_add_plus_icon.ico";
            this.btn_kayitEkle.ImageList = this.ımageList1;
            this.btn_kayitEkle.Location = new System.Drawing.Point(946, 211);
            this.btn_kayitEkle.Name = "btn_kayitEkle";
            this.btn_kayitEkle.Size = new System.Drawing.Size(267, 77);
            this.btn_kayitEkle.TabIndex = 9;
            this.btn_kayitEkle.Text = "Kayıt Ekle";
            this.btn_kayitEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kayitEkle.UseVisualStyleBackColor = false;
            this.btn_kayitEkle.Click += new System.EventHandler(this.btn_kayitEkle_Click);
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(684, 313);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(227, 22);
            this.txt_ciro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(575, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ciro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(575, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fiyat:";
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(684, 159);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(227, 22);
            this.txt_kilo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(575, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kilo:.";
            // 
            // cmbox_urunisim
            // 
            this.cmbox_urunisim.FormattingEnabled = true;
            this.cmbox_urunisim.Location = new System.Drawing.Point(684, 70);
            this.cmbox_urunisim.Name = "cmbox_urunisim";
            this.cmbox_urunisim.Size = new System.Drawing.Size(227, 24);
            this.cmbox_urunisim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(576, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ürün İsim:";
            this.label4.UseMnemonic = false;
            // 
            // txt_barkodKod
            // 
            this.txt_barkodKod.Location = new System.Drawing.Point(278, 220);
            this.txt_barkodKod.Name = "txt_barkodKod";
            this.txt_barkodKod.Size = new System.Drawing.Size(240, 22);
            this.txt_barkodKod.TabIndex = 2;
            // 
            // txt_qrKod
            // 
            this.txt_qrKod.Location = new System.Drawing.Point(278, 146);
            this.txt_qrKod.Name = "txt_qrKod";
            this.txt_qrKod.Size = new System.Drawing.Size(240, 22);
            this.txt_qrKod.TabIndex = 1;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labe.ForeColor = System.Drawing.Color.DarkGreen;
            this.labe.Location = new System.Drawing.Point(76, 223);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(126, 22);
            this.labe.TabIndex = 19;
            this.labe.Text = "Barkod  Kod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(76, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Oluşturma Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(76, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "QR Kod:";
            // 
            // dateTimePicker_olusturma
            // 
            this.dateTimePicker_olusturma.Location = new System.Drawing.Point(273, 300);
            this.dateTimePicker_olusturma.Name = "dateTimePicker_olusturma";
            this.dateTimePicker_olusturma.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker_olusturma.TabIndex = 3;
            // 
            // dateTimePicker_guncellem
            // 
            this.dateTimePicker_guncellem.Location = new System.Drawing.Point(273, 369);
            this.dateTimePicker_guncellem.Name = "dateTimePicker_guncellem";
            this.dateTimePicker_guncellem.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker_guncellem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(76, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Güncelleme Tarih:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(684, 236);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(227, 22);
            this.txt_fiyat.TabIndex = 7;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ImageKey = "geri.ico";
            this.btn_geri.ImageList = this.ımageList1;
            this.btn_geri.Location = new System.Drawing.Point(0, 445);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(70, 66);
            this.btn_geri.TabIndex = 36;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "4115237_add_plus_icon.ico");
            this.ımageList1.Images.SetKeyName(1, "8111405_reset_reload_refresh_sync_arrow_icon.ico");
            this.ımageList1.Images.SetKeyName(2, "8664938_trash_can_delete_remove_icon.ico");
            this.ımageList1.Images.SetKeyName(3, "geri.ico");
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 714);
            this.Controls.Add(this.groupBox_urunPanel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunPanel";
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_urunPanel.ResumeLayout(false);
            this.groupBox_urunPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_urunPanel;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_kayitGuncelle;
        private System.Windows.Forms.Button btn_kayitSil;
        private System.Windows.Forms.Button btn_kayitEkle;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbox_urunisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_barkodKod;
        private System.Windows.Forms.TextBox txt_qrKod;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_guncellem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_olusturma;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.ImageList ımageList1;
    }
}