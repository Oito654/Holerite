using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class IR : TabelaIR
    {
        private decimal BaseCalculoIR(Holerite holerite, SalarioBase salarioBase, ImpactoHEDSR impactoHEDSR, HorasExtras50 horasExtras50, HorasExtras100 horasExtras100, HorasExtrasNoturno horasExtrasNoturno, INSS iNSS, PeriodoCalculo periodoCalculo, Jornada jornada, Faltas faltas)
        {
            decimal BaseCalculoIR;
            decimal SalarioBaseProporcional = salarioBase.SalarioBaseProporcional(holerite, periodoCalculo);
            decimal ImpactoTotal = impactoHEDSR.ImpactoDSRHETotal(holerite, horasExtrasNoturno, periodoCalculo, salarioBase, jornada, horasExtras50, horasExtras100);
            decimal HrsExtras50 = (decimal)horasExtras50.HorasExtrasTotal(holerite, salarioBase, jornada);
            decimal HrsExtras100 = (decimal)horasExtras100.HorasExtrasTotal(holerite, salarioBase, jornada);
            decimal HrsExtrasNoturno = (decimal)horasExtrasNoturno.HorasExtrasTotal(holerite, salarioBase, jornada, horasExtras50);
            decimal INSS = iNSS._INSS(holerite, salarioBase, periodoCalculo, faltas, horasExtras50, horasExtras100, horasExtrasNoturno, impactoHEDSR, jornada);
            decimal PensaoAlimenticia = holerite.PensaoAlimenticia;
            decimal DependentesIR = holerite.DependentesIR;

            BaseCalculoIR = SalarioBaseProporcional + ImpactoTotal + HrsExtras50 + HrsExtras100 + HrsExtrasNoturno + INSS + PensaoAlimenticia + DependentesIR * DeducaoPadrao5();
            return BaseCalculoIR;
        }

        private decimal FaixaIR(Holerite holerite, SalarioBase salariBase, ImpactoHEDSR impactoHEDSR, HorasExtras50 horasExtras50, HorasExtras100 horasExtras100, HorasExtrasNoturno horasExtrasNoturno, INSS iNSS, PeriodoCalculo periodoCalculo, Jornada jornada, Faltas faltas)
        {
            decimal FaixaIR;
            decimal BaseCalculo = BaseCalculoIR(holerite, salariBase, impactoHEDSR, horasExtras50, horasExtras100, horasExtrasNoturno, iNSS, periodoCalculo, jornada, faltas);

            if (BaseCalculo > SalarioATE4())
            {
                FaixaIR = (decimal)Aliquota5();
            }
            else if (BaseCalculo > SalarioATE3())
            {
                FaixaIR = (decimal)Aliquota4();
            }
            else if (BaseCalculo > SalarioATE2())
            {
                FaixaIR = (decimal)Aliquota3();
            }
            else if (BaseCalculo > SalarioAte1())
            {
                FaixaIR = (decimal)Aliquota2();
            }
            else
            {
                FaixaIR = (decimal)Aliquota1();
            }

            return FaixaIR;
        }

        public decimal ValorIR(Holerite holerite, SalarioBase salarioBase, ImpactoHEDSR impactoHEDSR, HorasExtras50 horasExtras50, HorasExtras100 horasExtras100, HorasExtrasNoturno horasExtrasNoturno, INSS iNSS, PeriodoCalculo periodoCalculo, Jornada jornada, Faltas faltas)
        {
            decimal ValorIR;
            decimal FaixaIR = this.FaixaIR(holerite, salarioBase, impactoHEDSR, horasExtras50, horasExtras100, horasExtrasNoturno, iNSS, periodoCalculo, jornada, faltas);
            decimal BaseCaculoIR = BaseCalculoIR(holerite, salarioBase, impactoHEDSR, horasExtras50, horasExtras100, horasExtrasNoturno, iNSS, periodoCalculo, jornada, faltas);
            decimal Deducao;

            if(FaixaIR == (decimal)Aliquota1())
            {
                Deducao = DeducaoPadrao1();
            }
            else if (FaixaIR == (decimal)Aliquota2())
            {
                Deducao = DeducaoPadrao2();
            }
            else if (FaixaIR == (decimal)Aliquota3())
            {
                Deducao = DeducaoPadrao3();
            }
            else if (FaixaIR == (decimal)Aliquota4())
            {
                Deducao = DeducaoPadrao4();
            }
            else
            {
                Deducao = DeducaoPadrao5();
            }

            ValorIR = BaseCaculoIR * FaixaIR - Deducao;

            return ValorIR;
        }
            
    }
}
