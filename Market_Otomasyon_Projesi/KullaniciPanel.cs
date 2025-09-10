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
    public partial class KullaniciPanel : Form
    {
        Controller controller = new Controller();
        public KullaniciPanel()
        {
            InitializeComponent();
        }

        private void grpBox_kullaniciAdi_Enter(object sender, EventArgs e)
        {

        }

        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            defaultDegerleriDoldur();
            tumKullanicilariDoldur();
        }
        public void defaultDegerleriDoldur()
        {
            cmbox_yetki.Items.Add("admin");
            cmbox_yetki.Items.Add("kasiyer");
            cmbox_yetki.SelectedIndex = 0;


            cmbox_guvenlikSorusu.Items.Add("En sevdiğin hayvan");
            cmbox_guvenlikSorusu.Items.Add("en sevdiğin renk");
            cmbox_guvenlikSorusu.Items.Add("en yakın arkadaşın");
            cmbox_guvenlikSorusu.Items.Add("en sevdiğin şehir");
            cmbox_guvenlikSorusu.SelectedIndex = 0;


            cmbox_bolge.Items.Add("esenler");
            cmbox_bolge.Items.Add("üsküdar");
            cmbox_bolge.Items.Add("ataşehir");
            cmbox_bolge.Items.Add("bağcılar");
            cmbox_bolge.SelectedIndex = 0;
        }

        public void tumKullanicilariDoldur()
        {
           
            List<User> userList = controller.tumKullanicilariGetir();
            dataGridView1.DataSource = userList; 

        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifrer.Text;
            user.yetki = cmbox_yetki.SelectedItem.ToString();
            user.bolge = cmbox_bolge.SelectedItem.ToString();
            user.emailAddress = txt_emailadres.Text;
            user.guvenlikSorusu = cmbox_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;

            loginStatus sonuc = controller.kullaniciEkle(user);
            if (sonuc == loginStatus.basarili)
            {
                MessageBox.Show("Kayıt eklendi:)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource= controller.tumKullanicilariGetir();

            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifrer.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbox_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbox_bolge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_emailadres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbox_guvenlikSorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_guvenlikCevabi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id=int.Parse(txt_id.Text);
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifrer.Text;
            user.yetki = cmbox_yetki.SelectedItem.ToString();
            user.bolge = cmbox_bolge.SelectedItem.ToString();
            user.emailAddress = txt_emailadres.Text;
            user.guvenlikSorusu = cmbox_guvenlikSorusu.SelectedItem.ToString();
            user.guvenlikCevabi = txt_guvenlikCevabi.Text;
            loginStatus sonuc = controller.kullaniciGuncelle(user);
            if (sonuc == loginStatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi:)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumKullanicilariGetir();

            }
            else
            {
                MessageBox.Show("Kayıt güncellenirken bir hatta oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                loginStatus sonuc = controller.kullaniciSil(int.Parse(txt_id.Text));
                if (sonuc == loginStatus.basarili)
                {
                    MessageBox.Show("Kayıt silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumKullanicilariGetir();
                }
                else if (sonuc == loginStatus.basarisiz)
                {
                    MessageBox.Show("Kayıt silinirken bir hatta oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz kaydın id değerini girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz kaydın id değerini girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
          AdminPanel a=new AdminPanel();
            a.Show();
            this.Close();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
