using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMTOOLS;
using System.Windows.Forms;

namespace ToutEmballe
{
    class Production
    {
        List<Box> caissesNonConformes;
        List<Box> caisses;
        int nbredecaisses;
        int nbrecaissesheure;
        int nbredefautderniereheure;
        float taux_defaut_heure;
        bool state;
        string typeBox;


        public int Nbredecaisses
        {
            get => nbredecaisses;
            set => nbredecaisses = value;
        }

        public int Nbrecaissesheure
        {
            get => nbrecaissesheure;
            set => nbrecaissesheure = value;
        }
        public int Nbredefautderniereheure { get => nbredefautderniereheure; set => nbredefautderniereheure = value; }
        public bool State { get => state; set => state = value; }

        public void Update()
        {
            nbredefautderniereheure = 0;// initialisation de compteur

            for (int i = 0; i < nbrecaissesheure; i++)
            {



                if (state == true)//si la production est sur true,
                {
                    if (caisses.Count >= Nbredecaisses)//si la longueurs de la liste de caisse est >= au nombres de caisses desirées
                    {
                        state = false;//la production se stop
                        return;//sortie de la boucle
                    }


                    Box b = new Box();//creation de box

                    Alea hasard = Alea.Instance();//creation d un aléatoire de nom hasard

                    double d = hasard.NextDouble();//le chiffre aléatoire sera entre 0 et 1

                    if (d > taux_defaut_heure)
                    {
                        caisses.Add(b);
                    }
                    else
                    {
                        caissesNonConformes.Add(b);
                        nbredefautderniereheure++;
                    }



                }
            }
        }

        public void Demarrer()
        {

            state = true;
        }
        public void Arreter()
        {
            state = false;
        }

        public void Continuer()
        {
            state = true;

        }

        public void Quitter()
        {

        }


        public Production(int _nbredecaisses, int _nbrecaissesheure, float _taux_defaut_heure, string _typeBox)
        {
            typeBox = _typeBox;
            Nbrecaissesheure = _nbrecaissesheure;
            Nbredecaisses = _nbredecaisses;
            caisses = new List<Box>();
            caissesNonConformes = new List<Box>();
            taux_defaut_heure = _taux_defaut_heure;

        }

        public int GetNbCaisseCourante()
        {
            return this.caisses.Count;
        }

        public int GetNbCaisseNonConforme()
        {
            return this.caissesNonConformes.Count;
        }


        public bool ATropDErreur()
        {
            if (caisses.Count > 0)
            {
                double d = ((double)caissesNonConformes.Count / (double)caisses.Count * 100.00);

                double e = (double)taux_defaut_heure * 1000.00;

                //MessageBox.Show(d.ToString() + "/" + e.ToString());
                
                return (d > e);
            }

            return false;
        }
    }
}
