using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
    class Salario_Base
    {
        decimal salario_dia;
        decimal salario_hr;
        decimal salario_prop;

        public decimal Salario_dia(Holerite holerite, Periodo_C periodo_C)
        {
            salario_dia = holerite.salarioBase / periodo_C.Dias_do_Mes(holerite);
            return salario_dia;
        }

        public decimal Salario_hr(Jornada jornada, Holerite holerite)
        {
            salario_hr = holerite.salarioBase / jornada.jhm;

            return salario_hr;
        }

        public decimal Salario_Base_Proporcional(Holerite holerite, Periodo_C periodo_C)
        {
            salario_prop = holerite.salarioBase / periodo_C.Dias_do_Mes(holerite) * periodo_C.Dias_Trabalhados(holerite);

            return salario_prop;
        }
    }
}
