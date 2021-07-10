
namespace Renkler
{
    partial class fr_eski
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
            this.pcB_Tuval = new System.Windows.Forms.PictureBox();
            this.lstB_Klasor = new System.Windows.Forms.ListBox();
            this.lstB_Dosya = new System.Windows.Forms.ListBox();
            this.lb_adres = new System.Windows.Forms.Label();
            this.bt_foto_sec = new System.Windows.Forms.Button();
            this.bt_klasor_sec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_Tuval)).BeginInit();
            this.SuspendLayout();
            // 
            // pcB_Tuval
            // 
            this.pcB_Tuval.Location = new System.Drawing.Point(444, 57);
            this.pcB_Tuval.Name = "pcB_Tuval";
            this.pcB_Tuval.Size = new System.Drawing.Size(267, 329);
            this.pcB_Tuval.TabIndex = 0;
            this.pcB_Tuval.TabStop = false;
            // 
            // lstB_Klasor
            // 
            this.lstB_Klasor.FormattingEnabled = true;
            this.lstB_Klasor.Location = new System.Drawing.Point(24, 23);
            this.lstB_Klasor.Name = "lstB_Klasor";
            this.lstB_Klasor.Size = new System.Drawing.Size(193, 342);
            this.lstB_Klasor.TabIndex = 1;
            this.lstB_Klasor.Click += new System.EventHandler(this.bt_klasor_sec_Click);
            this.lstB_Klasor.SelectedIndexChanged += new System.EventHandler(this.lstB_Klasor_SelectedIndexChanged);
            // 
            // lstB_Dosya
            // 
            this.lstB_Dosya.FormattingEnabled = true;
            this.lstB_Dosya.Location = new System.Drawing.Point(245, 23);
            this.lstB_Dosya.Name = "lstB_Dosya";
            this.lstB_Dosya.Size = new System.Drawing.Size(193, 329);
            this.lstB_Dosya.TabIndex = 1;
            this.lstB_Dosya.Click += new System.EventHandler(this.bt_Dosya_sec_Click);
            this.lstB_Dosya.SelectedIndexChanged += new System.EventHandler(this.lstB_Dosya_SelectedIndexChanged);
            // 
            // lb_adres
            // 
            this.lb_adres.AutoSize = true;
            this.lb_adres.Location = new System.Drawing.Point(39, 373);
            this.lb_adres.Name = "lb_adres";
            this.lb_adres.Size = new System.Drawing.Size(35, 13);
            this.lb_adres.TabIndex = 2;
            this.lb_adres.Text = "label1";
            // 
            // bt_foto_sec
            // 
            this.bt_foto_sec.Location = new System.Drawing.Point(454, 12);
            this.bt_foto_sec.Name = "bt_foto_sec";
            this.bt_foto_sec.Size = new System.Drawing.Size(130, 40);
            this.bt_foto_sec.TabIndex = 4;
            this.bt_foto_sec.Text = "Foto Seç";
            this.bt_foto_sec.UseVisualStyleBackColor = true;
            // 
            // bt_klasor_sec
            // 
            this.bt_klasor_sec.Location = new System.Drawing.Point(24, 399);
            this.bt_klasor_sec.Name = "bt_klasor_sec";
            this.bt_klasor_sec.Size = new System.Drawing.Size(107, 52);
            this.bt_klasor_sec.TabIndex = 5;
            this.bt_klasor_sec.Text = "Klasör Seç";
            this.bt_klasor_sec.UseVisualStyleBackColor = true;
            this.bt_klasor_sec.Click += new System.EventHandler(this.bt_klasor_sec_Click);
            // 
            // fr_Klasör_Dosya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 496);
            this.Controls.Add(this.bt_klasor_sec);
            this.Controls.Add(this.bt_foto_sec);
            this.Controls.Add(this.lb_adres);
            this.Controls.Add(this.lstB_Dosya);
            this.Controls.Add(this.lstB_Klasor);
            this.Controls.Add(this.pcB_Tuval);
            this.Name = "fr_Klasör_Dosya";
            this.Text = "fr_Klasör_Dosya";
            this.Load += new System.EventHandler(this.fr_Klasör_Dosya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcB_Tuval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcB_Tuval;
        private System.Windows.Forms.ListBox lstB_Klasor;
        private System.Windows.Forms.ListBox lstB_Dosya;
        private System.Windows.Forms.Label lb_adres;
        private System.Windows.Forms.Button bt_foto_sec;
        private System.Windows.Forms.Button bt_klasor_sec;
    }
}