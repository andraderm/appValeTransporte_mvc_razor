using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVT_MVC_Razor.Models.Utils
{
    public static class CalculaEscala
    {
        public static int[] EscalaToDouble(Escala escala)
        {
            string[] str = escala.EscalaTrabalho.ToUpper().Split('X');
            int diasTrabalho = int.Parse(str[0]);
            int diasFolga = int.Parse(str[1]);


            if(diasTrabalho == 12) // Escala 12x36
            {
                diasTrabalho = 1;
                diasFolga = 1;
            }

            return new int[] { diasTrabalho, diasFolga };
        }
    }
}
