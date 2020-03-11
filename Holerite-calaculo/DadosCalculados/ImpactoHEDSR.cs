using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class ImpactoHEDSR : VTLista
    {
        private int QuantDomingo(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            var lista = GetDates(holerite, periodoCalculo);
            int QuantDomingos = 0;

            foreach (var li in lista)
            {
                if (li.DayOfWeek == DayOfWeek.Sunday)
                {
                    QuantDomingos = QuantDomingos + 1;
                }
            }
            return QuantDomingos;
        }

        private int DomingoMenosFeriados(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            int DomMenosFeriados;

            DomMenosFeriados = QuantDomingo(holerite, periodoCalculo) - holerite.jornada.FeriadosMesSeguinte;
            return DomMenosFeriados;
        }

        private int DomingoMaisFeriados(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            int DomMaisFeriados;

            DomMaisFeriados = QuantDomingo(holerite, periodoCalculo) + holerite.jornada.FeriadosMesSeguinte;
            return DomMaisFeriados;
        }

        public decimal ImpactoDSRHE50(Holerite holerite, HorasExtras50 horas50, PeriodoCalculo periodoCalculo, SalarioBase salarioBase, Jornada jornada)
        {
            decimal ImpactoDsrHe50;

            ImpactoDsrHe50 = (decimal)horas50.QuantHorasExtras(holerite) / (periodoCalculo.DiasDoMes(holerite) - DomingoMaisFeriados(holerite, periodoCalculo)) * DomingoMaisFeriados(holerite, periodoCalculo) * horas50.ValorHrExtra(holerite, salarioBase, jornada);
            return ImpactoDsrHe50;
        }

        public decimal ImpactoDSRHE100(Holerite holerite, HorasExtras100 horas100, PeriodoCalculo periodoCalculo, SalarioBase salarioBase, Jornada jornada)
        {
            decimal ImpactoDsrHe100;

            ImpactoDsrHe100 = (decimal)horas100.QuantHorasExtras(holerite) / (periodoCalculo.DiasDoMes(holerite) - DomingoMaisFeriados(holerite, periodoCalculo)) * DomingoMaisFeriados(holerite, periodoCalculo) * horas100.ValorHrExtra(holerite, salarioBase, jornada);
            return ImpactoDsrHe100;
        }

        public decimal ImpactoDSRHENoturno(Holerite holerite, HorasExtrasNoturno horasNoturno, PeriodoCalculo periodoCalculo, SalarioBase salarioBase, Jornada jornada, HorasExtras50 horasExtras50)
        {
            decimal ImpactoDSRHENoturno;

            ImpactoDSRHENoturno = (decimal)horasNoturno.QuantHorasExtras(holerite) / (periodoCalculo.DiasDoMes(holerite) - DomingoMaisFeriados(holerite, periodoCalculo)) * DomingoMaisFeriados(holerite, periodoCalculo) * horasNoturno.ValorHrExtra(holerite, salarioBase, jornada, horasExtras50);
            return ImpactoDSRHENoturno;
        } 

        public decimal ImpactoDSRHETotal(Holerite holerite, HorasExtrasNoturno horasNoturno, PeriodoCalculo periodoCalculo, SalarioBase salarioBase, Jornada jornada, HorasExtras50 horasExtras50, HorasExtras100 horasExtras100)
        {
            decimal ImpactoTotal;
            decimal Impacto100 = ImpactoDSRHE100(holerite, horasExtras100, periodoCalculo, salarioBase, jornada);
            decimal Impacto50 = ImpactoDSRHE50(holerite, horasExtras50, periodoCalculo, salarioBase, jornada);
            decimal ImpactoNoturno = ImpactoDSRHENoturno(holerite, horasNoturno, periodoCalculo, salarioBase, jornada, horasExtras50);

            ImpactoTotal = ImpactoNoturno + Impacto50 + Impacto100;
            
            return ImpactoTotal;
        }
    }
}
