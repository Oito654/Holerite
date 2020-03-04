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
        
        public int Quant_dias_a_trabalhar(Holerite holerite, Periodo_C periodo_C)
        {
            VT_Lista vT_Lista = new VT_Lista();
            var lista = vT_Lista.GetDates(holerite, periodo_C);
            decimal dias_trabalho = 0;

            foreach (var li in lista)
            {
 
                if (li.DayOfWeek == DayOfWeek.Monday && holerite.jornada.seg)
                {
                    dias_trabalho = dias_trabalho+1;
                }
                else if (li.DayOfWeek == DayOfWeek.Tuesday && holerite.jornada.ter)
                {
                    dias_trabalho = dias_trabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Wednesday && holerite.jornada.qua)
                {
                    dias_trabalho = dias_trabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Thursday && holerite.jornada.qui)
                {
                    dias_trabalho = dias_trabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Friday && holerite.jornada.sex)
                {
                    dias_trabalho = dias_trabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Saturday && holerite.jornada.sab)
                {
                    dias_trabalho = dias_trabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Sunday && holerite.jornada.dom)
                {
                    dias_trabalho = dias_trabalho + 1;
                }
            }
            dias_trabalho = dias_trabalho - holerite.jornada.feriadosMesSeguinte;
            dias_trabalho = dias_trabalho - holerite.numeroDeFaltas;

            return (int)dias_trabalho;
        }

        public int Quant_Sexta(Holerite holerite, Periodo_C periodo_C)
        {
            VT_Lista vT_Lista = new VT_Lista();
            var lista = vT_Lista.GetDates(holerite, periodo_C);
            int quant_sex = 0;

            foreach (var li in lista)
            {
                if (li.DayOfWeek == DayOfWeek.Friday)
                {
                    quant_sex = quant_sex + 1;
                }
            }
            return quant_sex;
        }

        public double Aliquota()
        {
            double aliquota = 0.06;
            return aliquota;
        }

    }
}
