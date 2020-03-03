using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
    class Salario_Familia
    {

        double rendaAte1 = 977.77;
        double rendaAte2 = 1364.43;
        double vencimento1 = 46.54;
        double vencimento2 = 32.80;

        public decimal RendaDE_1(Holerite holerite)
        {

            double rendaDE_1 = rendaAte1 + 0.01;
            
            return (decimal)rendaDE_1;
            
        }

        public decimal RendaDE_2(Holerite holerite)
        {

            double rendaDE_2 = rendaAte2 + 0.01;

            return (decimal)rendaDE_2;

        }

        public decimal Salario_familia(Holerite holerite, Periodo_C periodo_C)
        {
            decimal condicaoSalarioF;
            decimal salario_familia;

            if (holerite.salarioBase < RendaDE_1(holerite))
            {
                condicaoSalarioF = (decimal)vencimento1;

            } else if(holerite.salarioBase < RendaDE_2(holerite))
            {
                condicaoSalarioF = (decimal)vencimento2;
            }
            else
            {
                condicaoSalarioF = 0;
            }

            salario_familia = holerite.dependentesSalarioFamilia * condicaoSalarioF / periodo_C.Dias_do_Mes(holerite) * periodo_C.Dias_Trabalhados(holerite);

            return salario_familia;
        }

    }
}
