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
    public partial class UrunPanel : Form
    {
        controller.Controller controller=new controller.Controller();
        public UrunPanel()
        {
            InitializeComponent();
        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            tumUrunleriGetir();
            defaultAlanlariDoldur();
        }
        public void defaultAlanlariDoldur()
        {
            cmbox_urunisim.Items.Add("Bİber");
            cmbox_urunisim.Items.Add("Domates");
            cmbox_urunisim.Items.Add("Muz");
            cmbox_urunisim.Items.Add("Salatalık");
            cmbox_urunisim.Items.Add("nar");
            cmbox_urunisim.Items.Add("Marul");
            cmbox_urunisim.Items.Add("Portakal");
            cmbox_urunisim.SelectedIndex = 0;
        }
        public void tumUrunleriGetir()
        {
            dataGridView1.DataSource = controller.tumUrunleriGetir();
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            Urun urun=new Urun();
            urun.id = int.Parse(txt_id.Text);
            urun.qrkod=txt_qrKod.Text;
            urun.barkodKod=txt_barkodKod.Text;
            urun.olusturmaTarih = dateTimePicker_olusturma.Value;
            urun.guncellenmeTarih=dateTimePicker_guncellem.Value;
            urun.urunIsim=cmbox_urunisim.SelectedItem.ToString();
            urun.kilo=int.Parse(txt_kilo.Text);
            urun.ciro=int.Parse(txt_ciro.Text);
            urun.fiyat=int.Parse(txt_fiyat.Text);

            loginStatus sonuc = controller.urunEkle(urun);

            if (sonuc == loginStatus.basarili)
            {
                MessageBox.Show("Ürün Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
            }
            else if(sonuc == loginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Eklenmedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_qrKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_barkodKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_olusturma.Value =DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            dateTimePicker_guncellem.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            cmbox_urunisim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kilo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_ciro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            
        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun=new Urun();
            urun.id = int.Parse(txt_id.Text);
            urun.qrkod = txt_qrKod.Text;
            urun.olusturmaTarih = dateTimePicker_olusturma.Value;
            urun.barkodKod = txt_barkodKod.Text;
            urun.guncellenmeTarih = dateTimePicker_guncellem.Value;
            urun.urunIsim = cmbox_urunisim.SelectedItem.ToString();
            urun.fiyat =int.Parse(txt_fiyat.Text);
            urun.kilo=int.Parse(txt_kilo.Text);
            urun.ciro = int.Parse(txt_ciro.Text);
            loginStatus sonuc= controller.urunGuncelle(urun);

            if (sonuc == loginStatus.basarili)
            {
                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               dataGridView1.DataSource=controller.tumUrunleriGetir();
            }
            else if (sonuc == loginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Güncellenmedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            loginStatus sonuc = controller.urunSil(txt_id.Text);
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
               if(sonuc == loginStatus.basarili)
                {
                    MessageBox.Show("Kayıt silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumUrunleriGetir();
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz !", "Eksik parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel a=new AdminPanel();
            a.Show();
            this.Hide();
        }
    }
}
