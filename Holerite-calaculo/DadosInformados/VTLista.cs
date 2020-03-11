using HoleriteCalculo.DadosCalculados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoleriteCalculo.DadosInformados
{
    public abstract class VTLista
    {
        
        public List<DateTime> GetDates(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            var Ano = periodoCalculo.AnoSeguinte(holerite);
            var Mes = periodoCalculo.MesSeguinte(holerite);

            var valor = Enumerable.Range(1, periodoCalculo.DiasDoProximoMes(holerite)).Select(day => new DateTime(Ano, Mes, day)).ToList();
            return valor;
        }
        
        public int QuantDiasATrabalhar(Holerite holerite, PeriodoCalculo periodoCalculo)
        {

            var lista = GetDates(holerite, periodoCalculo);
            int Diastrabalho = 0;

            foreach (var li in lista)
            {
 
                if (li.DayOfWeek == DayOfWeek.Monday && holerite.jornada.Seg)
                {
                    Diastrabalho = Diastrabalho+1;
                }
                else if (li.DayOfWeek == DayOfWeek.Tuesday && holerite.jornada.Ter)
                {
                    Diastrabalho = Diastrabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Wednesday && holerite.jornada.Qua)
                {
                    Diastrabalho = Diastrabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Thursday && holerite.jornada.Qui)
                {
                    Diastrabalho = Diastrabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Friday && holerite.jornada.Sex)
                {
                    Diastrabalho = Diastrabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Saturday && holerite.jornada.Sab)
                {
                    Diastrabalho = Diastrabalho + 1;
                }
                else if (li.DayOfWeek == DayOfWeek.Sunday && holerite.jornada.Dom)
                {
                    Diastrabalho = Diastrabalho + 1;
                }
            }
            Diastrabalho = Diastrabalho - (int)holerite.jornada.FeriadosMesSeguinte;
            Diastrabalho = Diastrabalho - (int)holerite.NumeroDeFaltas;

            return Diastrabalho;
        }

        public int QuantSexta(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            var lista = GetDates(holerite, periodoCalculo);
            int quantSex = 0;

            foreach (var li in lista)
            {
                if (li.DayOfWeek == DayOfWeek.Friday)
                {
                    quantSex = quantSex + 1;
                }
            }
            return quantSex;
        }

        public double Aliquota()
        {
            double aliquota = 0.06;
            return aliquota;
        }

    }
}
