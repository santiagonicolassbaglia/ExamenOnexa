using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_mutantes
{
    class Adn
    {
        string[]dna= { "ATGCGA", "CAGTGC", "TTATGT", "AGAAGG", "CCCCTA", "TCACTG" };
        Random rd = new Random();

         

        public string[] Dna
        {
            get
            {
                return dna;
            }

            set
            {
                this.dna = value;
            }

        }

        

        public Adn(string[] adn)
        {
            this.dna = adn;
        }



 

       
    }
}
