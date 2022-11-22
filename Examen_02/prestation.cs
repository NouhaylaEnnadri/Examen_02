using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal class prestation
    {
        private List<response> Prestation; // chaque prestation est compose d'un ensemble de reponse
        private etudiant candidate { get; set; } //chaque prestation appartient a un candidat 

        //  l'ensemble des réponses aux questions constituant l'examen
        public prestation(List<response> prestation)
        {

            this.Prestation = prestation;
        }

    }
}
