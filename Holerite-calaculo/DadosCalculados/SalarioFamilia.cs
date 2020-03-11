using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class SalarioFamilia
    {

        double RendaAte1 = 977.77;
        double RendaAte2 = 1364.43;
        double Vencimento1 = 46.54;
        double Vencimento2 = 32.80;

        public decimal RendaDE1(Holerite holerite)
        {

            double RendaDE1 = RendaAte1 + 0.01;
            
            return (decimal)RendaDE1;
            
        }

        public decimal RendaDE2(Holerite holerite)
        {

            double RendaDE2 = RendaAte2 + 0.01;

            return (decimal)RendaDE2;

        }

        public decimal _SalarioFamilia(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            decimal CondicaoSalarioFamilia;
            decimal SalarioFamilia;

            if (holerite.SalarioBase < RendaDE1(holerite))
            {
                CondicaoSalarioFamilia = (decimal)Vencimento1;

            } else if(holerite.SalarioBase < RendaDE2(holerite))
            {
                CondicaoSalarioFamilia = (decimal)Vencimento2;
            }
            else
            {
                CondicaoSalarioFamilia = 0;
            }

            SalarioFamilia = holerite.DependentesSalarioFamilia * CondicaoSalarioFamilia / periodoCalculo.DiasDoMes(holerite) * periodoCalculo.DiasTrabalhados(holerite);

            return SalarioFamilia;
        }

    }
}
