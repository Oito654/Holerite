using HoleriteCalculo.DadosCalculados;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosInformados
{
   public class Fechamento
    {
        public void Fechar()
        {
            var periodo = new Periodo()
            {
                Mes = _Mes.Nov,
                Ano = 2019
            };

            var jornada = new Jornada()
            {
                Seg = true,
                Ter = true,
                Qua = true,
                Qui = true,
                Sex = true,
                JornadaHoraMensais = 220,
                FeriadosMesAtual = 1,
                FeriadosMesSeguinte = 1
            };

            var vt = new VT();
            {
                vt.TipoDeVT = VT.TipoVT.Diario;
                vt.AdiantamentoVT = 0;
                vt.ValorVTPeriodo = 8.80;
                vt.DescontarVT = false;
            }
            var holerite = new Holerite(954, new DateTime(2019, 10, 23), 0, 0, 1, 0, 0, 0, 2, 0, 0, periodo, jornada, vt);

            var calculadora = new Calculadora();
            {
                calculadora.Calcular(holerite, jornada, calculadora);
            }  
        }
    }
}
