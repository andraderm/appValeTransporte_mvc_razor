using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVT_MVC_Razor.Models
{
    public class Setor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }

        public Setor() { }
        public Setor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
