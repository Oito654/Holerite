using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_informados
{
    public class Jornada
    {
        public  bool dom = false;
        public  bool seg = false;
        public  bool ter = false;
        public  bool qua = false;
        public  bool qui = false;
        public  bool sex = false;
        public  bool sab = false;
        public  decimal jhm;

        public  bool Domingo { 
            get => dom; 
            set => dom = value; }
        public  bool Segunda { 
            get => seg; 
            set => seg = value; }
        public  bool Terca { 
            get => ter; 
            set => ter = value; }
        public  bool Quarta { 
            get => qua; 
            set => qua = value; }
        public  bool Quinta { 
            get => qui; 
            set => qui = value; }
        public  bool Sexta { 
            get => sex; 
            set => sex = value; }
        public  bool Sabado { 
            get => sab; 
            set => sab = value; }
        public  decimal Jornada_hrs_mensais { 
            get => jhm; 
            set => jhm = value; }
    }
}