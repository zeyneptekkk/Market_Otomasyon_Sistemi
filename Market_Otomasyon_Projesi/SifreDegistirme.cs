using Market_Otomasyon_Projesi.controller;
using Market_Otomasyon_Projesi.enumaration;
using Market_Otomasyon_Projesi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Otomasyon_Projesi
{
    public partial class SifreDegistirme : Form
    {
        int dogrulamaKodu;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            List<LoginTables> loginTableList= controller.getLoginTable();
            grpbox_mailAlani.Enabled = false;
            grpbox_sifreSegistirme.Enabled = false;

            foreach(LoginTables lt in loginTableList)
            {
                cmbox_guvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
            

        }

        private void grpbox_sifreDegistir_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_dogrulamaKodu.Text == dogrulamaKodu.ToString())
            {
                grpbox_sifreSegistirme.Enabled=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controler=new Controller();
            loginStatus result=controler.doAuthentication(txt_kullaniciAdi.Text.Trim().ToLower(), cmbox_guvenlikSorusu.SelectedItem.ToString(), txt_guvenlikCevabi.Text.ToLower());

            if (result == loginStatus.basarili)
            {
                grpbox_mailAlani.Enabled = true;
            }else if (result == loginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz !","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Geçersiz Parametre Gidiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller controller=new Controller();
            controller.checkEmilAddres(txt_kullaniciAdi.Text);


            Random random=new Random();
             dogrulamaKodu=random.Next(111111, 999999);

            MailAddress mailAlan = new MailAddress(txt_email.Text,"Ayşe Tek");
            MailAddress mailGonderen = new MailAddress("zeynuba56.81@gmail.com", "Zeynep Tek");
            MailMessage mesaj=new MailMessage();

            mesaj.To.Add(mailAlan);
            mesaj.From=mailGonderen;
            mesaj.Body = "Şifrenizi değiştirmek için kodunuz: "+dogrulamaKodu;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            smtp.Credentials = new System.Net.NetworkCredential("zeynuba56.81@gmail.com","zeynep56.81");
            smtp.EnableSsl = true;
            smtp.Send(mesaj);
            MessageBox.Show("Doğrulama Kodu Gönderildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (txt_yeniSifre.Text == txt_yeniSifreTkr.Text)
            {
               loginStatus result= controller.changePassword(txt_kullaniciAdi.Text,txt_yeniSifreTkr.Text);
                if (result == loginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz Değiştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gererkli Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("İki Şifre Birbirleriyle Aynı Değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);            }
        }
    }
}
