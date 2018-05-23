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
    public partial class Identification : Form
    {
        FrmMenu maman;
        string Password = "123";

        public Identification()
        {
            InitializeComponent();
        }
        public Identification(FrmMenu _maman)
        {
            InitializeComponent();
            maman = _maman;
        }

        private void Identification_Load(object sender, EventArgs e)
        {

        }

        private void buttonYEP_Click(object sender, EventArgs e)
        {
            if (textBoxMDP .Text == Password )
            {
                maman.Connexion();
                Close();
            }
            else
            {
                MessageBox.Show("Mauvais mot de passe!!!!");
            }
        }
    }
}
