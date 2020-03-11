using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class HorasExtrasNoturno
    {
        public double QuantHorasExtras(Holerite holerite)
        {
            double QuantidadeHrExtra;
            QuantidadeHrExtra = holerite.HorasExtrasNoturno;
            return QuantidadeHrExtra;
        }

        public decimal ValorHrExtra(Holerite holerite, SalarioBase salarioBase, Jornada jornada, HorasExtras50 horasExtras50)
        {
            decimal ValorHrExtra;
            ValorHrExtra = Convert.ToDecimal(1.2) * horasExtras50.ValorHrExtra(holerite, salarioBase, jornada);
            return (decimal)ValorHrExtra;
        }

        public double HorasExtrasTotal(Holerite holerite, SalarioBase salarioBase, Jornada jornada, HorasExtras50 horasExtras50)
        {
            double HoraExtra;
            HoraExtra = QuantHorasExtras(holerite) * (double)ValorHrExtra(holerite, salarioBase, jornada, horasExtras50);
            return HoraExtra;
        }
    }
}
