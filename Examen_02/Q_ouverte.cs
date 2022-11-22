using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal class Q_ouverte : question
    {


        private reponse_string reponse; //reponse d'etudiant 
        public Q_ouverte(string Ques, int Id, float Note) : base(Ques, Id, Note) { }
    }
}
