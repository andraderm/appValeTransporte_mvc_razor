using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVT_MVC_Razor.Models.Utils
{
    public static class Folgas
    {
        public static int FolgasPeriodo(DateTime inicial, DateTime final, DateTime admissao, int[] escalas)
        {
            List<DateTime> diasFolgaTotal = new List<DateTime>();
            int diasTotal = final.Subtract(admissao).Days;

            for(int i = admissao.Day - 1 + escalas[0]; i <= diasTotal; i += escalas[0])
            {
                for(int j = 1; j <= escalas[1]; j++)
                {
                    diasFolgaTotal.Add(admissao.AddDays(i));
                    i += 1;
                }
            }

            List<DateTime> diasFolgaPeriodo = diasFolgaTotal.FindAll(f => f >= inicial && f <= final);
            List<DateTime> totalFolgasPeriodo = diasFolgaPeriodo.Union(Feriados.FeriadosPeriodo(inicial, final)).ToList();
            return totalFolgasPeriodo.Count;
        }
    }
}
