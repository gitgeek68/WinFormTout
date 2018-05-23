using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//using indispensable jusqu a la fin à ajouter
using System.Xml;
using System.Xml.Serialization;
using System.ServiceModel;
using System.Runtime.Serialization;
using CRMTOOLS;//using crée pour utiliser les methodes CRM Tools


namespace absences
{

    [DataContract]//contrat de donnees
    public class Absence
    {
        private Absence()
        {

        }

        [DataMember(Name = "Debut")]//donnees Membre "Debut"
        private DateTime debut;

        public DateTime Debut
        {
            get { return debut; }
            set { debut = value; }
        }

        [DataMember(Name = "Fin")]
        private DateTime fin;

        public DateTime Fin
        {
            get { return fin; }
            set { fin = value; }
        }



        [DataMember(Name = "Id")]
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }




        private static List<Absence> listeAbsences = new List<Absence>();//une nouvelles list accessible par  tous car en static

        private Absence(DateTime _debut, DateTime _fin, int _id)//Method pour Absence
        {
            debut = _debut;
            fin = _fin;
            id = _id;
        }

        public static Absence Ajouter(int _id, DateTime _debut, DateTime _fin)//Method pour Ajouter a absence
        {
            for (int i = 0; i < listeAbsences.Count; i++)
            {
                if ((listeAbsences[i].id == _id) && (listeAbsences[i].debut == _debut) && (listeAbsences[i].fin == _fin))
                {
                    return null;
                }

            }

            Absence abs = new Absence();//creation d une nvelle absence
            abs.id = _id;
            abs.debut = _debut;
            abs.fin = _fin;

            listeAbsences.Add(abs);

            return abs;
        }







        public static bool Effacer(Absence _absence)
        {
            if (listeAbsences.Contains(_absence))//un bool pour verifier si listAbsence contient _absence
            {

                listeAbsences.Remove(_absence);// listeAbsences efface _absence 

                return true; //et retourne vrai
            }
            return false;
        }



        public static List<Absence> Lire(DateTime _debut, DateTime _fin)
        {
            List<Absence> resultat = new List<Absence>();//ici on crée une nouvelleliste qui affichera le resultat de la recherche


            for (int i = 0; i < listeAbsences.Count; i++)// pour parcourir la listeAbsences deja cree plus haut
            {
                if ((listeAbsences[i].debut < _fin) && (listeAbsences[i].fin > _debut))//comparaison des 2 listes pour resortir juste celle voulu
                {
                    resultat.Add(listeAbsences[i]);//resultat recupere tout les absences comprisent entre le _debut et _fin
                }
            }

            return resultat;//retourne le resultat
        }





        public static List<Absence> Lire(DateTime _debut)
        {
            List<Absence> resultatDebut = new List<Absence>();//ici on crée une nouvelleliste qui affichera le resultat de la recherche


            for (int i = 0; i < listeAbsences.Count; i++)// pour parcourir la listeAbsences deja cree plus haut
            {
                if (listeAbsences[i].fin > _debut)// verifie que La fin n est pas superieur au debut
                {
                    resultatDebut.Add(listeAbsences[i]);//resultat recupere tout les absences comprisent entre le _debut et _fin
                }
            }

            return resultatDebut;
        }




        public static Absence Modifier(Absence _abs)
        {
            //DataContractSerializer serial = new DataContractSerializer();
            //    StringBuilder xml = new StringBuilder("<Absences>");

            //    xml.Append("<id>");
            //    xml.Append(_abs.id.ToString());
            //    xml.Append("</id>");
            //    xml.Append("<debut>");
            //    xml.Append(_abs.debut.ToString());
            //    xml.Append("</debut>");
            //    xml.Append("<Fin>");
            //    xml.Append(_abs.fin.ToString());
            //    xml.Append("</fin>");
            string nomdefichier = _abs.id.ToString("000") + "_" + _abs.debut.ToString("yyyy-MM-dd");//format id numerique ("000")=centaines,et format annee ("yyyy"=annee-"MM"=mois-"dd"=jour)
            string dossierUtilisateur = Environment.GetFolderPath//nom du dossier et chemin d' enregistrement
                (Environment.SpecialFolder.UserProfile)
                + "\\AppData\\Local\\GestionAbsence";

            SerializeTools.Serializxml(_abs as Object, dossierUtilisateur, nomdefichier, _abs.GetType());//Methode de serialise tools 

            /* if (!Directory.Exists(dossierUtilisateur))
             {

                 Directory.CreateDirectory(dossierUtilisateur);


             }

             DataContractSerializer serial = new DataContractSerializer(typeof(Absence));

             TextWriter texte = new StreamWriter(dossierUtilisateur + "\\Texte.xml");

             XmlWriter XmlWrite = XmlWriter.Create(texte);

             serial.WriteObject(XmlWrite, _abs);

             XmlWrite.Close();
             texte.Close();*/

            return _abs;





        }
        public static void Load()
        {

            string dossierUtilisateur = Environment.GetFolderPath
            (Environment.SpecialFolder.UserProfile)
            + "\\AppData\\Local\\GestionAbsence";

            XmlReader reader = XmlReader.Create(dossierUtilisateur + "\\ListeAbsences.xml");
            while (reader.Read())
            {
                int idTemp = 0;
                DateTime debutTemp = new DateTime();
                DateTime finTemp = new DateTime();

                if ((reader.Name == "Debut") && (reader.NodeType != XmlNodeType.EndElement))
                {

                }
            }






            //XmlReader reader = XmlReader.Create("personne.xml");//XmlReader de nom reader est cree pour lire le fichier "Personne"
            ////while (reader.Read())//boucle tant que reader lit
            //{
            //    int nbAttributs = reader.AttributeCount; //correspond au nombre d'attributs du noeud actuel
            //    Console.WriteLine(reader.Value);//affiche la valeur lu du noeud actuel
            //    Console.WriteLine(reader.LocalName);// affiche le localName de chaque noeud actuel
            //    for (int i = 0; i < nbAttributs; i++)//parcours les attributs du noeud actuel
            //    {
            //        reader.MoveToNextAttribute();//permet de bouger jusqu' a l'attribut suivant
            //        Console.WriteLine(reader.LocalName + " " + reader.Value); //affiche les noms de l'attributs et  sa valeur
            //    }
            //}

            Console.ReadKey();


        }


        public static void SaveList()
        {
            for (int i = 0; i < listeAbsences.Count - 1; i++)
            {
                // sauvegarde l'indice dont l'id est le + petit
                int indiceTemp = i;
                Absence absTemp = listeAbsences[i];

                for (int j = i + 1; j < listeAbsences.Count; j++)
                {
                    if (absTemp.id > listeAbsences[j].id)
                    {
                        indiceTemp = j;
                        absTemp = listeAbsences[j];
                    }
                } 

                if (indiceTemp != i)
                {
                    Absence absTemp2 = listeAbsences[indiceTemp];
                    listeAbsences[indiceTemp] = listeAbsences[i];
                    listeAbsences[i] = absTemp2;
                }
            }

            string dossierUtilisateur = Environment.GetFolderPath
          (Environment.SpecialFolder.UserProfile)
          + "\\AppData\\Local\\GestionAbsence";

            SerializeTools.Serializxml(listeAbsences as Object, dossierUtilisateur, "ListeAbsences.xml", listeAbsences.GetType());

        }
    }
}

