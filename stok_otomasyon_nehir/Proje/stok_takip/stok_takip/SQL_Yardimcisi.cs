using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Configuration;


namespace stok_takip
{
    class SQL_Yardimcisi
    {

        string baglanti_metni;
        OleDbConnection adres = new OleDbConnection();
        OleDbCommand postaci = new OleDbCommand();
        OleDbDataAdapter veri_organizatoru;

        public void grid_doldur(DataGridView dtg, string tbl_isim)
        {
            dtg.DataSource = Sql_Calistir_dataTable_bySQL("Select * From " + tbl_isim);
            for (int i = 0; i < dtg.Columns.Count; i++)
            {
                if (dtg.Columns[i].Name.Substring(dtg.Columns[i].Name.Count() - 2, 2) == "ID")
                {
                    dtg.Columns[i].Visible = false;
                }
            }
        }

        public void grid_doldur_V2(DataGridView dtg, string Sql_metni)
        {
            dtg.DataSource = Sql_Calistir_dataTable_bySQL(Sql_metni);
            for (int i = 0; i < dtg.Columns.Count; i++)
            {
                if (dtg.Columns[i].Name.Substring(dtg.Columns[i].Name.Count() - 2, 2) == "ID")
                {
                    dtg.Columns[i].Visible = false;
                }
            }
        }
        public void grid_doldur_kosullu(DataGridView dtg, string tbl_isim, string kosul)
        {


            dtg.DataSource = Sql_Calistir_dataTable_bySQL("Select * From " + tbl_isim + " WHERE " + kosul);
            for (int i = 0; i < dtg.Columns.Count; i++)
            {
                if (dtg.Columns[i].Name.Substring(dtg.Columns[i].Name.Count() - 2, 2) == "ID")
                {
                    dtg.Columns[i].Visible = false;
                }
            }
        }

        public void grid_bicimlendir(DataGridView dtg)
        {
            dtg.AllowUserToAddRows = false;
            dtg.AllowUserToDeleteRows = false;
            dtg.MultiSelect = false;
            dtg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        [Obsolete]
        public DataTable Sql_Calistir_dataTable_bySQL(string SQL_metni)
        {
            DataSet veri_kumesi = new DataSet();
            try
            {
                baglanti_metni = ConfigurationSettings.AppSettings["Baglanti_Metni"].ToString();

                adres.ConnectionString = baglanti_metni;
                adres.Open();
                postaci.Connection = adres;
                postaci.CommandText = SQL_metni;
                veri_organizatoru = new OleDbDataAdapter(postaci);
                veri_organizatoru.Fill(veri_kumesi);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                //throw;
            }

            finally
            {
                adres.Close();
            }
            return veri_kumesi.Tables[0];
        }

        public DataTable Sql_Calistir_dataTable_byTablo_adi(string Tablo_adi)
        {
            DataTable veri_kumesi = new DataTable();
            veri_kumesi = Sql_Calistir_dataTable_bySQL("select * from " + Tablo_adi);
            return veri_kumesi;
        }


        public bool tablo_kontrol(string tablo_adi, string[] kolon_liste, string[] deger_liste)
        {
            bool sonuc = false;
            DataTable dt = Sql_calistir_datatable_byDegerler(tablo_adi, kolon_liste, deger_liste);
            if (dt.Rows.Count > 0) sonuc = true;

            return sonuc;
        }

        public DataTable Sql_calistir_datatable_byDegerler(string tablo_adi, string[] kolon_liste, string[] deger_liste)
        {
            //Select * From tablo_adi Where kullanici_adi=@kullanici_adi AND sifre=@sifre;
            string sql_where_bolumu = "";
            postaci.Parameters.Clear();
            for (int i = 0; i < kolon_liste.Length; i++)
            {
                sql_where_bolumu += kolon_liste[i] + "=@" + kolon_liste[i];
                if (kolon_liste.Length > 1 && i < kolon_liste.Length - 1)
                {
                    sql_where_bolumu += " AND ";
                }
                postaci.Parameters.AddWithValue("@" + kolon_liste[i], deger_liste[i]);
            }

            string sql_metni = "Select * From " + tablo_adi + " Where " + sql_where_bolumu;

            DataTable dt = Sql_Calistir_dataTable_bySQL(sql_metni);

            return dt;
        }


        public void Sql_Calistir_donutsuz(string SQL_metni)
        {
            try
            {
                baglanti_metni = ConfigurationSettings.AppSettings["Baglanti_Metni"].ToString();
                adres.ConnectionString = baglanti_metni;
                adres.Open();
                postaci.Connection = adres;
                postaci.CommandText = SQL_metni;

                postaci.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                //throw;
            }
            finally
            {
                adres.Close();
            }
        }

        public void KayitSil(string tbl_isim, string ID)
        {
            string sql_metni = "Delete FROM " + tbl_isim + " where ID=" + ID;
            Sql_Calistir_donutsuz(sql_metni);
        }
        public void Kayit_Guncelle(string tablo_adi, string ID, string[] kolon_liste, string[] deger_liste)
        {
            string sql_metni = "UPDATE " + tablo_adi + " SET ";
            postaci.Parameters.Clear();
            for (int i = 0; i < kolon_liste.Length; i++)
            {   // kod=@kod,isim=@isim,info=@info şeklinde sqlmetnine 
                //kolon(kod) ve değişkenleri(@kod) ekleme yapar.
                sql_metni += kolon_liste[i] + "=@" + kolon_liste[i];

                // kod ve isim gibi kolonlar arasına "," koyar (if sayesinde son kayıt hariç)
                if (i < kolon_liste.Length - 1) sql_metni += ",";

                // sql değişknlerinin (@kod,@isim gibi) parametre değerlerini girer.
                postaci.Parameters.AddWithValue("@" + kolon_liste[i], deger_liste[i]);
            }
            sql_metni += " WHERE ID=" + ID;
            Sql_Calistir_donutsuz(sql_metni);
        }
        public void Kayit_Ekle(string tablo_adi, string[] kolon_liste, string[] deger_liste)
        {
            // INSERT INTO [tablo_adi] ( kolon listesi.. ) VALUES(değerler listesi..(değiken kullanıyoruz))

            string kolonlar = ""; // insert into değimindeki kolon listesi için değişken
            string degerler = ""; //insert into değimindeki değer listesi için değişken
            postaci.Parameters.Clear();
            for (int i = 0; i < kolon_liste.Length; i++)
            {
                kolonlar += kolon_liste[i];  // kodi,isim,info gibi kolon listesi hazırlar
                degerler += "@" + kolon_liste[i]; // @kodi,@isim,@info gibi değişken listesi hazırlar
                if (i < kolon_liste.Length - 1)
                {  // elemalar arası "," koyar (son kayıt hariç)
                    kolonlar += ",";
                    degerler += ",";
                }
                // sql değişknlerinin (@kod,@isim gibi) parametre değerlerini girer.
                postaci.Parameters.AddWithValue("@" + kolon_liste[i], deger_liste[i]);
            }
            // sql metnini birleştiriyoruz
            string sql_metni = "INSERT INTO " + tablo_adi + "(" + kolonlar + ") VALUES(" + degerler + ")";
            Sql_Calistir_donutsuz(sql_metni); //metni çalıltırıyoruz.
        }

        public string[] kolon_liste_getir(string tablo_adi)
        {
            List<string> kolon_liste = new List<string>();
            DataTable dt = Sql_Calistir_dataTable_bySQL("select * From " + tablo_adi);
            for (int i = 1; i < dt.Columns.Count; i++) kolon_liste.Add(dt.Columns[i].ColumnName.ToString());
            return kolon_liste.ToArray();
        }


    }
}
