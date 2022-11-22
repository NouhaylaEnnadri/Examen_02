using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    internal abstract class question
    {

        public string Ques { get; set; }
        public int Id { get; set; }  // chaque question a un ID pour fpour faciliter sa reconnaissance avec sa solution
        public float Note { get; set; } // La note attribue a chaque question 

        public question(string Ques, int Id, float Note)
        {
            this.Ques = Ques;
            this.Id = Id;
            this.Note = Note;

        }


    }
}
