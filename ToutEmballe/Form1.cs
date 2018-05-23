using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmballe
{
    public partial class Production2Caisses : Form
    {
        Production productionA;
        Production productionB;
        Production productionC;

        public Production2Caisses()
        {
            
            InitializeComponent();
            productionA = new Production(10000, 100, 0.0099F, "A");
            progressBarA.Maximum = productionA.Nbredecaisses;

            productionB = new Production(101, 100, 0.01F, "B");
            progressBarB.Maximum = productionB.Nbredecaisses;

            productionC = new Production(1500, 100, 0.01F, "C");
            progressBarC.Maximum = productionC.Nbredecaisses;

           // productionB.Demarrer();
        }



        private void ProdA_DemarrerClick(object sender, EventArgs e)
        {
            productionA.Demarrer();
        }

        private void ProdB_DemarrerClick(object sender, EventArgs e)
        {
            productionB.Demarrer();
        }

        private void ProdC_DemarrerClick(object sender, EventArgs e)
        {
            productionC.Demarrer();
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(productionA.State)
            {
                productionA.Update(); 
            
                progressBarA.Value = productionA.GetNbCaisseCourante();
                textBoxSinceStartupA.Text = productionA.GetNbCaisseCourante().ToString();
                textBoxDefaultPerHourA.Text = productionA.Nbredefautderniereheure.ToString();
                textBoxDefaultSinceStartA.Text = productionA.GetNbCaisseNonConforme().ToString();

                if (productionA.ATropDErreur() )
                {
                    productionA.Arreter();
                    MessageBox.Show("Machines de merde");
                }
            }

            

            productionB.Update();
            //MessageBox.Show(productionB.GetNbCaisseCourante().ToString());
            progressBarB.Value = productionB.GetNbCaisseCourante();
            textBoxSinceStartupB.Text = productionB.GetNbCaisseCourante().ToString();
            textBoxDefaultPerHourB.Text = productionB.Nbredefautderniereheure.ToString();
            textBoxDefaultSinceStartB.Text = productionB.GetNbCaisseNonConforme().ToString();

            if (productionB.ATropDErreur())
            {
                productionB.Arreter();
                MessageBox.Show("Machines de merde");
            }

            productionC.Update();
            progressBarC.Value = productionC.GetNbCaisseCourante();
            textBoxSinceStartupC.Text = productionC.GetNbCaisseCourante().ToString();
            textBoxDefaultPerHourC.Text = productionC.Nbredefautderniereheure.ToString();
            textBoxDefaultSinceStartC.Text = productionC.GetNbCaisseNonConforme().ToString();

            if (productionC .ATropDErreur())
            {
                productionC.Arreter();
                MessageBox.Show("Machines de merde");
            }

        }

        private void StopA_Click(object sender, EventArgs e)
        {
            productionA.Arreter();
        }

        private void StopB_Click(object sender, EventArgs e)
        {
            productionB.Arreter();
        }

        private void StopC_Click(object sender, EventArgs e)
        {
            productionC.Arreter();
        }

        private void ContinueA_Click(object sender, EventArgs e)
        {
            productionA.Continuer();
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {
            productionB.Continuer();
        }

        private void ContinueC_Click(object sender, EventArgs e)
        {
            productionC.Continuer();
        }

        private void Form_close(object sender, FormClosingEventArgs f)
        {
            if (MessageBox.Show
                ("Fin de l'application?", "Fin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.No)
            {
                f.Cancel = true;
            }
        }

     

        private void Quiter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

