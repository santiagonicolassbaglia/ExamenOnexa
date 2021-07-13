
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaMutantes;




namespace FormsMutantes
{

    public partial class Home : Form
    {
        Adn adn = new Adn();
       
        
        public Home()
       {
             
            InitializeComponent();
        }

        public void Shuffle<T>(IList<T> values)
        {
            var n = values.Count;
            var rnd = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                var j = rnd.Next(0, i);
                var temp = values[i];
                values[i] = values[j];
                values[j] = temp;
            }
        }

        private void VerAdn_Click(object sender, EventArgs e)
        {
            var isMutantD = false;
            var isMutantV = false;
            var isMutantH = false;

            string wordsForTextBox = "";

            string[] dnaa = new string[] { "ATGCGA", "CAGTGC", "TTATGT", "AGAAGG", "CCCCTA", "TCACTG" };

            Shuffle(dnaa);
           

          isMutantD =adn.buscarDiagonal(dnaa);
          isMutantV = adn.buscarVertical(dnaa);
          isMutantH = adn.buscarHorizontal(dnaa);
           

           for (int i = 0; i < dnaa.Length; i++)
           
            {
                wordsForTextBox = wordsForTextBox + ", " + dnaa[i];
                
            }
            MostrarLetras.Text = wordsForTextBox;

            if (isMutantD || isMutantV || isMutantH)
            {
                MessageBox.Show( $"ES MUTANTE","ADN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(  $"NO ES MUTANTE","ADN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }



    }
}
