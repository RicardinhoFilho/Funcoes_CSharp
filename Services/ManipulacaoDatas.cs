using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Funcoes.Services
{
   public class ManipulacaoDatas
    {
        public static DateTime UltimoDia(int mes,  int ano  )
        {
            var data = new DateTime(ano, mes, 1);
            var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia);
            return dataUltimoDia;
        }
    }
}
