using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal class QCM : question
    {


        //liste de reponse d'etudiant (il peut avoir multiple reponse pour une seule question)

        private List<R_Proposition> propositions = new List<R_Proposition>();

        //liste des proposition de question 

        private string[] proposition;

        //Pour les QCM il est possible de demander le degré de certitude
        private Certitude Certitude { get; set; }

        public QCM(string Ques, int Id, float Note, string[] proposition, List<R_Proposition> propositions) : base(Ques, Id, Note)
        {

            proposition = new string[proposition.Length];
            this.proposition = proposition;
            this.propositions = propositions;

        }

        //ajouter des nouvelles proposition a la question 
        public string[] getproposition()
        {
            return proposition;
        }
        public void setproposition(string[] proposition)
        {
            this.proposition = proposition;
        }



    }
}
