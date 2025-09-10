using Market_Otomasyon_Projesi.controller;
using Market_Otomasyon_Projesi.enumaration;
using Market_Otomasyon_Projesi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyon_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result = controller.login(txt_kullaniciAdi.Text, txtSifre.Text);
            if (result != null && result.status == loginStatus.basarili && result.yetki == "admin")
            {
                AdminPanel admin=new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else if (result != null && result.status == loginStatus.basarili && result.yetki == "kasiyer")
            {
                KasiyerPanel kasiyer=new KasiyerPanel();
                kasiyer.Show();
                this.Hide();
            }
            else if(result!=null && result.status == loginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Eksik Parametre Hatası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

                private void lbl_sifreUnuttum_Click(object sender, EventArgs e)
                {
                    SifreDegistirme SD = new SifreDegistirme();
                    SD.Show();
                    this.Hide();
                }
    }
}
