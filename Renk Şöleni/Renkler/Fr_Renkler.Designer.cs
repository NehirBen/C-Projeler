
namespace Renkler
{
    partial class Fr_Renkler
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
            this.components = new System.ComponentModel.Container();
            this.bt_renklendir = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_basla = new System.Windows.Forms.Button();
            this.bt_dur = new System.Windows.Forms.Button();
            this.trb_Red = new System.Windows.Forms.TrackBar();
            this.trb_Green = new System.Windows.Forms.TrackBar();
            this.trb_Blue = new System.Windows.Forms.TrackBar();
            this.tm_tiktak = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_renklendir
            // 
            this.bt_renklendir.Location = new System.Drawing.Point(258, 25);
            this.bt_renklendir.Name = "bt_renklendir";
            this.bt_renklendir.Size = new System.Drawing.Size(237, 23);
            this.bt_renklendir.TabIndex = 4;
            this.bt_renklendir.Text = "Şenlendir Bizi Scati";
            this.bt_renklendir.UseVisualStyleBackColor = true;
            this.bt_renklendir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_renklendir_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 50;
            this.trackBar1.Location = new System.Drawing.Point(36, 66);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(167, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // bt_basla
            // 
            this.bt_basla.Location = new System.Drawing.Point(36, 144);
            this.bt_basla.Name = "bt_basla";
            this.bt_basla.Size = new System.Drawing.Size(75, 23);
            this.bt_basla.TabIndex = 8;
            this.bt_basla.Text = "Başla";
            this.bt_basla.UseVisualStyleBackColor = true;
            this.bt_basla.Click += new System.EventHandler(this.bt_basla_Click);
            // 
            // bt_dur
            // 
            this.bt_dur.Location = new System.Drawing.Point(128, 144);
            this.bt_dur.Name = "bt_dur";
            this.bt_dur.Size = new System.Drawing.Size(75, 23);
            this.bt_dur.TabIndex = 9;
            this.bt_dur.Text = "Dur";
            this.bt_dur.UseVisualStyleBackColor = true;
            this.bt_dur.Click += new System.EventHandler(this.bt_dur_Click);
            // 
            // trb_Red
            // 
            this.trb_Red.BackColor = System.Drawing.Color.Red;
            this.trb_Red.Location = new System.Drawing.Point(36, 204);
            this.trb_Red.Maximum = 255;
            this.trb_Red.Name = "trb_Red";
            this.trb_Red.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_Red.Size = new System.Drawing.Size(45, 217);
            this.trb_Red.TabIndex = 10;
            // 
            // trb_Green
            // 
            this.trb_Green.BackColor = System.Drawing.Color.Green;
            this.trb_Green.Location = new System.Drawing.Point(128, 204);
            this.trb_Green.Maximum = 255;
            this.trb_Green.Name = "trb_Green";
            this.trb_Green.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_Green.Size = new System.Drawing.Size(45, 217);
            this.trb_Green.TabIndex = 11;
            // 
            // trb_Blue
            // 
            this.trb_Blue.BackColor = System.Drawing.Color.Blue;
            this.trb_Blue.Location = new System.Drawing.Point(215, 204);
            this.trb_Blue.Maximum = 255;
            this.trb_Blue.Name = "trb_Blue";
            this.trb_Blue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_Blue.Size = new System.Drawing.Size(45, 217);
            this.trb_Blue.TabIndex = 12;
            // 
            // tm_tiktak
            // 
            this.tm_tiktak.Interval = 500;
            this.tm_tiktak.Tick += new System.EventHandler(this.tm_tiktak_Tick);
            // 
            // fr_Renkler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trb_Blue);
            this.Controls.Add(this.trb_Green);
            this.Controls.Add(this.trb_Red);
            this.Controls.Add(this.bt_dur);
            this.Controls.Add(this.bt_basla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.bt_renklendir);
            this.Name = "fr_Renkler";
            this.Text = "fr_Renkler";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_renklendir;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_basla;
        private System.Windows.Forms.Button bt_dur;
        private System.Windows.Forms.TrackBar trb_Red;
        private System.Windows.Forms.TrackBar trb_Green;
        private System.Windows.Forms.TrackBar trb_Blue;
        private System.Windows.Forms.Timer tm_tiktak;
    }
}

