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
    public partial class KasiyerPanel : Form
    {
        public KasiyerPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text=DateTime.Now.Hour.ToString()+"    /";
            lbl_dakkika.Text=DateTime.Now.Minute.ToString()+"  /";
            lbl_saniye.Text=DateTime.Now.Second.ToString();

        }

        private void KasiyerPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_meyveSebze_Click(object sender, EventArgs e)
        {
            MeyveSebzePanel m= new MeyveSebzePanel();
            m.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_baklagil_Click(object sender, EventArgs e)
        {

        }
    }
}
