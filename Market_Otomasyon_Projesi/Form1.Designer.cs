namespace Market_Otomasyon_Projesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_sifreUnuttum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(371, 96);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(194, 32);
            this.lbl_kullaniciAdi.TabIndex = 1;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı:";
            this.lbl_kullaniciAdi.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(610, 90);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(303, 38);
            this.txt_kullaniciAdi.TabIndex = 2;
            this.txt_kullaniciAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(381, 179);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(87, 32);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(610, 176);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(303, 38);
            this.txtSifre.TabIndex = 4;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giris.ImageKey = "login.ico";
            this.btn_giris.ImageList = this.ımageList1;
            this.btn_giris.Location = new System.Drawing.Point(676, 344);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(223, 73);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login.ico");
            this.ımageList1.Images.SetKeyName(1, "1343434_avatar_circle_face_human_profile_icon.ico");
            // 
            // lbl_sifreUnuttum
            // 
            this.lbl_sifreUnuttum.AutoSize = true;
            this.lbl_sifreUnuttum.BackColor = System.Drawing.Color.Tan;
            this.lbl_sifreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifreUnuttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_sifreUnuttum.Location = new System.Drawing.Point(381, 365);
            this.lbl_sifreUnuttum.Name = "lbl_sifreUnuttum";
            this.lbl_sifreUnuttum.Size = new System.Drawing.Size(232, 32);
            this.lbl_sifreUnuttum.TabIndex = 6;
            this.lbl_sifreUnuttum.Text = "Şifremi Unuttum";
            this.lbl_sifreUnuttum.Click += new System.EventHandler(this.lbl_sifreUnuttum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(934, 529);
            this.Controls.Add(this.lbl_sifreUnuttum);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.lbl_kullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lbl_sifreUnuttum;
    }
}

