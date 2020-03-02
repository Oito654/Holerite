using Holerite_calaculo.dados_calculados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_informados
{
   public class Fechamento
    {
        public void _Fechamento()
        {
            Periodo periodo = new Periodo();
            Jornada jornada = new Jornada();
            VT vt = new VT();
            Calcular cal = new Calcular();

            periodo.Mes = _Mes.Nov;
            periodo.Ano = 2019;
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
            Holerite holerite = new Holerite(954, new DateTime(2019, 10, 23), 0, 0, 1, 0, 0, 0, 2, 0, 0, periodo, jornada, vt);
            cal.Calculos(holerite, jornada);
            
        }
    }
}
