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

namespace ButDuTraitement
{
    public partial class Form1 : Form
    {
        double calcul;
        double pourcent = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNom.Focus(); 
            errorName.SetError(textBoxNom, "Veuillez saisir un nom!");
            errorCapital.SetError(textBoxCapital, "Veuillez saisir un Capital.");
            listBoxPeriodRemboursement.SelectedIndex = 0;
            radioButton7.Checked=true;

        }

        private void hScrollBarMois_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            textBoxNom.Text.Trim();// trim supprime les espaces

            if (textBoxNom.Text.Length == 0)
            {
                errorName.SetError(textBoxNom, "Veuillez saisir un nom et ne pas mettre d'espace!");
            }


            else if (!new Regex(@"^([a-zA-Z]{0,30})$").IsMatch(textBoxNom.Text))
            {
                errorName.SetError(textBoxNom, "La saisie n'est pas conforme!\n" +
                    "Seul les lettres de A à Z sont correctes!");

            }
            else
            {

                errorName.Clear();

            }

        }

        private void textBoxCapital_TextChanged(object sender, EventArgs e)
        {
            textBoxCapital.Text.Trim();
            if (textBoxCapital.Text.Length == 0)
            {
                errorCapital.SetError(textBoxCapital, "Veuillez saisir un Capital!");
            }
            else if (!new Regex(@"^([0-9]{1,10})$").IsMatch(textBoxCapital.Text))
            {
                errorCapital.SetError(textBoxCapital, "Seul les chiffres entiers sont correctes!" +
                    "10 chiffres maximum autorisés");
            }
            else
            {
                errorCapital.Clear();
            }
        }

        private void listBoxPeriodRemboursement_SelectedIndexChanged(object sender, EventArgs e)
        {
            hScrollBarMois.Value = 1;//initialisation du scrollbar mois
            
            hScrollBarMois_Scroll(sender, e as ScrollEventArgs);//met à jour en appelant la methode ci-dessous

            hScrollBarMois.Value = hScrollBarMois.SmallChange;//la valeur de la scrollbar est egale au smallchange

            hScrollBarMois_Scroll(sender, e as ScrollEventArgs);//met à jour en appelant la methode ci-dessous

        }

        private void hScrollBarMois_Scroll(object sender, ScrollEventArgs e)
        {

            LabelMois.Text = hScrollBarMois.Value.ToString();

            if (listBoxPeriodRemboursement.SelectedIndex == 0)
            {
                hScrollBarMois.SmallChange = 1;
                hScrollBarMois.LargeChange = 10;
                labelDureeRemboursement.Text = (hScrollBarMois.Value / 1).ToString();//convertie la valeur en string
            }
            else if (listBoxPeriodRemboursement.SelectedIndex == 1)
            {
                hScrollBarMois.SmallChange = 2;
                hScrollBarMois.LargeChange = 20;
                labelDureeRemboursement.Text = (hScrollBarMois.Value / 2).ToString();
            }
            else if (listBoxPeriodRemboursement.SelectedIndex == 2)
            {
                hScrollBarMois.SmallChange = 3;
                hScrollBarMois.LargeChange = 30;
                labelDureeRemboursement.Text = (hScrollBarMois.Value / 3).ToString();
            }
            else if (listBoxPeriodRemboursement.SelectedIndex == 3)
            {
                hScrollBarMois.SmallChange = 6;
                hScrollBarMois.LargeChange = 60;
                labelDureeRemboursement.Text = (hScrollBarMois.Value / 6).ToString();
            }
            else if (listBoxPeriodRemboursement.SelectedIndex == 4)
            {
                hScrollBarMois.SmallChange = 12;
                hScrollBarMois.LargeChange = 120;
                labelDureeRemboursement.Text = (hScrollBarMois.Value / 12).ToString();
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                pourcent = Convert.ToDouble(7d / 100 / hScrollBarMois.SmallChange);//convertie en "double"(nombre a virgule plus long) le calcul
            }
           
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            
                {
                    pourcent = Convert.ToDouble(8d / 100 / hScrollBarMois.SmallChange);//convertie en "double"(nombre a virgule plus long) le calcul
                }
            
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                pourcent = Convert.ToDouble(9d / 100 / hScrollBarMois.SmallChange);//convertie en "double"(nombre a virgule plus long) le calcul
            }
        }

        private void labelRemboursement_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            
            int K = int.Parse(textBoxCapital.Text);
            double n = int.Parse(labelDureeRemboursement.Text);

            
            // 

            calcul = (K * (pourcent / (1- Math.Pow((1 + pourcent), -n))));

            labelRemboursement.Text = calcul.ToString();

            //Math.Pow(2, 3);
        }
    }
}
