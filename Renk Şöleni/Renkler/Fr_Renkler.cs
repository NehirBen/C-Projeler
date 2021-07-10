using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renkler
{
    public partial class Fr_Renkler : Form
    {
        public Fr_Renkler()
        {
            InitializeComponent();
        }

        Random rasgele = new Random();

        private void trb_renk_Scroll(object sender, EventArgs e)
        {
            int kirmizi = trb_Red.Value;
            int yesil = trb_Green.Value;
            int mavi = trb_Blue.Value;

            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);

        }

        private void bt_renklendir_MouseMove(object sender, MouseEventArgs e)
        {
            int kirmizi = trb_Red.Value = rasgele.Next(256);
            int yesil = trb_Green.Value = rasgele.Next(256);
            int mavi = trb_Blue.Value = rasgele.Next(256);

            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void fr_Renkler_Load(object sender, EventArgs e)
        {
            tm_tiktak.Interval = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString() + " mili saniye";
        }

        private void tm_tiktak_Tick(object sender, EventArgs e)
        {
            int kirmizi = trb_Red.Value = rasgele.Next(256);
            int yesil = trb_Green.Value = rasgele.Next(256);
            int mavi = trb_Blue.Value = rasgele.Next(256);

            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void bt_basla_Click(object sender, EventArgs e)
        {

            if (tm_tiktak.Enabled)
            {
                tm_tiktak.Stop();
                bt_basla.BackColor = Color.Green;

            }
            else
            {
                tm_tiktak.Interval = trackBar1.Value;
                tm_tiktak.Start();
            }

        }

        private void bt_dur_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tm_tiktak.Interval = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString() + " mili saniye";
        }
    }
}
