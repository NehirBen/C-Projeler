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

namespace Renkler
{
    public partial class fr_eski : Form
    {
        public fr_eski()
        {
            InitializeComponent();
        }

        private void fr_Klasör_Dosya_Load(object sender, EventArgs e)
        {
            lb_adres.Text = "";
        }

        private void bt_klasor_sec_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                lb_adres.Text = f.SelectedPath;
                string[] klasorler = Directory.GetDirectories(f.SelectedPath);
                lstB_Klasor.Items.Clear();
                foreach (string klasor in klasorler)
                {
                    lstB_Klasor.Items.Add(Path.GetFileName(klasor));
                }
            }
        }

        private void bt_Dosya_sec_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "jpeg dosyası|*.jpg|Gif dosyaları |*.gif|adobe dosyası|*.png";
            if (o.ShowDialog()==DialogResult.OK)
            {
                pcB_Tuval.Load(o.FileName);
            }
        }

        private void lstB_Dosya_SelectedIndexChanged(object sender, EventArgs e)
        {
            pcB_Tuval.Load(lb_adres.Text + "/"  + lstB_Dosya.SelectedItem.ToString());
        }

        private void lstB_Klasor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] dosyalar = Directory.GetFiles(f.SelectedPath+"/"+lstB_Klasor.SelectedItem.ToString());
            lstB_Dosya.Items.Clear();
            foreach (string dosya in dosyalar)
            {
                lstB_Dosya.Items.Add(Path.GetFileName(dosya));
            }
        }
    }
}
