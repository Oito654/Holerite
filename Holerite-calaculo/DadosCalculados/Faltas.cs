using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class Faltas
    {

        public decimal DescontoFaltas(Holerite holerite, SalarioBase salarioBase, PeriodoCalculo periodoC)
        {
            decimal desconta_faltas = holerite.NumeroDeFaltas * salarioBase.SalarioDia(holerite, periodoC);
            return desconta_faltas;
        }

    }
}
