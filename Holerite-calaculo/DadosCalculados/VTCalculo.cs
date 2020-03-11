using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class VTCalculo : VTLista
    {
        public int QuantReferencia(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            int QuantReferencia;
            if(holerite.vt.TipoDeVT == VT.TipoVT.Diario)
            {
                QuantReferencia = 1;
            } else if(holerite.vt.TipoDeVT == VT.TipoVT.Diario)
            {
                QuantReferencia = QuantSexta(holerite, periodoCalculo);
            } else
            {
                QuantReferencia = QuantDiasATrabalhar(holerite, periodoCalculo);
            }
            return QuantReferencia;
        }

        public decimal ValorVTMesSeguinte(Holerite holerite,PeriodoCalculo periodoCalculo)
        {
            double ValorVTMes;

            ValorVTMes = holerite.vt.ValorVTPeriodo * QuantReferencia(holerite, periodoCalculo);
            return (decimal)ValorVTMes;
        }

        public decimal LimiteDesconto(Holerite holerite)
        {
            double limiteDescdonto;
            limiteDescdonto = Aliquota() * (double)holerite.SalarioBase;
            return (decimal)limiteDescdonto;
        }

        public decimal ValorDesconto(Holerite holerite)
        {
            decimal ValorDesc;

            if (holerite.vt.DescontarVT)
            {
                ValorDesc = LimiteDesconto(holerite);
            } else
            {
                ValorDesc = 0;
            }
            return ValorDesc;
        }
    }
}
