
namespace WindowsFormsApp1
{
    partial class Fr_TreeView
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ankara");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("türkiye", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("italya");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("avrupa", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Amerika");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Dünya", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("sector1");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("sector2");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("mars", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.rb_ana_dizin = new System.Windows.Forms.RadioButton();
            this.trV_liste = new System.Windows.Forms.TreeView();
            this.txt_Girilen = new System.Windows.Forms.TextBox();
            this.bt_ekle = new System.Windows.Forms.Button();
            this.rb_child = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_sil = new System.Windows.Forms.Button();
            this.bt_ac = new System.Windows.Forms.Button();
            this.bt_goster = new System.Windows.Forms.Button();
            this.bt_kapat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_ana_dizin
            // 
            this.rb_ana_dizin.AutoSize = true;
            this.rb_ana_dizin.Checked = true;
            this.rb_ana_dizin.Location = new System.Drawing.Point(14, 61);
            this.rb_ana_dizin.Name = "rb_ana_dizin";
            this.rb_ana_dizin.Size = new System.Drawing.Size(68, 17);
            this.rb_ana_dizin.TabIndex = 4;
            this.rb_ana_dizin.TabStop = true;
            this.rb_ana_dizin.Text = "Ana dizin";
            this.rb_ana_dizin.UseVisualStyleBackColor = true;
            // 
            // trV_liste
            // 
            this.trV_liste.Location = new System.Drawing.Point(12, 23);
            this.trV_liste.Name = "trV_liste";
            treeNode10.Name = "Node5";
            treeNode10.Text = "ankara";
            treeNode11.Name = "Node3";
            treeNode11.Text = "türkiye";
            treeNode12.Name = "Node4";
            treeNode12.Text = "italya";
            treeNode13.Name = "Node1";
            treeNode13.Text = "avrupa";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Amerika";
            treeNode15.Name = "Node0";
            treeNode15.Text = "Dünya";
            treeNode16.Name = "Node7";
            treeNode16.Text = "sector1";
            treeNode17.Name = "Node8";
            treeNode17.Text = "sector2";
            treeNode18.Name = "Node6";
            treeNode18.Text = "mars";
            this.trV_liste.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.trV_liste.Size = new System.Drawing.Size(217, 406);
            this.trV_liste.TabIndex = 5;
            // 
            // txt_Girilen
            // 
            this.txt_Girilen.Location = new System.Drawing.Point(14, 22);
            this.txt_Girilen.Name = "txt_Girilen";
            this.txt_Girilen.Size = new System.Drawing.Size(100, 20);
            this.txt_Girilen.TabIndex = 6;
            // 
            // bt_ekle
            // 
            this.bt_ekle.Location = new System.Drawing.Point(134, 19);
            this.bt_ekle.Name = "bt_ekle";
            this.bt_ekle.Size = new System.Drawing.Size(75, 89);
            this.bt_ekle.TabIndex = 7;
            this.bt_ekle.Text = "Ekle";
            this.bt_ekle.UseVisualStyleBackColor = true;
            this.bt_ekle.Click += new System.EventHandler(this.bt_ekle_Click);
            // 
            // rb_child
            // 
            this.rb_child.AutoSize = true;
            this.rb_child.Location = new System.Drawing.Point(14, 84);
            this.rb_child.Name = "rb_child";
            this.rb_child.Size = new System.Drawing.Size(61, 17);
            this.rb_child.TabIndex = 4;
            this.rb_child.TabStop = true;
            this.rb_child.Text = "Alt dizin";
            this.rb_child.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_ekle);
            this.groupBox1.Controls.Add(this.rb_ana_dizin);
            this.groupBox1.Controls.Add(this.txt_Girilen);
            this.groupBox1.Controls.Add(this.rb_child);
            this.groupBox1.Location = new System.Drawing.Point(235, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni girdi";
            // 
            // bt_sil
            // 
            this.bt_sil.Location = new System.Drawing.Point(235, 141);
            this.bt_sil.Name = "bt_sil";
            this.bt_sil.Size = new System.Drawing.Size(75, 89);
            this.bt_sil.TabIndex = 7;
            this.bt_sil.Text = "Seçili olanı sil";
            this.bt_sil.UseVisualStyleBackColor = true;
            this.bt_sil.Click += new System.EventHandler(this.bt_sil_Click);
            // 
            // bt_ac
            // 
            this.bt_ac.Location = new System.Drawing.Point(235, 236);
            this.bt_ac.Name = "bt_ac";
            this.bt_ac.Size = new System.Drawing.Size(75, 89);
            this.bt_ac.TabIndex = 7;
            this.bt_ac.Text = "Hepsini aç";
            this.bt_ac.UseVisualStyleBackColor = true;
            this.bt_ac.Click += new System.EventHandler(this.bt_ac_Click);
            // 
            // bt_goster
            // 
            this.bt_goster.Location = new System.Drawing.Point(235, 331);
            this.bt_goster.Name = "bt_goster";
            this.bt_goster.Size = new System.Drawing.Size(75, 89);
            this.bt_goster.TabIndex = 7;
            this.bt_goster.Text = "Göster";
            this.bt_goster.UseVisualStyleBackColor = true;
            this.bt_goster.Click += new System.EventHandler(this.bt_goster_Click);
            // 
            // bt_kapat
            // 
            this.bt_kapat.Location = new System.Drawing.Point(336, 236);
            this.bt_kapat.Name = "bt_kapat";
            this.bt_kapat.Size = new System.Drawing.Size(75, 89);
            this.bt_kapat.TabIndex = 7;
            this.bt_kapat.Text = "Hepsini kapa";
            this.bt_kapat.UseVisualStyleBackColor = true;
            this.bt_kapat.Click += new System.EventHandler(this.bt_kapat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(527, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 58);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_goster);
            this.Controls.Add(this.bt_kapat);
            this.Controls.Add(this.bt_ac);
            this.Controls.Add(this.bt_sil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trV_liste);
            this.Name = "Form1";
            this.Text = "TreeView örneği";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_ana_dizin;
        private System.Windows.Forms.TreeView trV_liste;
        private System.Windows.Forms.TextBox txt_Girilen;
        private System.Windows.Forms.Button bt_ekle;
        private System.Windows.Forms.RadioButton rb_child;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_sil;
        private System.Windows.Forms.Button bt_ac;
        private System.Windows.Forms.Button bt_goster;
        private System.Windows.Forms.Button bt_kapat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

