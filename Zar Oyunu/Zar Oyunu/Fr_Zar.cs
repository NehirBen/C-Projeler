using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar_Oyunu
{
    public partial class Fr_Zar : Form
    {
        public Fr_Zar()
        {
            InitializeComponent();
        }

        Random ransgle = new Random();
        int oyuncu1toplam, oyuncutoplam = 0;
        int a, b;

        private void zar_at()
        {
            a = ransgle.Next(1, 7);
            b = ransgle.Next(1, 7);
            pictureBox1.ImageLocation = "zar\\png" + a.ToString() + ".png";
            pictureBox2.ImageLocation = "zar\\png" + b.ToString() + ".png";

        }

        private void btt_2_Click(object sender, EventArgs e)
        {
            txt_btt_kctbtsn.Enabled = false;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            btt_1.Enabled = true;
            btt_2.Enabled = false;
            zar_at();
            oyuncutoplam = oyuncutoplam + a + b;
            lbl_2.Text = oyuncutoplam.ToString();
            skor_toplam();
        }

        private void btt_yndn_Click(object sender, EventArgs e)
        {
            txt_btt_kctbtsn.Enabled = true;
            txt_btt_kctbtsn.Text = "100";
            btt_1.Enabled = true;
            btt_2.Enabled = true;
            label4.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            oyuncu1toplam = 0;
            oyuncutoplam = 0;
            lbl_1.Text = "0";
            lbl_2.Text = "0";
            btt_yndn.Visible = true;
        }

        private void skor_toplam()
        {
            if (oyuncu1toplam >= Convert.ToInt16(txt_btt_kctbtsn.Text))
            {
                label4.Visible = true;
                label4.Text = "1.Oyuncu Kazandı...";
                btt_2.Enabled = false;
                btt_yndn.Visible = true;
            }
            if (oyuncutoplam >= Convert.ToInt16(txt_btt_kctbtsn.Text))
            {
                label4.Visible = true;
                label4.Text = "2.Oyuncu Kazandı...";
                btt_1.Enabled = false;
                btt_yndn.Visible = true;
            }

        }
        private void btt_1_Click(object sender, EventArgs e)
        {
            txt_btt_kctbtsn.Enabled = false;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            btt_1.Enabled = false;
            btt_2.Enabled = true;
            zar_at();
            oyuncu1toplam = oyuncu1toplam + a + b;
            lbl_1.Text = oyuncu1toplam.ToString();
            skor_toplam();
        }
    }
}
