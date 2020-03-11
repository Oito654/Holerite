using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
    class SalarioBase
    {
        decimal _SalarioDia;
        decimal _SalarioHr;
        decimal SalarioProporcional;

        public decimal SalarioDia(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            _SalarioDia = holerite.SalarioBase / periodoCalculo.DiasDoMes(holerite);
            return _SalarioDia;
        }

        public decimal SalarioHr(Jornada jornada, Holerite holerite)
        {
            _SalarioHr = holerite.SalarioBase / jornada.JornadaHoraMensais;
            return _SalarioHr;
        }

        public decimal SalarioBaseProporcional(Holerite holerite, PeriodoCalculo periodoCalculo)
        {
            decimal DiasDoMes = periodoCalculo.DiasDoMes(holerite);
            decimal DiasTrabalhados = periodoCalculo.DiasTrabalhados(holerite);

            SalarioProporcional = holerite.SalarioBase / DiasDoMes * DiasTrabalhados ;

            return SalarioProporcional;
        }
    }
}
