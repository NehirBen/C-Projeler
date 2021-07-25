using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace stok_takip
{
    public partial class Fr_giris : Form
    {
        SQL_Yardimcisi sql_y = new SQL_Yardimcisi();
        Dilbaz dilbaz = new Dilbaz();
        string tablo_adi = "Kullanici";

        public Fr_giris()
        {
            InitializeComponent();
            DataTable dt = sql_y.Sql_Calistir_dataTable_byTablo_adi("Dil");
            cb_Dil.DataSource = dt;
            cb_Dil.DisplayMember = "adi";
            cb_Dil.ValueMember = "ID";
            cb_Dil.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void bt_giris_Click(object sender, EventArgs e)
        {
            string[] kolon_listesi = { "kullanici_adi", "sifre" };
            string[] deger_listesi = { txt_kullanici_adi.Text, txt_sifre.Text };


            if (sql_y.tablo_kontrol(tablo_adi, kolon_listesi, deger_listesi))
            {
                Fr_AnaForm f = new Fr_AnaForm();
                f.Show();
                Properties.Settings.Default.En_son_kul_adi = txt_kullanici_adi.Text;
                Properties.Settings.Default.Save();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifresi yanlış.Tekrar deneyiniz.");
                txt_kullanici_adi.Focus();
            }

        }

        //private void fr_giris_Load(object sender, EventArgs e)
        //{
        //    cb_Dil.SelectedValue = Properties.Settings.Default.Dil_ID;
        //    Dil_degistir();
        //    txt_kullanici_adi.Text = Properties.Settings.Default.En_son_kul_adi.ToString();
        //}
        private void cb_Dil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Dil.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Dil_degistir();
            }

        }

        private void Dil_degistir()
        {
            string Dil_ID = cb_Dil.SelectedValue.ToString();
            dilbaz.Dil_degistir(Dil_ID, this);
            Properties.Settings.Default.Dil_ID = (int)cb_Dil.SelectedValue;
            Properties.Settings.Default.Save();
            this.Text = dilbaz.deger_getir_tag_ile(Dil_ID, this.Tag.ToString());

        }

        private void bt_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fr_giris_Load(object sender, EventArgs e)
        {
            cb_Dil.SelectedValue = Properties.Settings.Default.Dil_ID;
            Dil_degistir();
            txt_kullanici_adi.Text = Properties.Settings.Default.En_son_kul_adi.ToString();
        }
    }
}
