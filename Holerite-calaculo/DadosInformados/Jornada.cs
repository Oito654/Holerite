using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosInformados
{
    public class Jornada
    {
        public  bool Dom { get; set; }
        public  bool Seg { get; set; }
        public  bool Ter { get;  set; }
        public  bool Qua { get; set; }
        public  bool Qui { get; set; }
        public  bool Sex { get; set; }
        public  bool Sab { get; set; }
        public  decimal JornadaHoraMensais { get; set; }
        public int FeriadosMesAtual { get;  set; }
        public int FeriadosMesSeguinte { get; set; }
    }
}