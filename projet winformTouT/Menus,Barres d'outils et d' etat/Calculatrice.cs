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
    public partial class Calculatrice : Form
    {
        

        string affichage = "";
        static int compteur = 0;


        public Calculatrice()
        {
            InitializeComponent();
            compteur++;
            Text = "L'additionneur " + compteur.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (null == btn)
                return;

            if (textBox1.TextLength == 0)
            {
                affichage = btn.Text;
                //textBox1.Text = affichage;


            }
            else
            {

                affichage += "+" + btn.Text;
              
            }
       
            textBox1.Text = affichage;//texte dans la textbox de la calculette
        }

        private void VIDER_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//efface l affichage
            affichage = "";//reinitialise l affichage
        }

        private void CALCULER_Click(object sender, EventArgs e)
        {
            int sommes = 0;//initialise la sommes des calcules à 0

            char[] separateur = new char[] { '+' }; //cree un tableau qui stock les carcteres speciaux
            String[] substrings = affichage.Split(separateur, StringSplitOptions.RemoveEmptyEntries);
            //transforme tous les caractere en string dans un tableau "avant ="  puis  split divise la chaine en enlevant les +
             

           for (int i = 0; i < substrings.Length; i++)
     {
            //    if (! substrings[i].Contains("+"))
            //    {
                    sommes += int.Parse(substrings[i]); //convertie les caracteres a l emplacement i dans le tableau de string en entier
            //    }
       }
            
            affichage = sommes.ToString();
            textBox1.Text = affichage;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculatrice_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMenu menu = MdiParent as FrmMenu;

            menu.SetToolTipText("Additionneur fermé !");
        }
    }
}
