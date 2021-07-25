
namespace stok_takip
{
    partial class Fr_giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_giris));
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Dil = new System.Windows.Forms.ComboBox();
            this.bt_cikis = new System.Windows.Forms.Button();
            this.bt_giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 13;
            this.label3.Tag = "@dil";
            this.label3.Text = "Dil";
            // 
            // cb_Dil
            // 
            this.cb_Dil.BackColor = System.Drawing.Color.OldLace;
            this.cb_Dil.FormattingEnabled = true;
            this.cb_Dil.Location = new System.Drawing.Point(150, 104);
            this.cb_Dil.Name = "cb_Dil";
            this.cb_Dil.Size = new System.Drawing.Size(100, 21);
            this.cb_Dil.TabIndex = 12;
            this.cb_Dil.SelectedIndexChanged += new System.EventHandler(this.cb_Dil_SelectedIndexChanged);
            // 
            // bt_cikis
            // 
            this.bt_cikis.Location = new System.Drawing.Point(175, 76);
            this.bt_cikis.Name = "bt_cikis";
            this.bt_cikis.Size = new System.Drawing.Size(75, 23);
            this.bt_cikis.TabIndex = 11;
            this.bt_cikis.Tag = "@cikis";
            this.bt_cikis.Text = "Çıkış x";
            this.bt_cikis.UseVisualStyleBackColor = true;
            this.bt_cikis.Click += new System.EventHandler(this.bt_cikis_Click);
            // 
            // bt_giris
            // 
            this.bt_giris.Location = new System.Drawing.Point(61, 76);
            this.bt_giris.Name = "bt_giris";
            this.bt_giris.Size = new System.Drawing.Size(75, 23);
            this.bt_giris.TabIndex = 10;
            this.bt_giris.Tag = "@Giris ";
            this.bt_giris.Text = "Giriş ✓";
            this.bt_giris.UseVisualStyleBackColor = true;
            this.bt_giris.Click += new System.EventHandler(this.bt_giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Tag = "@sifre";
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Tag = "@kullanici_adi";
            this.label1.Text = "Kullanıcı adı";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(150, 50);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 9;
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.BackColor = System.Drawing.Color.White;
            this.txt_kullanici_adi.Location = new System.Drawing.Point(150, 11);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullanici_adi.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Fr_giris
            // 
            this.AcceptButton = this.bt_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(258, 140);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Dil);
            this.Controls.Add(this.bt_cikis);
            this.Controls.Add(this.bt_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Name = "Fr_giris";
            this.Tag = "@f_giris";
            this.Text = "Giriş Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Fr_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Dil;
        private System.Windows.Forms.Button bt_cikis;
        private System.Windows.Forms.Button bt_giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullanici_adi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

