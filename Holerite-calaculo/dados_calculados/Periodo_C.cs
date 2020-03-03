using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
   
    public class Periodo_C
    {
        public int Mes_Atual(Holerite holerite)
        {
            return (int) holerite.periodo.Mes;
        }

        public int Ano_Atual(Holerite holerite)
        {
            return holerite.periodo.Ano;
        }

        public int Mes_Seguinte(Holerite holerite)
        {
            var mes_atual = Mes_Atual(holerite);
            return mes_atual + 1;
        }

        public int Ano_Seguinte(Holerite holerite)
        {
            int ano_s;

            var mes_atual = (_Mes) Mes_Atual(holerite);
            var ano_atual = Ano_Atual(holerite);

            if (mes_atual.Equals(_Mes.Dez))
            {
                ano_s = ano_atual++;
                holerite.periodo.Mes = _Mes.Jan;
            }
            else
            {
                ano_s = ano_atual;
                holerite.periodo.Ano = ano_s;

            }

            return ano_s;
        }
        public int Dias_Trabalhados(Holerite holerite)
        {
            var diaAtual = DateTime.Now;
            var diasTrabalhados = diaAtual.Subtract(holerite.dataDeAdmissao).Days;
            return diasTrabalhados;
        }

        public int Dias_do_Mes(Holerite holerite)
        {
             var ano_atual = Ano_Atual(holerite);
             var mes_atual = Mes_Atual(holerite);
             var diasNoMes = DateTime.DaysInMonth(ano_atual, mes_atual);
             return  diasNoMes;
            
        }

        public int Dias_do_Proximo_Mes(Holerite holerite)
        {
            var mes_seguinte = Mes_Seguinte(holerite);
            var ano_seguinte = Ano_Seguinte(holerite);
            var diasNoMesSeguinte = DateTime.DaysInMonth(ano_seguinte, mes_seguinte);
            return diasNoMesSeguinte;

        }
       
    }


}
