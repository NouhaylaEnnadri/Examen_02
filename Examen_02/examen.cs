using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen_02
{
    internal class Examen
    {
        public string Intitule { get; set; }   //Un examen a un intitulé
        public float Duree { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }

        public List<question> Ques = new List<question>();   //Un examen contient des questions

        Examen(string Intitule, float Duree, DateTime Date_debut, DateTime Date_fin)
        {
            this.Duree = Duree;
            this.Date_debut = Date_debut;
            this.Date_fin = Date_fin;
            this.Intitule = Intitule;
        }

        public List<question> GetQuestionsList()
        {
            return Ques;
        }

        public void SetQuestionsList(List<question> Ques)
        {
            this.Ques = Ques;
        }
    }
    // ajouter une nouvelle Question 
    // modifier une Question 
    //supprimer une question 
    //ouverture d'un examen 
    //fermeture d'un examen








}
