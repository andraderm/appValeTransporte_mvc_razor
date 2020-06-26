using AppVT_MVC_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVT_MVC_Razor.Data
{
    public class SeedingService
    {
        private AppVT_MVC_RazorContext _context;

        public SeedingService(AppVT_MVC_RazorContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Funcionarios.Any() || _context.Escalas.Any() || _context.Setores.Any())
            {
                return;
            }

            Escala e1 = new Escala(new int(), "5x2");
            Escala e2 = new Escala(new int(), "6x1");
            Escala e3 = new Escala(new int(), "6x2");
            Escala e4 = new Escala(new int(), "12x36");

            Setor s1 = new Setor(new int(), "Vendas");
            Setor s2 = new Setor(new int(), "Manutenção");
            Setor s3 = new Setor(new int(), "Estoque");
            Setor s4 = new Setor(new int(), "Segurança");
            Setor s5 = new Setor(new int(), "Brigada de Incêndio");
            Setor s6 = new Setor(new int(), "Administração");
            Setor s7 = new Setor(new int(), "Recepção");
            Setor s8 = new Setor(new int(), "Entregas");
            Setor s9 = new Setor(new int(), "Limpeza");

            Funcionario f1 = new Funcionario(new int(), "Fábio", "Torres", "123456789-00", "1234567-8", new DateTime(1989, 11, 24), new DateTime(2018, 2, 15), e1, s1, 8.70);
            Funcionario f2 = new Funcionario(new int(), "Carlos", "Alberto", "123456789-00", "1234567-8", new DateTime(1978, 8, 3), new DateTime(2014, 5, 2), e3, s2, 10.40);
            Funcionario f3 = new Funcionario(new int(), "Antônio", "Rodrigues", "123456789-00", "1234567-8", new DateTime(1985, 5, 15), new DateTime(2017, 9, 22), e2, s3, 9.60);
            Funcionario f4 = new Funcionario(new int(), "Marcela", "Silva", "123456789-00", "1234567-8", new DateTime(1986, 10, 4), new DateTime(2018, 2, 15), e4, s4, 8.70);
            Funcionario f5 = new Funcionario(new int(), "Fabiana", "Figueiredo", "123456789-00", "1234567-8", new DateTime(1992, 4, 28), new DateTime(2019, 4, 20), e4, s5, 8.70);
            Funcionario f6 = new Funcionario(new int(), "Lucas", "Oliveira", "123456789-00", "1234567-8", new DateTime(1983, 2, 11), new DateTime(2019, 4, 20), e1, s6, 9.60);
            Funcionario f7 = new Funcionario(new int(), "Rebecca", "Alves", "123456789-00", "1234567-8", new DateTime(1985, 8, 30), new DateTime(2019, 4, 20), e1, s7, 12.90);
            Funcionario f8 = new Funcionario(new int(), "Altair", "Loureiro", "123456789-00", "1234567-8", new DateTime(1993, 7, 21), new DateTime(2018, 2, 15), e2, s8, 8.70);
            Funcionario f9 = new Funcionario(new int(), "Juliana", "Santos", "123456789-00", "1234567-8", new DateTime(1990, 12, 1), new DateTime(2015, 1, 5), e3, s9, 12.90);
            Funcionario f10 = new Funcionario(new int(), "Gabriela", "Barros", "123456789-00", "1234567-8", new DateTime(1989, 11, 6), new DateTime(2018, 2, 15), e3, s1, 10.40);
            Funcionario f11 = new Funcionario(new int(), "Diego", "Andrade", "123456789-00", "1234567-8", new DateTime(1979, 4, 9), new DateTime(2014, 5, 2), e3, s2, 8.70);
            Funcionario f12 = new Funcionario(new int(), "Yuki", "Shiori", "123456789-00", "1234567-8", new DateTime(1978, 1, 13), new DateTime(2014, 5, 2), e1, s3, 8.70);
            Funcionario f13 = new Funcionario(new int(), "Victor", "Lima", "123456789-00", "1234567-8", new DateTime(1980, 2, 2), new DateTime(2014, 5, 2), e1, s4, 8.70);

            _context.Escalas.AddRange(e1, e2, e3, e4);
            _context.Setores.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9);
            _context.Funcionarios.AddRange(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13);

            _context.SaveChanges();
        }
    }
}
