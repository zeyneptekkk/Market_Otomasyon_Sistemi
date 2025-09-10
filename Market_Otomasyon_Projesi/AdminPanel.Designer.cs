namespace Market_Otomasyon_Projesi
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_dakkika = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(813, 20);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(32, 22);
            this.lbl_saniye.TabIndex = 10;
            this.lbl_saniye.Text = "00";
            // 
            // lbl_dakkika
            // 
            this.lbl_dakkika.AutoSize = true;
            this.lbl_dakkika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakkika.Location = new System.Drawing.Point(763, 20);
            this.lbl_dakkika.Name = "lbl_dakkika";
            this.lbl_dakkika.Size = new System.Drawing.Size(32, 22);
            this.lbl_dakkika.TabIndex = 9;
            this.lbl_dakkika.Text = "00";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(713, 20);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(32, 22);
            this.lbl_saat.TabIndex = 8;
            this.lbl_saat.Text = "00";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "6791549_box_new product_package_product_products_icon.ico");
            this.ımageList1.Images.SetKeyName(1, "2530819_general_group_office_personal_relation_icon.ico");
            this.ımageList1.Images.SetKeyName(2, "9104334_sign out_logout_exit_out_icon.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.ImageKey = "9104334_sign out_logout_exit_out_icon.ico";
            this.btn_cikis.ImageList = this.ımageList1;
            this.btn_cikis.Location = new System.Drawing.Point(-4, 454);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(237, 125);
            this.btn_cikis.TabIndex = 13;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_urun
            // 
            this.btn_urun.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_urun.ImageKey = "6791549_box_new product_package_product_products_icon.ico";
            this.btn_urun.ImageList = this.ımageList1;
            this.btn_urun.Location = new System.Drawing.Point(468, 107);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(273, 261);
            this.btn_urun.TabIndex = 12;
            this.btn_urun.UseVisualStyleBackColor = false;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_kullanici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kullanici.ImageKey = "2530819_general_group_office_personal_relation_icon.ico";
            this.btn_kullanici.ImageList = this.ımageList1;
            this.btn_kullanici.Location = new System.Drawing.Point(127, 107);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(261, 261);
            this.btn_kullanici.TabIndex = 11;
            this.btn_kullanici.UseVisualStyleBackColor = false;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(846, 580);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_urun);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_dakkika);
            this.Controls.Add(this.lbl_saat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_dakkika;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Timer timer1;
    }
}