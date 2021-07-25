using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace stok_takip
{
    public partial class Fr_Foto_Galeri : Form
    {
        string tablo_adi = "";
        string filtre_ID = "";

        SQL_Yardimcisi sql_y = new SQL_Yardimcisi();

        string secili_ID = "0";

        public Fr_Foto_Galeri(string tablo_adi, string filtre_ID, string Adi)
        {
            InitializeComponent();
            this.tablo_adi = tablo_adi;
            this.filtre_ID = filtre_ID;
            this.Name = "fr_" + filtre_ID;
            this.Text = Adi;
        }

        private void fr_Foto_Galeri_Load(object sender, EventArgs e)
        {
            doldur();

        }

        private void doldur()
        {
            if (this.Controls.Count > 3)
            {
                int adet = this.Controls.Count;
                for (int i = adet; i > 3; i--)
                {
                    this.Controls[i - 1].Dispose();
                }
            }
            string sql_metni = "Select * From " + tablo_adi + "_Gorsel Where " + tablo_adi + "_ID=" + filtre_ID;
            DataTable dt = sql_y.Sql_Calistir_dataTable_bySQL(sql_metni);

            int sayac = 0;
            int sayac2 = 0;
            foreach (DataRow satir in dt.Rows)
            {
                PictureBox b = new PictureBox();
                b.Name = "pc_" + satir[0].ToString();
                b.Load(@"Gorsel/" + tablo_adi + "/" + satir[2].ToString());
                b.Tag = satir[0].ToString();
                b.Size = new System.Drawing.Size(100, 100);
                b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                int soldan = 30;
                int ustten = 330;
                if (sayac >= 4)
                {
                    sayac = 0;
                    sayac2++;
                    this.Height += 100;

                }
                soldan = (30 + b.Width) * sayac + 30;
                ustten = (30 + b.Height) * sayac2 + 330;

                b.Location = new System.Drawing.Point(soldan, ustten);
                b.TabIndex = sayac;


                b.Click += new System.EventHandler(this.pictureBox_Click);
                sayac++;
                this.Controls.Add(b);

            }
            if (this.Controls.Count > 3)
            {
                pc_Buyuk.ImageLocation = ((PictureBox)this.Controls[3]).ImageLocation;
                secili_ID = ((PictureBox)this.Controls[3]).Tag.ToString();

            }


        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pc_Buyuk.ImageLocation = ((PictureBox)sender).ImageLocation;
            secili_ID = ((PictureBox)sender).Tag.ToString();
        }

        private void bt_Ekle_Click(object sender, EventArgs e)
        {
            string kaynakDosya = "", kaynakDosyaIsmi = "", hedefKlasor = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG Dosyalar(*.JPG)| *.JPG";
            openFileDialog1.Title = "Fotograf Seçiniz";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.FileName);
                kaynakDosyaIsmi = openFileDialog1.SafeFileName.ToString();
                kaynakDosya = openFileDialog1.FileName.ToString();
                //textBox1.Text = kaynakDosya;
                hedefKlasor = "Gorsel\\" + tablo_adi + "";
                if (File.Exists(hedefKlasor + "\\" + filtre_ID + "_" + kaynakDosyaIsmi))
                {
                    MessageBox.Show("Belirtilen klasörde " + kaynakDosyaIsmi + " isimli dosya zaten mevcut...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(kaynakDosya, hedefKlasor + "\\" + filtre_ID + "_" + kaynakDosyaIsmi);
                }
                string[] kolon_listesi = { tablo_adi + "_ID", "adi" };
                string[] deger_listesi = { filtre_ID, filtre_ID + "_" + kaynakDosyaIsmi };
                sql_y.Kayit_Ekle(tablo_adi + "_Gorsel", kolon_listesi, deger_listesi);
                doldur();

                pc_Buyuk.ImageLocation = ((PictureBox)this.Controls[this.Controls.Count - 1]).ImageLocation;
                secili_ID = ((PictureBox)this.Controls[this.Controls.Count - 1]).Tag.ToString();
            }
        }

        private void bt_Sil_Click(object sender, EventArgs e)
        {
            sql_y.KayitSil(tablo_adi + "_Gorsel", secili_ID);
            string silinecek_dosya = pc_Buyuk.ImageLocation.ToString();
            doldur();
            File.Delete(silinecek_dosya);
        }
    }
}
