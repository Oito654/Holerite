using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
    class Horas_Extras_N
    {
        public double Quant_Horas_Extras(Holerite holerite)
        {
            int quantidade_hr_extra;
            quantidade_hr_extra = holerite.horasExtrasNoturno;
            return quantidade_hr_extra;
        }

        public decimal Valor_Hr_Extra(Holerite holerite, Salario_Base salario_Base, Jornada jornada, Horas_Extras50 horas_Extras50)
        {
            decimal valor_hr_extra;
            valor_hr_extra = Convert.ToDecimal(1.2) * horas_Extras50.Valor_Hr_Extra(holerite, salario_Base, jornada);
            return (decimal)valor_hr_extra;
        }

        public decimal Horas_Extras_Total(Holerite holerite, Salario_Base salario_Base, Jornada jornada, Horas_Extras50 horas_Extras50)
        {
            double hora_extra;
            hora_extra = Quant_Horas_Extras(holerite) * (double)Valor_Hr_Extra(holerite, salario_Base, jornada, horas_Extras50);
            return (decimal)hora_extra;
        }
    }
}
