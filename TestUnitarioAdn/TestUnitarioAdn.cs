using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BibliotecaMutantes;

namespace TestUnitarioAdn
{
    [TestClass]
    public class TestUnitarioAdn
    {
        [TestMethod]
        public void TestBusca_Horizontal()
        { Adn adn  = new Adn();

            string[] dna = { "AAAAAA", "GGGGGG", "CCCCCC", "AGAAGG", "CCCCTA", "TCACTG" };


            adn.buscarHorizontal(dna);
            
                Assert.IsTrue(true);  
        }

        [TestMethod]
        public void TestBusca_ErrorHorizontal()
        {
            Adn adn = new Adn();

            string[] dna = { "AJASDA", "SADASF", "ASDASD", "AGAAGG", "CFCCTA", "TCACTG" };


            adn.buscarHorizontal(dna);

            Assert.IsFalse(false);
        }




        [TestMethod]
        public void TestBusca_Vertical()
        {
            Adn adn = new Adn();

            string[] dna = { "ACASDA", "ACDASF", "ACDASD", "ACAAGG", "CFCCTA", "TCACTG" };


            adn.buscarVertical(dna);

            Assert.IsTrue(true );
        }



        [TestMethod]
        public void TestBusca_ErrorVertical()
        {
            Adn adn = new Adn();

            string[] dna = { "ACAASDA", "CADASF", "DDDDSD", "SSSSSG", "CFCCTA", "TCACTG" };


            adn.buscarVertical(dna);

            Assert.IsFalse(false);
        }

        [TestMethod]
        public void TestBusca_Diagonal()
        {
            Adn adn = new Adn();

            string[] dna = { "ACAASDA", "CADASF", "DDADSD", "SSASSG", "CFCCTA", "TCACTG" };


            adn.buscarDiagonal(dna);

            Assert.IsTrue(true);
        }






        [TestMethod]
        public void TestBusca_ErrorDiagonal()
        {
            Adn adn = new Adn();

            string[] dna = { "ACAASDA", "CADASF", "DDDDSD", "SSSSSG", "CFCCTA", "TCACTG" };


            adn.buscarVertical(dna);

            Assert.IsFalse(false);
        }




    }
}
