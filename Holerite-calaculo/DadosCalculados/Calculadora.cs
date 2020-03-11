using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HoleriteCalculo.DadosCalculados
{
    public class Calculadora
    {
        public void Calcular(Holerite holerite, Jornada jornada, Calculadora calcular)
        {
            PeriodoCalculo periodoCalculo = new PeriodoCalculo();
            SalarioBase salarioBase = new SalarioBase();
            SalarioFamilia salarioFamilia = new SalarioFamilia();
            Faltas faltas = new Faltas();
            VTCalculo vTCalculo = new VTCalculo();
            HorasExtras50 horasExtras50 = new HorasExtras50();
            HorasExtras100 horasExtras100 = new HorasExtras100();
            HorasExtrasNoturno horasExtrasN = new HorasExtrasNoturno();
            ImpactoHEDSR impactoHEDSR = new ImpactoHEDSR();
            FGTS fGTS = new FGTS();
            INSS inss = new INSS();
            IR iR = new IR();

            var DiasCorridosTrab = periodoCalculo.DiasTrabalhados(holerite);
            var dias_mes = periodoCalculo.DiasDoMes(holerite);
            
            var salario_d = salarioBase.SalarioDia(holerite, periodoCalculo);
            var salario_hr = salarioBase.SalarioHr(jornada, holerite);
            var salario_prop = salarioBase.SalarioBaseProporcional(holerite, periodoCalculo);
            
            var salario_fam = salarioFamilia._SalarioFamilia(holerite, periodoCalculo);
            
            var desconto_falta = faltas.DescontoFaltas(holerite, salarioBase, periodoCalculo);
            
            var quantidade_ref = vTCalculo.QuantReferencia(holerite, periodoCalculo);
            var valor_mes_seguite = vTCalculo.ValorVTMesSeguinte(holerite, periodoCalculo);
            var limite_desconto = vTCalculo.LimiteDesconto(holerite);
            var valor_desconto = vTCalculo.ValorDesconto(holerite);

            var quant_hrs_extras_50 = horasExtras50.QuantHorasExtras(holerite);
            var valor_hr_extra_50 = horasExtras50.ValorHrExtra(holerite, salarioBase, jornada);
            var horas_extras_total_50 = horasExtras50.HorasExtrasTotal(holerite, salarioBase, jornada);

            var quant_hrs_extras_100 = horasExtras100.QuantHorasExtras(holerite);
            var valor_hrs_extras_100 = horasExtras100.ValorHrExtra(holerite, salarioBase, jornada);
            var horas_extras_total_100 = horasExtras100.HorasExtrasTotal(holerite,salarioBase,jornada);

            var quant_hrs_extras_N = horasExtrasN.QuantHorasExtras(holerite);
            var valor_hrs_extras_N = horasExtrasN.ValorHrExtra(holerite, salarioBase, jornada, horasExtras50);
            var horas_extras_total_N = horasExtras50.ValorHrExtra(holerite, salarioBase, jornada);

            var impacto_50 = impactoHEDSR.ImpactoDSRHE50(holerite, horasExtras50, periodoCalculo, salarioBase, jornada);
            var impacto_100 = impactoHEDSR.ImpactoDSRHE100(holerite, horasExtras100, periodoCalculo, salarioBase, jornada);
            var impacto_NA = impactoHEDSR.ImpactoDSRHENoturno(holerite, horasExtrasN, periodoCalculo, salarioBase, jornada, horasExtras50);
            var impacto_Total = impactoHEDSR.ImpactoDSRHETotal(holerite, horasExtrasN, periodoCalculo, salarioBase, jornada, horasExtras50, horasExtras100);

            var fgts_mes = fGTS.FGTS_Mes(holerite, impactoHEDSR, horasExtras100, horasExtras50, horasExtrasN, salarioBase, periodoCalculo, faltas, jornada);

            var _inss = inss._INSS(holerite, salarioBase, periodoCalculo, faltas, horasExtras50, horasExtras100, horasExtrasN, impactoHEDSR, jornada);

            var _ir = iR.ValorIR(holerite, salarioBase, impactoHEDSR, horasExtras50, horasExtras100, horasExtrasN, inss, periodoCalculo, jornada, faltas);
        }
    }

}