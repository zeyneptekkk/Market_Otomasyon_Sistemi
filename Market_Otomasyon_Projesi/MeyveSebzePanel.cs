using AForge.Video;
using AForge.Video.DirectShow;
using Market_Otomasyon_Projesi.controller;
using Market_Otomasyon_Projesi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;




namespace Market_Otomasyon_Projesi
{
    public partial class MeyveSebzePanel : Form
    {
        int sayi1;
        int sayi2;
        int islemtip;

        public MeyveSebzePanel()
        {
            InitializeComponent();
            txt_islem.Text = "0";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_islem.Text = "0";
        }

        private void grpbox_hesapMakinasi_Enter(object sender, EventArgs e)
        {

        }

        private void grpBox_urunler_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        FilterInfoCollection fic;
        VideoCaptureDevice vcd;

        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            timer1.Start();

            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic)
            {
                cmb_kameraAc.Items.Add(camera.Name);
            }
        }

        private void secilenTus(object sender, EventArgs e)
        {
            if (txt_islem.Text == "0")
            {
                txt_islem.Text = "";

            }
            txt_islem.Text += ((Button)sender).Text;
        }

        private void btn_toplam_Click(object sender, EventArgs e)
        {
            islemtip = 1; //artıyı temsil etsin
            sayi1=int.Parse(txt_islem.Text);
            txt_islem.Text = "0";

        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemtip == 1)
            {
                sayi2=int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi2+sayi1).ToString();
            }
            else if(islemtip == 2)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text=(sayi1-sayi2).ToString();
            } else if(islemtip == 3)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }else if(islemtip == 4)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 / sayi1).ToString();
            }
                
        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {

            islemtip = 2; //eksiyi temsil etsin
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            islemtip = 3; //carpıyı temsil etsin
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            islemtip = 4; //bolmeyi temsil etsin
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text.Length != 0)
            {
                txt_islem.Text = txt_islem.Text.Substring(0, txt_islem.Text.Length - 1);
            }
            else
            {
                txt_islem.Text += "0";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        
            if (pctrBox_kamera.Image != null)
            {
                using (Bitmap bmp = new Bitmap(pctrBox_kamera.Image))
                {
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode(bmp);

                    if (result != null)
                    {
                        textBox1.Text = result.Text; // ToString yerine Text kullan
                        timer1.Stop();
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                vcd = new VideoCaptureDevice(fic[cmb_kameraAc.SelectedIndex].MonikerString);
                vcd.NewFrame += Vcd_NewFrame1;
                vcd.Start();
                timer1.Start();
           
        }

        private void btn_kameraAç_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            
            pctrBox_kamera.Image = Image.FromFile(@"C:\Users\hp\OneDrive\Masaüstü\kameraa.jpg");

        }
        private void Vcd_NewFrame1(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pctrBox_kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void cmb_kameraAc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pctrBox_kamera_Click(object sender, EventArgs e)
        {

        }

        private void pctrBox_kamera_Click_1(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controller.Controller controller = new controller.Controller();
            Urun urun = controller.urunuGetir(textBox1.Text);

            if (urun != null)
            {
                txt_islem.Text = urun.fiyat.ToString();
                lbl_urunIsimm.Text = urun.urunIsim.ToString();

                
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = @"C:\Users\hp\Downloads\barkodSesi.wav";
                ses.Load();
                ses.Play();
            }
            else
            {
                txt_islem.Text = "";
                lbl_urunIsimm.Text = "Ürün bulunamadı!";
            }
        }


        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            Form1 a=new Form1();
            a.Show();
            this.Hide();
        }

        private void lb_nar_Click(object sender, EventArgs e)
        {

        }

        private void grpBox_qr_Enter(object sender, EventArgs e)
        {

        }

        private void txt_islem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
