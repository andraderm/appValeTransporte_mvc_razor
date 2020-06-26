using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppVT_MVC_Razor.Models;

namespace AppVT_MVC_Razor.Data
{
    public class AppVT_MVC_RazorContext : DbContext
    {
        public AppVT_MVC_RazorContext (DbContextOptions<AppVT_MVC_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Escala> Escalas { get; set; }
        public DbSet<Setor> Setores { get; set; }
    }
}
