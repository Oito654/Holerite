using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosInformados
{
    abstract class TabelaINSS
    {
            public decimal SalarioAte1()
            {
                decimal SalarioAte1 = 1751.81m;
                return SalarioAte1;
            }

            public decimal SalarioAte2()
            {
                decimal SalarioAte2 = 2919.72m;
                return SalarioAte2;
            }

            public decimal SalarioAte3()
            {
                decimal SalarioAte3 = 5839.45m;
                return SalarioAte3;
            }

            private decimal SalarioDE1()
            {
                decimal SalarioDE1 = 0;
                return SalarioDE1;
            }

            private decimal SalarioDE2()
            {
                decimal SalarioDE2 = SalarioAte1();
                return SalarioDE2;
            }

            private decimal SalarioDE3()
            {
                decimal salarioDE3 = SalarioAte2();
                return salarioDE3;
            }

            public double Aliquota1()
            {
                double Aliquota1 = 0.08;
                return Aliquota1;
            }

            public double Aliquota2()
            {
                double Aliquota2 = 0.09;
                return Aliquota2;
            }

            public double Aliquota3()
            {
                double Aliquota3 = 0.11;
                return Aliquota3;
            }

            public decimal SalarioMax()
            {
                decimal SalarioMax;
                SalarioMax = SalarioAte3();
                return SalarioMax;
            }
    }
}
