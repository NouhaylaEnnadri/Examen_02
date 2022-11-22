using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal class vrai_faux : response
    {
        Q_Dichotomique question;
        string reponse { get; set; }
        vrai_faux(Q_Dichotomique question, int id, string reponse) : base(id, question)
        {

            this.reponse = reponse;
        }
    }
}
