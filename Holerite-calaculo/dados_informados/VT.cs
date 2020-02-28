using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_informados
{
    public enum TipoDeVT { POR_DIA, POR_SEMANA, POR_MES }
    
    public class VT
    {
        private  TipoDeVT _vt;
        public  bool _dVT;
        public  double _vVTP;
        public  decimal _aVT;

        public  decimal AdiantamentoVT { 
            get => _aVT; 
            set
            {
                _aVT = value;
            }
        }
        
        public  double ValorVtPeriodo { 
            get => _vVTP; 
            set
            {
                _vVTP = value;
            }
        }
        
        public  bool descontarVT {
            get => _dVT; 
            set
            {
                _dVT = value;
            }
        }

        public  TipoDeVT _VT
        {
            get => _vt;
            set => _vt = value;
        }

    }
}