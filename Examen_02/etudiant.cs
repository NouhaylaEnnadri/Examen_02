using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal class etudiant

    {
        public string CIN { get; set; }
        public string nom { get; set; }
        public string Prenom { get; set; }

        private prestation prestation; // La prestation d'un etudiant  qui a passé un examen

        public  etudiant() { }
        public etudiant(string CIN, string nom, string Prenom)
        {
            this.CIN = CIN;
            this.nom = nom;
            this.Prenom = Prenom;
        }

        public void setprestation(List<response> prestation)
        {
            this.prestation = new prestation(prestation);
        }
        public prestation getprestation()
        {
            return prestation;

        }
    }
}
