using AppVT_MVC_Razor.Models;
using AppVT_MVC_Razor.Models.Utils;
using NUnit.Framework;
using System;

namespace AppVT_Mvc_Razor_Testes
{
    public class Tests
    {
        public Funcionario f1;
        public Escala e1;
        public Setor s1;

        [SetUp]
        public void Setup()
        {
            e1 = new Escala(1, "5x2");
            s1 = new Setor(1, "Manutenção");
            f1 = new Funcionario(1, "Fábio", "Torres", "123456789-00", "12345678-9",
                new DateTime(1989, 11, 24), new DateTime(2018, 11, 1), e1, s1, 10.00);
        }

        [Test]
        public void TesteCalculaEscala()
        {
            int[] escalas = CalculaEscala.EscalaToDouble(f1.Escala);
            int[] esperado = new int[] { 5, 2 };
            Assert.AreEqual(esperado, escalas);
        }

        [Test]
        public void TesteDiasTrabalhadosNoPeriodo()
        {
            DateTime inicial = new DateTime(2018, 11, 1);
            DateTime final = new DateTime(2018, 12, 31);
            double custo = f1.CustoPeriodo(inicial, final);
            double valorEsperado = f1.CustoVT * 42;
            Assert.AreEqual(valorEsperado, custo);
        }
    }
}