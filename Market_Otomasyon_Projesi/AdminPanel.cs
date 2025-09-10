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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString()+":";
            lbl_dakkika.Text = DateTime.Now.Minute.ToString()+":";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            KullaniciPanel kullaniciPanel = new KullaniciPanel();
            kullaniciPanel.Show();
            this.Hide();
        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            UrunPanel urun=new UrunPanel();
            urun.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
