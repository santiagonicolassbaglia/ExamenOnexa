using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMutantes
{
    public class Adn
    {
       public string[] dna = { "ATGCGA", "CAGTGC", "TTATGT", "AGAAGG", "CCCCTA", "TCACTG" };




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

        public Adn()
        {

        }

      

        

        public bool buscarDiagonal(string[] dna)
        {
            bool isMutant = false;
            var word1 = "";
            var word2 = "";

            for (int i = 0; i < dna.Length; i++)
            {
                word1 += dna[i].Substring(dna.Length - 6 + i, 1);
            }

            for (int i = 0; i < dna.Length; i++)
            {
                word2 += dna[i].Substring(dna.Length - 1 - i, 1);
            }

            if (word1.Contains("AAAA") || word1.Contains("CCCC") || word1.Contains("GGGG"))
            {
                isMutant = true;
            }
            if (word2.Contains("AAAA") || word2.Contains("CCCC") || word2.Contains("GGGG"))
            {
                isMutant = true;
            }

            return isMutant;

        }


        public bool buscarVertical(string[] dna)
        {

            bool isMutant = false;
            string word = "";

            for (int i = 0; i < dna.Length; i++)
            { //recorro palabras

                for (int j = 0; j < dna.Length; j++)//recorro letras 
                {
                    word += dna[j].Substring(i, 1);
                }
                if (word.Contains("AAAA") || word.Contains("CCCC") || word.Contains("GGGG"))
                {
                    isMutant = true;
                    return isMutant;
                }
            }

            return isMutant;
        }

        public bool buscarHorizontal(string[] dna)
        {

            bool isMutant = false;

            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i].Contains("AAAA") || dna[i].Contains("CCCC") || dna[i].Contains("GGGG"))
                {
                    isMutant = true;
                    return isMutant;
                }
            }

            return isMutant;
        }









    }
}
