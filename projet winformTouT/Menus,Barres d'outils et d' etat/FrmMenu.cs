using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus_Barres_d_outils_et_d__etat
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()

        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            toolStripDate.Text = DateTime.Now.ToString("G");
          

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        internal void Connexion ()
        {
            MessageBox.Show("Bienvenue");
            toolStripSplitButtonPH1.Visible = true;
            toolStripSplitButtonPH2.Visible = true;
            toolStripSplitButtonPH3.Visible = true;
            toolStripSplitButtonWindow.Visible = true;
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Fin de l'application?", "Fin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Calculatrice_Click(object sender, EventArgs e)
        {


            Calculatrice calculette = new Calculatrice();
            calculette.MdiParent = this;
            calculette.Visible = true;
            toolStripActiveWindow.Text = calculette.Text;



        }

        private void TextBoxcheckbox_Click_1(object sender, EventArgs e)
        {
            Checkboxes checkB = new Checkboxes();
            checkB.Visible = true;
            checkB.MdiParent = this;
            toolStripActiveWindow.Text = checkB.Text;
        }



        private void TextBoxButTraitement_Click(object sender, EventArgs e)
        {
            But2Traitements buttraitement = new But2Traitements();
            buttraitement.Visible = true;
            buttraitement.MdiParent = this;
            toolStripActiveWindow.Text = buttraitement.Text;
            
        }

        private void toolStripHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripTextCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void toolStripVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripActiveWindow_TextChanged(object sender, EventArgs e)
        {
           // toolStripActiveWindow.Text = ActiveMdiChild.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripDate.Text = DateTime.Now.ToString("G");
        }

        private void toolStripSplitButtonConnection_Click(object sender, EventArgs e)
        {
            Identification iDMDP = new Identification(this);
            iDMDP.Show();
        }

        public void SetToolTipText(string _messge)
        {
            toolStripActiveWindow.Text = _messge;
        }
    }
}
