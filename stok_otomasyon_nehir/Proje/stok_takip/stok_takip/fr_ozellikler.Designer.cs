
namespace stok_takip
{
    partial class fr_ozellikler
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
            this.data_Grid = new System.Windows.Forms.DataGridView();
            this.bt_Sil = new System.Windows.Forms.Button();
            this.bt_Guncelle = new System.Windows.Forms.Button();
            this.bt_Temizle = new System.Windows.Forms.Button();
            this.bt_Ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Grid
            // 
            this.data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Grid.Location = new System.Drawing.Point(107, 52);
            this.data_Grid.Name = "data_Grid";
            this.data_Grid.Size = new System.Drawing.Size(240, 386);
            this.data_Grid.TabIndex = 6;
            this.data_Grid.SelectionChanged += new System.EventHandler(this.data_Grid_SelectionChanged);
            this.data_Grid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.data_Grid_MouseDoubleClick);
            // 
            // bt_Sil
            // 
            this.bt_Sil.Location = new System.Drawing.Point(11, 187);
            this.bt_Sil.Name = "bt_Sil";
            this.bt_Sil.Size = new System.Drawing.Size(90, 38);
            this.bt_Sil.TabIndex = 2;
            this.bt_Sil.Text = "Sil";
            this.bt_Sil.UseVisualStyleBackColor = true;
            this.bt_Sil.Click += new System.EventHandler(this.bt_Sil_Click);
            // 
            // bt_Guncelle
            // 
            this.bt_Guncelle.Location = new System.Drawing.Point(11, 140);
            this.bt_Guncelle.Name = "bt_Guncelle";
            this.bt_Guncelle.Size = new System.Drawing.Size(90, 38);
            this.bt_Guncelle.TabIndex = 3;
            this.bt_Guncelle.Text = "Güncelle";
            this.bt_Guncelle.UseVisualStyleBackColor = true;
            this.bt_Guncelle.Click += new System.EventHandler(this.bt_Guncelle_Click);
            // 
            // bt_Temizle
            // 
            this.bt_Temizle.Location = new System.Drawing.Point(12, 95);
            this.bt_Temizle.Name = "bt_Temizle";
            this.bt_Temizle.Size = new System.Drawing.Size(90, 38);
            this.bt_Temizle.TabIndex = 4;
            this.bt_Temizle.Text = "Temizle";
            this.bt_Temizle.UseVisualStyleBackColor = true;
            this.bt_Temizle.Click += new System.EventHandler(this.bt_Temizle_Click);
            // 
            // bt_Ekle
            // 
            this.bt_Ekle.Location = new System.Drawing.Point(13, 52);
            this.bt_Ekle.Name = "bt_Ekle";
            this.bt_Ekle.Size = new System.Drawing.Size(90, 38);
            this.bt_Ekle.TabIndex = 5;
            this.bt_Ekle.Text = "Ekle";
            this.bt_Ekle.UseVisualStyleBackColor = true;
            this.bt_Ekle.Click += new System.EventHandler(this.bt_Ekle_Click);
            // 
            // fr_ozellikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.data_Grid);
            this.Controls.Add(this.bt_Sil);
            this.Controls.Add(this.bt_Guncelle);
            this.Controls.Add(this.bt_Temizle);
            this.Controls.Add(this.bt_Ekle);
            this.Name = "fr_ozellikler";
            this.Text = "fr_ozellikler";
            this.Load += new System.EventHandler(this.fr_Tablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Grid;
        private System.Windows.Forms.Button bt_Sil;
        private System.Windows.Forms.Button bt_Guncelle;
        private System.Windows.Forms.Button bt_Temizle;
        private System.Windows.Forms.Button bt_Ekle;
    }
}