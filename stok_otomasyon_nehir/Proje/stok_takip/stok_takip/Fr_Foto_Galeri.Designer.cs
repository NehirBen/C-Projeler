
namespace stok_takip
{
    partial class Fr_Foto_Galeri
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
            this.bt_Sil = new System.Windows.Forms.Button();
            this.bt_Ekle = new System.Windows.Forms.Button();
            this.pc_Buyuk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Buyuk)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Sil
            // 
            this.bt_Sil.Location = new System.Drawing.Point(362, 120);
            this.bt_Sil.Name = "bt_Sil";
            this.bt_Sil.Size = new System.Drawing.Size(128, 75);
            this.bt_Sil.TabIndex = 4;
            this.bt_Sil.Text = "@Sil";
            this.bt_Sil.UseVisualStyleBackColor = true;
            this.bt_Sil.Click += new System.EventHandler(this.bt_Sil_Click);
            // 
            // bt_Ekle
            // 
            this.bt_Ekle.Location = new System.Drawing.Point(362, 12);
            this.bt_Ekle.Name = "bt_Ekle";
            this.bt_Ekle.Size = new System.Drawing.Size(128, 75);
            this.bt_Ekle.TabIndex = 3;
            this.bt_Ekle.Text = "@Ekle";
            this.bt_Ekle.UseVisualStyleBackColor = true;
            this.bt_Ekle.Click += new System.EventHandler(this.bt_Ekle_Click);
            // 
            // pc_Buyuk
            // 
            this.pc_Buyuk.Location = new System.Drawing.Point(12, 12);
            this.pc_Buyuk.Name = "pc_Buyuk";
            this.pc_Buyuk.Size = new System.Drawing.Size(326, 352);
            this.pc_Buyuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_Buyuk.TabIndex = 2;
            this.pc_Buyuk.TabStop = false;
            // 
            // Fr_Foto_Galeri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 378);
            this.Controls.Add(this.bt_Sil);
            this.Controls.Add(this.bt_Ekle);
            this.Controls.Add(this.pc_Buyuk);
            this.Name = "Fr_Foto_Galeri";
            this.Text = "Fr_Foto_Galeri";
            this.Load += new System.EventHandler(this.fr_Foto_Galeri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Buyuk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Sil;
        private System.Windows.Forms.Button bt_Ekle;
        private System.Windows.Forms.PictureBox pc_Buyuk;
    }
}