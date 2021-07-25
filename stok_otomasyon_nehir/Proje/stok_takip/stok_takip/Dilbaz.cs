using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace stok_takip
{
    class Dilbaz
    {
        SQL_Yardimcisi sql_y = new SQL_Yardimcisi();

        public void Dil_degistir(string Dil_ID, Form f)
        {
            string sql_metni = " SELECT etiket.adi, Metinler.deger "
                             + " FROM Metinler INNER JOIN etiket ON Metinler.etiket_ID = etiket.ID "
                             + " WHERE(((Metinler.Dil_ID) = " + Dil_ID + "))";
            DataTable dt = sql_y.Sql_Calistir_dataTable_bySQL(sql_metni);

            foreach (Control item in f.Controls)
            {
                if (dt.Select("adi='" + item.Tag + "'").Count() > 0)
                {
                    item.Text = dt.Select("adi='" + item.Tag + "'")[0]["deger"].ToString();
                }
            }
        }


        public string deger_getir_tag_ile(string Dil_ID, string tag)
        {
            string deger = "";
            string sql_metni = " SELECT Metinler.deger "
                             + " FROM Metinler INNER JOIN etiket ON Metinler.etiket_ID = etiket.ID "
                             + " WHERE(((Metinler.Dil_ID) = " + Dil_ID + ") AND etiket.adi='" + tag + "')";
            DataTable dt = sql_y.Sql_Calistir_dataTable_bySQL(sql_metni);
            if (dt.Rows.Count > 0)
                deger = dt.Rows[0][0].ToString();

            return deger;
        }
    }
}
