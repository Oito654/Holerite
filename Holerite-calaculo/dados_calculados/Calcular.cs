using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Holerite_calaculo.dados_calculados
{
    public class Calcular
    {
        public void Calculos(Holerite holerite, Jornada jornada, Calcular calcular)
        {
            Periodo_C periodo_C = new Periodo_C();
            Salario_Base salario_Base = new Salario_Base();
            Salario_Familia salario_Familia = new Salario_Familia();
            Faltas faltas = new Faltas();
            VT_Lista vT_Lista = new VT_Lista();
            VT_C vT_C = new VT_C();
            Horas_Extras50 horas_Extras50 = new Horas_Extras50();
            Horas_Extras100 horas_Extras100 = new Horas_Extras100();
            Horas_Extras_N horas_Extras_N = new Horas_Extras_N();

            var dias_corridos_trab = periodo_C.Dias_Trabalhados(holerite);
            var dias_mes = periodo_C.Dias_do_Mes(holerite);
            
            var salario_d = salario_Base.Salario_dia(holerite, periodo_C);
            var salario_hr = salario_Base.Salario_hr(jornada, holerite);
            var salario_prop = salario_Base.Salario_Base_Proporcional(holerite, periodo_C);
            
            var salario_fam = salario_Familia.Salario_familia(holerite, periodo_C);
            
            var desconto_falta = faltas.DescontoFaltas(holerite, salario_Base, periodo_C);
            
            var quantidade_ref = vT_C.Quant_Ref(holerite, vT_Lista, periodo_C);
            var valor_mes_seguite = vT_C.Valor_vt_mes_seguinte(holerite, vT_Lista, periodo_C);
            var limite_desconto = vT_C.Limite_Desconto(holerite, vT_Lista);
            var valor_desconto = vT_C.Valor_Desconto(holerite, vT_Lista);

            var quant_hrs_extras_50 = horas_Extras50.Quant_Horas_Extras(holerite);
            var valor_hr_extra_50 = horas_Extras50.Valor_Hr_Extra(holerite, salario_Base, jornada);
            var horas_extras_total_50 = horas_Extras50.Horas_Extras_Total(holerite, salario_Base, jornada);

            var quant_hrs_extras_100 = horas_Extras100.Quant_Horas_Extras(holerite);
            var valor_hrs_extras_100 = horas_Extras100.Valor_Hr_Extra(holerite, salario_Base, jornada);
            var horas_extras_total_100 = horas_Extras100.Horas_Extras_Total(holerite,salario_Base,jornada);

            var quant_hrs_extras_N = horas_Extras_N.Quant_Horas_Extras(holerite);
            var valor_hrs_extras_N = horas_Extras_N.Valor_Hr_Extra(holerite, salario_Base, jornada, horas_Extras50);
            var horas_extras_total_N = horas_Extras50.Valor_Hr_Extra(holerite, salario_Base, jornada);
        }
    }

}