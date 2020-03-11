using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class HorasExtras50
    {

        public double QuantHorasExtras(Holerite holerite)
        {
            double QuantidadeHrExtra;
            QuantidadeHrExtra = holerite.HorasExtras50;
            return QuantidadeHrExtra;
        }

        public decimal ValorHrExtra(Holerite holerite, SalarioBase salarioBase, Jornada jornada)
        {
            decimal ValorHrExtra;
            ValorHrExtra = Convert.ToDecimal(1.5) * salarioBase.SalarioHr(jornada, holerite);
            return (decimal)ValorHrExtra;
        }

        public double HorasExtrasTotal(Holerite holerite, SalarioBase salarioBase, Jornada jornada)
        {
            double HoraExtra;
            HoraExtra = QuantHorasExtras(holerite) * (double)ValorHrExtra(holerite, salarioBase, jornada);
            return HoraExtra;
        }
    }
}
