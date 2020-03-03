using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
    class Faltas
    {

        public decimal DescontoFaltas(Holerite holerite, Salario_Base salario_Base, Periodo_C periodo_C)
        {
            decimal desconta_faltas = holerite.numeroDeFaltas * salario_Base.Salario_dia(holerite, periodo_C);
            return desconta_faltas;
        }

    }
}
