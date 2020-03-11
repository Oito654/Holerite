using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class INSS : TabelaINSS
    {
      public decimal SalarioContribuicaINSS(Holerite holerite, SalarioBase salarioBase, PeriodoCalculo periodoCalculo, Faltas faltas, HorasExtras50 horasExtras50, HorasExtras100 horasExtras100, HorasExtrasNoturno horasExtrasNotruno, ImpactoHEDSR impactoHEDSR, Jornada jornada)
        {
            decimal SalarioContribuicaoINSS;
            decimal SalarioProporcional = salarioBase.SalarioBaseProporcional(holerite, periodoCalculo);
            decimal DescFaltas = faltas.DescontoFaltas(holerite, salarioBase, periodoCalculo);
            decimal ImpactoTotal = impactoHEDSR.ImpactoDSRHETotal(holerite, horasExtrasNotruno, periodoCalculo, salarioBase, jornada, horasExtras50, horasExtras100);
            decimal HrsExtras50 = (decimal)horasExtras50.HorasExtrasTotal(holerite, salarioBase, jornada);
            decimal HrsExtras100 = (decimal)horasExtras100.HorasExtrasTotal(holerite, salarioBase, jornada);
            decimal HrsExtrasNoturno = (decimal)horasExtrasNotruno.HorasExtrasTotal(holerite, salarioBase, jornada, horasExtras50);

            decimal condição = SalarioProporcional - DescFaltas + ImpactoTotal + HrsExtras50 + HrsExtras100 + HrsExtrasNoturno;
            if (condição < SalarioMax())
            {
                SalarioContribuicaoINSS = (holerite.SalarioBase - DescFaltas + ImpactoTotal + HrsExtras50 + HrsExtras100 + HrsExtrasNoturno) / periodoCalculo.DiasDoMes(holerite) * periodoCalculo.DiasTrabalhados(holerite);
            }
            else
            {
                SalarioContribuicaoINSS = SalarioMax();
            }

            return SalarioContribuicaoINSS;
        }

        private double Aliquota(Holerite holerite, SalarioBase salarioBase, PeriodoCalculo periodoCalculo, Faltas faltas, HorasExtras50 horasExtras50, HorasExtras100 horasExtras100, HorasExtrasNoturno horasExtrasNoturno, ImpactoHEDSR impactoHEDSR, Jornada jornada)
        {
            double aliquota;
            decimal SalarioContribuicaoINSS = SalarioContribuicaINSS(holerite, salarioBase, periodoCalculo, faltas, horasExtras50, horasExtras100, horasExtrasNoturno, impactoHEDSR, jornada);

            if(SalarioContribuicaoINSS > SalarioAte2())
            {
                aliquota = Aliquota3();
            } else if(SalarioContribuicaoINSS > SalarioAte1())
            {
                aliquota = Aliquota2();
            }
            else
            {
                aliquota = Aliquota1();
            }

            return aliquota;
        }

        public decimal _INSS(Holerite holerite, SalarioBase salarioBase, PeriodoCalculo periodoCalculo, Faltas faltas, HorasExtras50 horasExtras50, HorasExtras100 horasExtras100, HorasExtrasNoturno horasExtrasNoturno, ImpactoHEDSR impactoHEDSR, Jornada jornada)
        {
            decimal Inss;
            decimal SalarioContribuicaoINSS = SalarioContribuicaINSS(holerite, salarioBase, periodoCalculo, faltas, horasExtras50, horasExtras100, horasExtrasNoturno, impactoHEDSR, jornada);
            double aliquota = Aliquota(holerite, salarioBase, periodoCalculo, faltas, horasExtras50, horasExtras100, horasExtrasNoturno, impactoHEDSR, jornada);

            Inss = SalarioContribuicaoINSS * (decimal)aliquota;

            return Inss;
        }
    }
}
