using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class FGTS
    {
        double Aliquota = 0.08;
        private decimal BaseDeCalculoFGTS(Holerite holerite, ImpactoHEDSR impactoHEDSR, HorasExtras100 horasExtras100, HorasExtras50 horasExtras50, HorasExtrasNoturno horasExtrasNoturno, SalarioBase salarioBase, PeriodoCalculo periodoCalculo, Faltas faltas, Jornada jornada )
        {
            decimal BaseCalculoFGTS;
            decimal Impacto_total = impactoHEDSR.ImpactoDSRHETotal(holerite, horasExtrasNoturno, periodoCalculo, salarioBase, jornada, horasExtras50, horasExtras100);
            decimal SalarioBase = salarioBase.SalarioBaseProporcional(holerite, periodoCalculo);
            decimal Faltas = faltas.DescontoFaltas(holerite, salarioBase, periodoCalculo);
            decimal HorasExtras50 = (decimal)horasExtras50.HorasExtrasTotal(holerite, salarioBase, jornada);
            decimal HorasExtras100 = (decimal)horasExtras100.HorasExtrasTotal(holerite, salarioBase, jornada);
            decimal HorasExtrasNoturno = (decimal)horasExtrasNoturno.HorasExtrasTotal(holerite, salarioBase, jornada, horasExtras50);

            BaseCalculoFGTS = SalarioBase - Faltas + Impacto_total + HorasExtras50 + HorasExtras100 + HorasExtrasNoturno;

            return BaseCalculoFGTS;
        }

        public double FGTS_Mes(Holerite holerite, ImpactoHEDSR impactoHEDSR, HorasExtras100 horasExtras100, HorasExtras50 horasExtras50, HorasExtrasNoturno horasExtrasNoturno, SalarioBase salarioBase, PeriodoCalculo periodoCalculo, Faltas faltas, Jornada jornada)
        {
            double FgtsMes;
            double BaseFgts = (double)BaseDeCalculoFGTS(holerite, impactoHEDSR, horasExtras100, horasExtras50, horasExtrasNoturno, salarioBase, periodoCalculo, faltas, jornada);

            FgtsMes = BaseFgts * Aliquota;

            return FgtsMes;
        }
        
    }
}
