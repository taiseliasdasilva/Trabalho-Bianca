using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhoBianca;

namespace TrabalhoTeste
{
    [TestClass]
    public class TesteAluno
    {

        [TestMethod]
        public void TestedeIdadePositivo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990,04,01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);

            Assert.IsTrue(a1.idade() > 18);

        }

        [TestMethod]
        public void TestedeIdadeNegativo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);

            Assert.IsTrue(a2.idade() > 0);

        }

        [TestMethod]
        public void TestedeNomePositivo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);

            Assert.AreEqual(a1.Nome, "Felipe");

        }

        [TestMethod]
        public void TestedeNomeNegativo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);

            Assert.AreNotEqual(a2.nomeCompleto(),a2.Nome+a2.Sobrenome);

        }

        [TestMethod]
        public void TestedeValidaNomePositivo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);

            Assert.AreNotEqual(a1.Sobrenome, a1.validaNome());

        }

        [TestMethod]
        public void TestedeValidaNomeNegativo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);

            a1.validaNome();

            Assert.IsTrue(a1.validaNome() < 0);

        }

        [TestMethod]
        public void TestedeErroValidacaoPositivo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);

            Assert.AreSame("Este nome não pode ser usado contém caracter 'Ç' que é inválido no inicio do nome", a1.erroValidacao(a1.validaNome()));

        }

        [TestMethod]
        public void TestedeErroValidacaoNegativo()
        {
            Aluno a1 = new Aluno();

            a1.Codigo = 1;
            a1.Nome = "Felipe";
            a1.Sobrenome = "Vozgeral Çanca";
            a1.DataNasc = new DateTime(1990, 04, 01);

            Aluno a2 = new Aluno();

            a2.Codigo = 2;
            a2.Nome = "Alin@";
            a2.Sobrenome = "Branca";
            a2.DataNasc = new DateTime(2020, 01, 01);

            Aluno a3 = new Aluno();

            a3.Codigo = 3;
            a3.Nome = "Alfredo";
            a3.Sobrenome = "Sella III";
            a3.DataNasc = new DateTime(1986, 03, 12);


            Assert.AreSame("Este nome não pode ser usado contém caracter", a1.erroValidacao(a1.validaNome()));


        }

    }
}
