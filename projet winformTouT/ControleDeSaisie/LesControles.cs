using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControleDeSaisie
{
    public partial class LesControles : Form
    {
        DateTime dt;
        string affichages = "";
        

        public LesControles()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void LesControles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Fin de l'application?", "Fin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
               // MessageBox.Show("non");
                e.Cancel  =true;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNom(object sender, EventArgs e)
        {
            if (!new Regex(@"^([a-zA-Z]{0,30})$").IsMatch(textBoxNom.Text))
            {
                errorProviderNom.SetError(textBoxNom, "La saisie n'est pas conforme!Seul les lettres   de A à Z sont correctes!");

            }
            else
            {

                errorProviderNom.Clear();

            }

        }


        private void TextBox4Date(object sender, EventArgs e)
        {
            /*if (!new Regex(@"^((((0[1-9])|([1-2][0-9])|(3[0-1]))|([1-9]))_x2F(((0[1-9])|(1[0-2]))|([1-9]))\x2F([19-20])([0-9]{2})$").IsMatch(textBoxNom.Text))
            //(@"^((((0[1-9])|([1-2][0-9])|(3[0-1]))|([1-9]))= 
            {
                errorProviderNom.SetError(textBoxNom, "La saisie n'est pas conforme!Seul les lettres   de A à Z sont correctes!");

            }
            else
            {

                errorProviderNom.Clear();

            }*/

            if (textBox4Date.Text.Length == 0)
            {
                errorProviderDate.Clear();
                return;
            }



            if (new Regex(@"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$").IsMatch(textBox4Date.Text))// tryparse teste ttes les saisies datetime possible et verifie si elles sont conformes
            {
                if (DateTime.TryParse(textBox4Date.Text, out dt))//le regex verifie si elles sont au format choisis(jj-MM-yy)
                {
                    errorProviderDate.Clear();//si bon supprime le message possible d erreur

                    if (dt <= DateTime.Today)
                    {
                        errorProviderDate.SetError(textBox4Date, "La saisie est ulterieur a la date actuelle !");
                    }
                    else
                    {
                        errorProviderDate.Clear();
                    }

                    return;
                }
                else
                {
                    errorProviderDate.SetError(textBox4Date, "La date saisie n'existe pas !");
                }
                return;
            }

            errorProviderDate.SetError(textBox4Date, "La saisie n'est pas conforme!Le format correcte est --jour/--mois/----annee");//si non conforme indique la non conformitee

        }


        private void TextBox3Montant(object sender, EventArgs e)
        {

            if (textBox3Montant.Text.Length == 0)
            {
                errorProviderMontant.Clear();
            }

            textBox3Montant.Text = textBox3Montant.Text.Replace(".", ",");// remplace le caractere de saisie "." en ","


            if (!new Regex(@"^([0-9]+)([\,]?)([0-9]*)$").IsMatch(textBox3Montant.Text))//format 1 chiffre de 0 a 9 au moins 1 fois puis [\,] virgule 0 à 9,0 à x fois.
            {
                errorProviderMontant.SetError(textBox3Montant, "La saisie n'est pas conforme!");//si non conforme indique la non conformitee

            }
            else
            {
                errorProviderMontant.Clear();
            }
            return;

            //     }

        }

        private void TextBox2CP(object sender, EventArgs e)
        {
            if (textBox2CP.Text.Length == 0)
            {
                errorProviderCP.Clear();
            }

            if (!new Regex(@"^([0-9]{5})$").IsMatch(textBox2CP.Text))
            {
                errorProviderCP.SetError(textBox2CP, "La saisie n'est pas conforme!");
            }
            else
            {
                errorProviderCP.Clear();
            }
            return;
        }



        private void Valider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nom    "+textBoxNom.Text+
                "\n"+"Date    "+textBox4Date.Text+
                "\n"+"Montant    "+textBox3Montant.Text+
                "\n"+"Code Postal    "+textBox2CP.Text,
                "Validation effectuée");
        }


        private void Effacer_Click(object sender, EventArgs e)
        {
            {
                textBoxNom.Clear();
                textBox4Date.Clear();
                textBox3Montant.Clear();
                textBox2CP.Clear();
                affichages = "";//reinitialise l affichage

            }
        }

        



    }
}
