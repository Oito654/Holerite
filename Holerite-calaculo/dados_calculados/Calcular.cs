using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
    public class Calcular
    {
        public void Calculos(Holerite holerite, Jornada jornada)
        {
            Periodo_C periodo_C = new Periodo_C();
            Salario_Base salario_Base = new Salario_Base();

            var dias_corridos_trab = periodo_C.Mes_Ano(holerite);
            var dias_mes = periodo_C.Dias_do_Mes();
            var salario_d = salario_Base.Salario_dia(holerite, periodo_C);
            var salario_hr = salario_Base.Salario_hr(jornada, holerite);
            var salario_prop = salario_Base.Salario_Base_Proporcional(holerite, periodo_C);


        }
    }

}