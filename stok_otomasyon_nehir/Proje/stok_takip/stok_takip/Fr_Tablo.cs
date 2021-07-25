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
    public partial class Fr_Tablo : Form
    {
        SQL_Yardimcisi SQL_y = new SQL_Yardimcisi();
        Dilbaz dilbaz = new Dilbaz();
        string tablo_adi;
        string[] kolon_listesi;
        string[] deger_listesi;

        public Fr_Tablo(string tablo_adi)
        {
            InitializeComponent();
            this.tablo_adi = tablo_adi;
            this.Text = tablo_adi;
            this.Name = "fr_" + tablo_adi;
            kolon_listesi = SQL_y.kolon_liste_getir(tablo_adi);
            deger_listesi = new string[kolon_listesi.Length];
            for (int i = 0; i < kolon_listesi.Length; i++)
            {
                TextBox t = new TextBox();
                t.Name = "txt_" + kolon_listesi[i];
                t.Top = 25;
                t.Left = 150 + i * t.Width;
                this.Controls.Add(t);
                data_Grid.Width = (i + 1) * t.Width + 50;
                this.Width = data_Grid.Width + 150;
            }
        }

        private void fr_Tablo_Load(object sender, EventArgs e)
        {
            string Dil_ID = Properties.Settings.Default.Dil_ID.ToString();
            dilbaz.Dil_degistir(Dil_ID, this);

            SQL_y.grid_doldur(data_Grid, tablo_adi);
            SQL_y.grid_bicimlendir(data_Grid);
        }

        private void bt_Sil_Click(object sender, EventArgs e)
        {
            int secili_index = data_Grid.SelectedRows[0].Index;

            SQL_y.KayitSil(tablo_adi, data_Grid.SelectedRows[0].Cells["ID"].Value.ToString());

            SQL_y.grid_doldur(data_Grid, tablo_adi);
            if (secili_index > 0) data_Grid.Rows[secili_index - 1].Selected = true;
        }

        private void bt_Ekle_Click(object sender, EventArgs e)
        {
            degerler_doldur();
            SQL_y.Kayit_Ekle(tablo_adi, kolon_listesi, deger_listesi);

            SQL_y.grid_doldur(data_Grid, tablo_adi);
            if (data_Grid.Rows.Count > 0) data_Grid.Rows[data_Grid.Rows.Count - 1].Selected = true;
        }

        private void bt_Guncelle_Click(object sender, EventArgs e)
        {
            int secili_index = data_Grid.SelectedRows[0].Index;
            string ID = data_Grid.SelectedRows[0].Cells["ID"].Value.ToString();
            degerler_doldur();
            SQL_y.Kayit_Guncelle(tablo_adi, ID, kolon_listesi, deger_listesi);

            SQL_y.grid_doldur(data_Grid, tablo_adi);
            if (secili_index > 0) data_Grid.Rows[secili_index].Selected = true;
        }
        private void data_Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid.SelectedRows.Count > 0)
            {
                for (int i = 0; i < kolon_listesi.Length; i++)
                {
                    this.Controls["txt_" + kolon_listesi[i]].Text = data_Grid.SelectedRows[0].Cells[kolon_listesi[i]].Value.ToString();
                }

            }
        }

        private void bt_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kolon_listesi.Length; i++)
            {
                this.Controls["txt_" + kolon_listesi[i]].Text = "";
            }
        }

        private void degerler_doldur()
        {
            for (int i = 0; i < kolon_listesi.Length; i++)
            {
                deger_listesi[i] = this.Controls["txt_" + kolon_listesi[i]].Text;
            }

        }
    }
}
