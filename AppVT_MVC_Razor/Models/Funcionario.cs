using AppVT_MVC_Razor.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVT_MVC_Razor.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Escala Escala { get; set; }
        public Setor Setor { get; set; }
        public double CustoVT { get; set; }

        public Funcionario() { }

        public Funcionario(int id, string nome, string sobrenome, string cpf, string rg,
            DateTime dataNascimento, DateTime dataAdmissao, Escala escala, Setor setor, double custoVT)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            RG = rg;
            DataNascimento = dataNascimento;
            DataAdmissao = dataAdmissao;
            Escala = escala;
            Setor = setor;
            CustoVT = custoVT;
        }

        public double CustoPeriodo(DateTime inicial, DateTime final)
        {
            if(final < DataAdmissao)
            {
                return 0.0;
            }

            int[] escalas = CalculaEscala.EscalaToDouble(this.Escala);
            return CustoVT * (final.Subtract(inicial).Days - Folgas.FolgasPeriodo(inicial, final, DataAdmissao, escalas));
        }
    }
}
