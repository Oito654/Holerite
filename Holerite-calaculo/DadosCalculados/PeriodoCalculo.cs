using HoleriteCalculo.DadosInformados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosCalculados
{
   
    public class PeriodoCalculo
    {
        public int MesAtual(Holerite holerite)
        {
            return (int) holerite.periodo.Mes;
        }

        public int AnoAtual(Holerite holerite)
        {
            return holerite.periodo.Ano;
        }

        public int MesSeguinte(Holerite holerite)
        {
            var mes_atual = MesAtual(holerite);
            return mes_atual + 1;
        }

        public int AnoSeguinte(Holerite holerite)
        {
            int AnoSeguinte;

            var MesAtual = (_Mes) this.MesAtual(holerite);
            var AnoAtual = this.AnoAtual(holerite);

            if (MesAtual.Equals(_Mes.Dez))
            {
                AnoSeguinte = AnoAtual++;
                holerite.periodo.Mes = _Mes.Jan;
            }
            else
            {
                AnoSeguinte = AnoAtual;
                holerite.periodo.Ano = AnoSeguinte;

            }

            return AnoSeguinte;
        }
        public int DiasTrabalhados(Holerite holerite)
        {
            var DiaAtual = DateTime.Now;
            var DiasTrabalhados = DiaAtual.Subtract(holerite.DataDeAdmissao).Days;
            return 30;
        }

        public int DiasDoMes(Holerite holerite)
        {
             var AnoAtual = this.AnoAtual(holerite);
             var MesAtual = this.MesAtual(holerite);
             var DiasNoMes = DateTime.DaysInMonth(AnoAtual, MesAtual);
             return  DiasNoMes;
            
        }

        public int DiasDoProximoMes(Holerite holerite)
        {
            var MesSeguinte = this.MesSeguinte(holerite);
            var AnoSeguinte = this.AnoSeguinte(holerite);
            var DiasNoMesSeguinte = DateTime.DaysInMonth(AnoSeguinte, MesSeguinte);
            return DiasNoMesSeguinte;

        }
       
    }


}
