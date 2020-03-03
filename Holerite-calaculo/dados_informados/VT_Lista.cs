using Holerite_calaculo.dados_calculados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holerite_calaculo.dados_informados
{
    class VT_Lista
    {
        
        public List<DateTime> GetDates(Holerite holerite, Periodo_C periodo_C)
        {
            var ano = periodo_C.Ano_Seguinte(holerite);
            var mes = periodo_C.Mes_Seguinte(holerite);

            var valor = Enumerable.Range(1, periodo_C.Dias_do_Proximo_Mes(holerite))  // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(ano, mes, day)) // Map each day to a date
                             .ToList(); // Load dates into a list

            return valor;
        }
        
        public void capivara(Holerite holerite, Periodo_C periodo_C)
        {
            VT_Lista vT_Lista = new VT_Lista();
            var lista = vT_Lista.GetDates(holerite, periodo_C);

            foreach (var li in lista)
            {

                
                if (li.DayOfWeek == DayOfWeek.Monday && holerite.jornada.seg)
                {

                } 

            }
            
            

        }

    }
}
