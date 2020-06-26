using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVT_MVC_Razor.Models
{
    public class Escala
    {
        public int Id { get; set; }
        public string EscalaTrabalho { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public Escala() { }

        public Escala(int id, string escala)
        {
            Id = id;
            EscalaTrabalho = escala;
        }
    }
}
