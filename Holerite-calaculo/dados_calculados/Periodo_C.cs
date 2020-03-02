using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
   
    public class Periodo_C
    {
        int mes_s;
        int ano_s;
        int ano_a;
        int mes_a;


        public int Mes_Ano(Holerite holerite)
        {

            mes_a = (int)holerite.periodo.Mes;
            mes_s = mes_a++;
            ano_a = holerite.periodo.Ano;
            var diaAtual = DateTime.Now;
            var diasTrabalhados = diaAtual.Subtract(holerite.dataDeAdmissao).Days;

            if (mes_s == (int)_Mes.Dez)
            {
                ano_s = ano_a++;
                holerite.periodo.Mes = (_Mes)mes_s;
                
                
                 
            }
            else
            {
                ano_s = ano_a;
                holerite.periodo.Ano = ano_s;
                holerite.periodo.Mes = (_Mes)mes_s;
                

            }


            return diasTrabalhados;
        }

        public int Dias_do_Mes()
        {
             var diasNoMes = DateTime.DaysInMonth(ano_a, mes_a);
             return  diasNoMes;
            
        }

        internal void Mes_Ano()
        {
            throw new NotImplementedException();
        }

        internal void Mes_Ano(Periodo periodo)
        {
            throw new NotImplementedException();
        }
    }


}
