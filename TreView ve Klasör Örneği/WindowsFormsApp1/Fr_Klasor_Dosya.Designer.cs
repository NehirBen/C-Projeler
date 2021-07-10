
namespace WindowsFormsApp1
{
    partial class fr_klasor_dosya
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
            this.lstB_Klasor = new System.Windows.Forms.ListBox();
            this.lstB_Dosya = new System.Windows.Forms.ListBox();
            this.pcB_tuval = new System.Windows.Forms.PictureBox();
            this.lb_adres = new System.Windows.Forms.Label();
            this.bt_klasor_sec = new System.Windows.Forms.Button();
            this.bt_dosya_sec = new System.Windows.Forms.Button();
            this.lb_foto_adres = new System.Windows.Forms.Label();
            this.pcb_tuval_2 = new System.Windows.Forms.PictureBox();
            this.bt_ikinci_pcb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcB_tuval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_tuval_2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstB_Klasor
            // 
            this.lstB_Klasor.FormattingEnabled = true;
            this.lstB_Klasor.Location = new System.Drawing.Point(12, 31);
            this.lstB_Klasor.Name = "lstB_Klasor";
            this.lstB_Klasor.Size = new System.Drawing.Size(244, 264);
            this.lstB_Klasor.TabIndex = 0;
            this.lstB_Klasor.SelectedIndexChanged += new System.EventHandler(this.lstB_Klasor_SelectedIndexChanged);
            // 
            // lstB_Dosya
            // 
            this.lstB_Dosya.FormattingEnabled = true;
            this.lstB_Dosya.Location = new System.Drawing.Point(274, 31);
            this.lstB_Dosya.Name = "lstB_Dosya";
            this.lstB_Dosya.Size = new System.Drawing.Size(164, 264);
            this.lstB_Dosya.TabIndex = 0;
            this.lstB_Dosya.SelectedIndexChanged += new System.EventHandler(this.lstB_Dosya_SelectedIndexChanged);
            // 
            // pcB_tuval
            // 
            this.pcB_tuval.Location = new System.Drawing.Point(631, 45);
            this.pcB_tuval.Name = "pcB_tuval";
            this.pcB_tuval.Size = new System.Drawing.Size(334, 264);
            this.pcB_tuval.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcB_tuval.TabIndex = 1;
            this.pcB_tuval.TabStop = false;
            // 
            // lb_adres
            // 
            this.lb_adres.AutoSize = true;
            this.lb_adres.Location = new System.Drawing.Point(13, 315);
            this.lb_adres.Name = "lb_adres";
            this.lb_adres.Size = new System.Drawing.Size(35, 13);
            this.lb_adres.TabIndex = 2;
            this.lb_adres.Text = "label1";
            // 
            // bt_klasor_sec
            // 
            this.bt_klasor_sec.Location = new System.Drawing.Point(12, 332);
            this.bt_klasor_sec.Name = "bt_klasor_sec";
            this.bt_klasor_sec.Size = new System.Drawing.Size(75, 23);
            this.bt_klasor_sec.TabIndex = 3;
            this.bt_klasor_sec.Text = "Klasor Seç";
            this.bt_klasor_sec.UseVisualStyleBackColor = true;
            this.bt_klasor_sec.Click += new System.EventHandler(this.bt_klasor_sec_Click);
            // 
            // bt_dosya_sec
            // 
            this.bt_dosya_sec.Location = new System.Drawing.Point(497, 80);
            this.bt_dosya_sec.Name = "bt_dosya_sec";
            this.bt_dosya_sec.Size = new System.Drawing.Size(75, 23);
            this.bt_dosya_sec.TabIndex = 4;
            this.bt_dosya_sec.Text = "Foto seç";
            this.bt_dosya_sec.UseVisualStyleBackColor = true;
            this.bt_dosya_sec.Click += new System.EventHandler(this.bt_dosya_sec_Click);
            // 
            // lb_foto_adres
            // 
            this.lb_foto_adres.AutoSize = true;
            this.lb_foto_adres.Location = new System.Drawing.Point(471, 9);
            this.lb_foto_adres.Name = "lb_foto_adres";
            this.lb_foto_adres.Size = new System.Drawing.Size(35, 13);
            this.lb_foto_adres.TabIndex = 5;
            this.lb_foto_adres.Text = "label1";
            // 
            // pcb_tuval_2
            // 
            this.pcb_tuval_2.Location = new System.Drawing.Point(262, 315);
            this.pcb_tuval_2.Name = "pcb_tuval_2";
            this.pcb_tuval_2.Size = new System.Drawing.Size(329, 276);
            this.pcb_tuval_2.TabIndex = 6;
            this.pcb_tuval_2.TabStop = false;
            // 
            // bt_ikinci_pcb
            // 
            this.bt_ikinci_pcb.Location = new System.Drawing.Point(26, 420);
            this.bt_ikinci_pcb.Name = "bt_ikinci_pcb";
            this.bt_ikinci_pcb.Size = new System.Drawing.Size(75, 23);
            this.bt_ikinci_pcb.TabIndex = 7;
            this.bt_ikinci_pcb.Text = "doldur";
            this.bt_ikinci_pcb.UseVisualStyleBackColor = true;
            this.bt_ikinci_pcb.Click += new System.EventHandler(this.bt_ikinci_pcb_Click);
            // 
            // fr_klasor_dosya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 594);
            this.Controls.Add(this.bt_ikinci_pcb);
            this.Controls.Add(this.pcb_tuval_2);
            this.Controls.Add(this.lb_foto_adres);
            this.Controls.Add(this.bt_dosya_sec);
            this.Controls.Add(this.bt_klasor_sec);
            this.Controls.Add(this.lb_adres);
            this.Controls.Add(this.pcB_tuval);
            this.Controls.Add(this.lstB_Dosya);
            this.Controls.Add(this.lstB_Klasor);
            this.Name = "fr_klasor_dosya";
            this.Text = "fr_klasor_dosya";
            this.Load += new System.EventHandler(this.fr_klasor_dosya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcB_tuval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_tuval_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstB_Klasor;
        private System.Windows.Forms.ListBox lstB_Dosya;
        private System.Windows.Forms.PictureBox pcB_tuval;
        private System.Windows.Forms.Label lb_adres;
        private System.Windows.Forms.Button bt_klasor_sec;
        private System.Windows.Forms.Button bt_dosya_sec;
        private System.Windows.Forms.Label lb_foto_adres;
        private System.Windows.Forms.PictureBox pcb_tuval_2;
        private System.Windows.Forms.Button bt_ikinci_pcb;
    }
}