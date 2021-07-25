using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_takip
{
    public partial class Fr_AnaForm : Form
    {
        Dilbaz dilbaz = new Dilbaz();
        public Fr_AnaForm()
        {
            InitializeComponent();
        }

        private void Toblo_Form_Cagir(string tablo_adi)
        {
            if (Application.OpenForms["fr_" + tablo_adi] == null)
            {
                Fr_Tablo f = new Fr_Tablo(tablo_adi);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["fr_" + tablo_adi].Focus();
            }
        }

       
        private void Toblo_Form_Cagir_V2_1(string tablo_adi)
        {
            if (Application.OpenForms["fr_" + tablo_adi] == null)
            {
                Fr_TabloV2_1 f = new Fr_TabloV2_1(tablo_adi);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["fr_" + tablo_adi].Focus();
            }
        }

        private void kullanıcıToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("kullanici");
        }

        private void müşteriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("musteri");
        }

        private void ünvanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("unvan");
        }
        private void Fr_AnaForm_Load(object sender, EventArgs e)
        {
            //string Dil_ID = Properties.Settings.Default.Dil_ID.ToString();
            //dilbaz.Dil_degistir(Dil_ID, this);
            //this.Text = dilbaz.deger_getir_tag_ile(Dil_ID, this.Tag.ToString());
        }
        private void yetkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("yetki");
        }

        private void ürünKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["fr_urun_karti"] == null)
            {
                fr_urun_karti f = new fr_urun_karti("urun_karti");
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                Application.OpenForms["fr_urun_karti"].Focus();
            }
        }
        private void dilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void dilTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("dil");
        }  

        private void metinlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("metinler");
        }

        private void etiketlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("etiket");
        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("marka");
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("kategori");
        }

        private void özellikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("ozellik");
        }

        private void türüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("turu");
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("renk");
        }

        private void özelliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("ozellikler");
        }

        private void görselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("gorsel");
        }

        private void ambarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("ambar");
        }

        private void depoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("depo");
        }

        private void koridorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("koridor");
        }

        private void rafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("raf");
        }

        private void hucreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("hucre");
        }

        private void hareketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("hareket");
        }

        private void hareketTürüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("hareket_tur");
        }

        private void stokHareketiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("stok_hareket");
        }

        private void şirketBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toblo_Form_Cagir_V2_1("sirket");
        }

        private void Fr_AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
