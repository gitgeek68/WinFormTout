using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (null == btn)
                return;
            int hauteur = Height;
            int largeur = Width;

            if (!timer1.Enabled)
            {
                timer1.Start();
                return;
                //button2.Visible = true;
                //button2.Location = new Point (40,40);
            }


            button1.Visible = true;
            button2.Enabled = false;
            button2.Location = new Point(30, 30);

            btn.Text = " CRM ";
        }





        private void button2_Click(object sender, EventArgs e)
        {
            //Button btn2 = sender as Button;
            //if (null == btn2)
            //    return;

            //button1.Visible = true;
            //button2.Enabled = true;
            //button2.Location = new Point(40, 40);

            //btn2.Text = " 2 ";

        }

        
        

        private void timer1_Tick(object sender, EventArgs e)

        {

            if (button2.Location.Y >= (Height - button2.Size.Height))//si le bouton2.sa position en Y(hauteur) est superieur ou egal a la hauteur de la fenetre- la position superieur gauche(y) de bouton2
            {
                button2.Location = new Point(12, 41);//nvelle position
                //MessageBox.Show("!!!");
            }
            else
            {
                button2.Visible = true;
                button2.Location = new Point(12, button2.Location.Y+10);
            }
            //MessageBox.Show("salut");
         
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
