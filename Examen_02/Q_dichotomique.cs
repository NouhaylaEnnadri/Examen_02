using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal class Q_Dichotomique : question
    {

        private string[] Choice = new string[] { "true", "false" };
        private vrai_faux reponse { get; set; } // reponse d'etudiant
        private string right_answer { get; set; }

        public Q_Dichotomique(string Ques, int Id, float Note) : base(Ques, Id, Note) { }


    }
}
