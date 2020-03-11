using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosInformados
{
    
    public class VT
    {
        public enum TipoVT { Diario, Semanal, Mensal }

        public  decimal AdiantamentoVT { get; set; }
        
        public  double ValorVTPeriodo { get; set; }
        
        public  bool DescontarVT { get; set; }

        public  TipoVT TipoDeVT { get; set; }

    }
}