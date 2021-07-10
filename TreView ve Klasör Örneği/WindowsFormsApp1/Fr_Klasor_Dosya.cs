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

namespace WindowsFormsApp1
{
    public partial class fr_klasor_dosya : Form
    {
        public fr_klasor_dosya()
        {
            InitializeComponent();
        }

        private void fr_klasor_dosya_Load(object sender, EventArgs e)
        {
            lb_adres.Text = "";
        }

        FolderBrowserDialog f = new FolderBrowserDialog();

        private void bt_klasor_sec_Click(object sender, EventArgs e)
        {
            if (f.ShowDialog()==DialogResult.OK)
            {
                lb_adres.Text = f.SelectedPath;
                lstB_Dosya.Items.Clear();
                lstB_Klasor.Items.Clear();
                // klasor listesi doldurma işlemi
                string[] klasorler = Directory.GetDirectories(f.SelectedPath);
                
                foreach (string klasor in klasorler)    lstB_Klasor.Items.Add(Path.GetFileName( klasor));
            }
        }

        private void bt_dosya_sec_Click(object sender, EventArgs e)
        {
            pcb_doldur(pcB_tuval);
        }

        private void lstB_Dosya_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void lstB_Klasor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dosya_doldur();
        }

        private void bt_ikinci_pcb_Click(object sender, EventArgs e)
        {
            pcb_doldur(pcb_tuval_2);
        }

        private void dosya_doldur()
        {
            //dosya listesi doldurma işlemi
            string[] dosyalar = Directory.GetFiles(f.SelectedPath + "/" + lstB_Klasor.SelectedItem.ToString());
            lstB_Dosya.Items.Clear();
            foreach (string dosya in dosyalar) lstB_Dosya.Items.Add(Path.GetFileName(dosya));
        }

        private void pcb_doldur(PictureBox gonderilen_picturebox)
        {
            try
            {
                //bağlantı aç
                //verileri at
                gonderilen_picturebox.Load(foto_adres_getir());
                lb_foto_adres.Text = foto_adres_getir();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                //throw;
            }
        }

        private string foto_adres_getir()
        {
            string adres = f.SelectedPath + "/" + lstB_Klasor.SelectedItem.ToString() + "/" + lstB_Dosya.SelectedItem.ToString();
            return adres;
        }

    }


}
