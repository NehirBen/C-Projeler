using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Fr_TreeView : Form
    {
        public Fr_TreeView()
        {
            InitializeComponent();
        }

        private void bt_ekle_Click(object sender, EventArgs e)
        {
            if (rb_ana_dizin.Checked)
                trV_liste.Nodes.Add(txt_Girilen.Text);
            else
                trV_liste.SelectedNode.Nodes.Add(txt_Girilen.Text);   
        }

        private void bt_sil_Click(object sender, EventArgs e)
        {
            if (trV_liste.SelectedNode.Parent == null)
                trV_liste.Nodes.Remove(trV_liste.SelectedNode);
            else
                 trV_liste.SelectedNode.Parent.Nodes.Remove(trV_liste.SelectedNode);  
        }

        private void bt_ac_Click(object sender, EventArgs e)
        {
            trV_liste.ExpandAll();
            
        }
        private void bt_kapat_Click(object sender, EventArgs e)
        {
            trV_liste.CollapseAll();
        }


        private void bt_goster_Click(object sender, EventArgs e)
        {
            if (trV_liste.SelectedNode != null)
            {
                MessageBox.Show(trV_liste.SelectedNode.Text);
            }
            
        }

       
    }
}
