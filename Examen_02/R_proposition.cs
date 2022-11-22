using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal class R_Proposition : response
    {
        private List<response> propositions = new List<response>(); // liste de reponse d'etudaint
        private Certitude Certitude { get; set; } //Pour les QCM il est possible de demander le degré de certitude
        private QCM question;
        public R_Proposition(List<response> propositions, int id, question ques) : base(id, ques)
        {
            this.propositions = propositions;

        }
    }
}
