using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Holerite_calaculo.dados_calculados
{
    public class Calcular
    {
        public void Calculos(Holerite holerite, Jornada jornada)
        {
            Periodo_C periodo_C = new Periodo_C();
            Salario_Base salario_Base = new Salario_Base();
            Salario_Familia salario_Familia = new Salario_Familia();
            Faltas faltas = new Faltas();

            var dias_corridos_trab = periodo_C.Dias_Trabalhados(holerite);
            var dias_mes = periodo_C.Dias_do_Mes(holerite);
            var salario_d = salario_Base.Salario_dia(holerite, periodo_C);
            var salario_hr = salario_Base.Salario_hr(jornada, holerite);
            var salario_prop = salario_Base.Salario_Base_Proporcional(holerite, periodo_C);
            var salario_fam = salario_Familia.Salario_familia(holerite, periodo_C);
            var desconto_falta = faltas.DescontoFaltas(holerite, salario_Base, periodo_C);

           

        }
    }

}