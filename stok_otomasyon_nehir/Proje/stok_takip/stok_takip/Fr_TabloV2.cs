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
    public partial class Fr_TabloV2 : Form
    {
        SQL_Yardimcisi SQL_y = new SQL_Yardimcisi();
        Dilbaz dilbaz = new Dilbaz();
        string tablo_adi;
        string Sql_metni;
        string[] kolon_listesi;
        string[] deger_listesi;

        public Fr_TabloV2(string tablo_adi)
        {
            InitializeComponent();
            this.tablo_adi = tablo_adi;
            List<string> yabanci_tablo = new List<string>();


            //this.Sql_metni = Sql_metni;
            this.Text = tablo_adi;
            this.Name = "fr_" + tablo_adi;
            kolon_listesi = SQL_y.kolon_liste_getir(tablo_adi);
            deger_listesi = new string[kolon_listesi.Length];
            for (int i = 0; i < kolon_listesi.Length; i++)
            {
                Control o;
                if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_ID")
                {
                    ComboBox c = new ComboBox();
                    c.Name = "cb_" + kolon_listesi[i];
                    c.Top = 25;
                    c.Width = 100;
                    c.Left = 150 + i * c.Width;
                    c.DropDownStyle = ComboBoxStyle.DropDownList;
                    o = c;
                    string cb_tablo_adi = kolon_listesi[i].Substring(0, kolon_listesi[i].Length - 3);
                    c.DataSource = SQL_y.Sql_Calistir_dataTable_byTablo_adi(cb_tablo_adi);
                    c.DisplayMember = "Adi";
                    c.ValueMember = "ID";
                    yabanci_tablo.Add(cb_tablo_adi);
                }
                else if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_mi")
                {
                    CheckBox c = new CheckBox();
                    c.Name = "chb_" + kolon_listesi[i];
                    c.Text = kolon_listesi[i];
                    c.Top = 25;
                    c.Left = 150 + i * c.Width;
                    c.Width = 70;
                    o = c;
                }
                else
                {
                    TextBox t = new TextBox();
                    t.Name = "txt_" + kolon_listesi[i];
                    t.Top = 25;
                    t.Left = 150 + i * t.Width;
                    o = t;
                }

                this.Controls.Add(o);
                data_Grid.Width = (i + 1) * o.Width + 50;
                this.Width = data_Grid.Width + 150;




            }
            if (yabanci_tablo.Count > 0)
            {
                string select_bolumu = " SELECT ";
                string From_bolumu = " FROM ";
                for (int i = 0; i < yabanci_tablo.Count; i++)
                    select_bolumu += yabanci_tablo[i] + ".Adi AS " + yabanci_tablo[i] + ",";
                select_bolumu += " " + tablo_adi + ".* ";
                for (int i = 0; i < yabanci_tablo.Count; i++)
                    From_bolumu += "(";
                From_bolumu += tablo_adi + " ";
                for (int i = 0; i < yabanci_tablo.Count; i++)
                    From_bolumu += " LEFT OUTER JOIN " + yabanci_tablo[i] + " ON " + tablo_adi + "." + yabanci_tablo[i] + "_ID = " + yabanci_tablo[i] + ".ID) ";

                this.Sql_metni = select_bolumu + From_bolumu;
            }
            else
            {
                this.Sql_metni = "Select * From " + tablo_adi;
            }

        }
        private void fr_Tablo_Load(object sender, EventArgs e)
        {
            SQL_y.grid_doldur_V2(data_Grid, Sql_metni);
            SQL_y.grid_bicimlendir(data_Grid);
            string Dil_ID = Properties.Settings.Default.Dil_ID.ToString();
            dilbaz.Dil_degistir(Dil_ID, this);
        }

        private void bt_Sil_Click(object sender, EventArgs e)
        {
            int secili_index = data_Grid.SelectedRows[0].Index;

            SQL_y.KayitSil(tablo_adi, data_Grid.SelectedRows[0].Cells["ID"].Value.ToString());

            SQL_y.grid_doldur_V2(data_Grid, Sql_metni);
            if (secili_index > 0) data_Grid.Rows[secili_index - 1].Selected = true;
        }

        private void bt_Ekle_Click(object sender, EventArgs e)
        {
            degerler_doldur();
            SQL_y.Kayit_Ekle(tablo_adi, kolon_listesi, deger_listesi);

            SQL_y.grid_doldur_V2(data_Grid, Sql_metni);
            if (data_Grid.Rows.Count > 0) data_Grid.Rows[data_Grid.Rows.Count - 1].Selected = true;
        }

        private void bt_Guncelle_Click(object sender, EventArgs e)
        {
            int secili_index = data_Grid.SelectedRows[0].Index;
            string ID = data_Grid.SelectedRows[0].Cells["ID"].Value.ToString();
            degerler_doldur();
            SQL_y.Kayit_Guncelle(tablo_adi, ID, kolon_listesi, deger_listesi);

            SQL_y.grid_doldur_V2(data_Grid, Sql_metni);
            if (secili_index > 0) data_Grid.Rows[secili_index].Selected = true;
        }
        private void data_Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (data_Grid.SelectedRows.Count > 0)
            {
                for (int i = 0; i < kolon_listesi.Length; i++)
                {
                    if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_ID")
                    {
                        try
                        {
                            ((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).SelectedValue = data_Grid.SelectedRows[0].Cells[kolon_listesi[i]].Value.ToString();
                        }
                        catch (Exception)
                        {
                            // ((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).Text = ((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).Items[0].ToString();
                            ((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).SelectedValue = 1;
                            ((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).SelectedValue = 0;

                        }


                        // 

                    }
                    else if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_mi")
                    {

                        ((CheckBox)this.Controls["chb_" + kolon_listesi[i]]).Checked = Convert.ToBoolean(data_Grid.SelectedRows[0].Cells[kolon_listesi[i]].Value);
                    }
                    else
                    {
                        this.Controls["txt_" + kolon_listesi[i]].Text = data_Grid.SelectedRows[0].Cells[kolon_listesi[i]].Value.ToString();
                    }
                }

            }
        }

        private void bt_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kolon_listesi.Length; i++)
            {
                if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_ID")
                    ((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).SelectedIndex = 0;
                else if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_mi")
                    ((CheckBox)this.Controls["chb_" + kolon_listesi[i]]).Checked = true;
                else
                    this.Controls["txt_" + kolon_listesi[i]].Text = "";
            }
        }

        private void degerler_doldur()
        {
            for (int i = 0; i < kolon_listesi.Length; i++)
            {
                if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_ID")
                    if (((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).SelectedValue != null)
                    {
                        deger_listesi[i] = ((ComboBox)this.Controls["cb_" + kolon_listesi[i]]).SelectedValue.ToString();
                    }
                    else
                    {
                        deger_listesi[i] = "0";
                    }
                else if (kolon_listesi[i].Substring(kolon_listesi[i].Length - 3, 3) == "_mi")
                    deger_listesi[i] = Convert.ToInt16(((CheckBox)this.Controls["chb_" + kolon_listesi[i]]).Checked).ToString();
                else
                    deger_listesi[i] = this.Controls["txt_" + kolon_listesi[i]].Text;
            }
        }
    }
}
