using Holerite_calaculo.dados_informados;
using System;

namespace Holerite_calaculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Periodo periodo = new Periodo();
            Jornada jornada = new Jornada();
            VT vt = new VT();

            periodo.Mes = _Mes.Nov;
            periodo.Ano = 2020;
            jornada.seg = true;
            jornada.ter = true;
            jornada.qua = true;
            jornada.qui = true;
            jornada.sex = true;
            jornada.jhm = 220;
            vt._VT = TipoDeVT.POR_DIA;
            vt._aVT = 0;
            vt._vVTP = 8.80;
            vt._dVT = false;
            
            Holerite holerite = new Holerite(954, new DateTime(2019, 10, 23), 0, 0, 1, 0, 0, 0, 2, 0, 0, periodo, jornada, vt );
            //Escrever Linha
           //Console.WriteLine();
        }
    }
}