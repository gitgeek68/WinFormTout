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
    public partial class Checkboxes : Form
    {
        static int compteur = 0;
        public Checkboxes()
        {
            InitializeComponent();
            compteur++;
            Text = "ChekecBox " + compteur.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                groupBox1.Enabled = true;
                labelRecopie.Visible = true;
            }
            else
            {

                labelRecopie.Visible = false;
                groupBox1.Enabled = false;
            }

            labelRecopie.Text = textBox1.Text;
        }

        

        private void labelRecopie_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                labelRecopie.ForeColor = Color.Red;
            }

        }

        private void caractere(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                carac.Visible = true;

            }
            return;

           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                labelRecopie.ForeColor = Color.White;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                labelRecopie.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           // groupBox2.Visible = checkBox1.Checked;identique ci dessous  
            if (checkBox1.Checked)
            {
                groupBox2.Visible = checkBox1.Checked;

            }
            return;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelRecopie.BackColor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                labelRecopie.BackColor = Color.Green;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                labelRecopie.BackColor = Color.Blue;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                groupBox4.Visible = true;

            }
            return;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked) 
            {
               labelRecopie.Text = labelRecopie.Text.ToLower();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
               labelRecopie.Text = labelRecopie.Text.ToUpper();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
