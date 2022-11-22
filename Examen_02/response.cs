using Examen_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_02
{
    abstract class response
    {



        private int id { get; set; } // pour identifier la question 
        private question question;

        public response(int id, question question)
        {
            this.id = id;
            this.question = question;
        }
    }
}
