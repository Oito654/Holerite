﻿using Holerite_calaculo.dados_informados;
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
        public void CriandoVariaveis(Holerite holerite)
        {
            mes_a = (int)holerite.periodo.Mes;
            mes_s = mes_a++;
            ano_a = holerite.periodo.Ano;
            if (mes_s == (int)_Mes.Dez)
            {
                ano_s = ano_a++;
                holerite.periodo.Mes = (_Mes)mes_s;
                
                
                 
            }
            else
            {
                ano_s = ano_a;
            }
        }

        internal void CriandoVariaveis(Periodo periodo)
        {
            throw new NotImplementedException();
        }
    }


}