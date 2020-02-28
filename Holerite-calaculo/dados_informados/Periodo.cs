using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_informados
{
    public enum _Mes { Jan = 1, Fev = 2, Mar = 3, Abr = 4, Mai = 5, Jun = 6, Jul = 7, Ago = 8, Set = 9, Out = 10, Nov = 11, Dez = 12 }

    public class Periodo
    {
        private _Mes _mes;
        private int _ano;

        public _Mes Mes { 
            get => _mes;
            set => _mes = value;
        }

        public int Ano { 
            get => _ano; 
            set => _ano = value; }

    }
}