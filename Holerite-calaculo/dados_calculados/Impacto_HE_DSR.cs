using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
    class Impacto_HE_DSR
    {
        public int Quant_Dom(Holerite holerite, Periodo_C periodo_C)
        {
            VT_Lista vT_Lista = new VT_Lista();
            var lista = vT_Lista.GetDates(holerite, periodo_C);
            int quant_dom = 0;

            foreach (var li in lista)
            {
                if (li.DayOfWeek == DayOfWeek.Friday)
                {
                    quant_dom = quant_dom + 1;
                }
            }
            return quant_dom;
        }

        public int Domingo_Menos_Feriados(Holerite holerite, Periodo_C periodo_C)
        {
            int dom_menos_feriados;

            dom_menos_feriados = Quant_Dom(holerite, periodo_C) - holerite.jornada.feriadosMesSeguinte;
            return dom_menos_feriados;
        }

        public int Domingo_Mais_Feriados(Holerite holerite, Periodo_C periodo_C)
        {
            int dom_mais_feriados;

            dom_mais_feriados = Quant_Dom(holerite, periodo_C) + holerite.jornada.feriadosMesSeguinte;
            return dom_mais_feriados;
        }
    }
}
