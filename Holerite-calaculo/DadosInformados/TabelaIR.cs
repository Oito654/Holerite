using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosInformados
{
     abstract class TabelaIR
    {
        public decimal SalarioAte1()
        {
            decimal SalarioATE1;
            SalarioATE1 = 1903.98m;
            return SalarioATE1;
        }

        public decimal SalarioATE2()
        {
            decimal SalarioATE2;
            SalarioATE2 = 2826.65m;
            return SalarioATE2;
        }

        public decimal SalarioATE3()
        {
            decimal SalarioATE3;
            SalarioATE3 = 3751.05m;
            return SalarioATE3;
        }

        public decimal SalarioATE4()
        {
            decimal SalarioATE4;
            SalarioATE4 = 4664.68m;
            return SalarioATE4;
        }

        public decimal DeducaoPadrao1()
        {
            decimal Deducao1;
            Deducao1 = 0;
            return Deducao1;
        }

        public decimal DeducaoPadrao2()
        {
            decimal Deducao2;
            Deducao2 = 142.8m;
            return Deducao2;
        }

        public decimal DeducaoPadrao3()
        {
            decimal Deducao3;
            Deducao3 = 354.8m;
            return Deducao3;
        }

        public decimal DeducaoPadrao4()
        {
            decimal Deducao4;
            Deducao4 = 636.13m;
            return Deducao4;
        }

        public decimal DeducaoPadrao5()
        {
            decimal deducao5;
            deducao5 = 869.36m;
            return deducao5;
        }

        public double Aliquota1()
        {
            double aliquota1;
            aliquota1 = 0;
            return aliquota1;
        }

        public double Aliquota2()
        {
            double aliquota2;
            aliquota2 = 0.075;
            return aliquota2;
        }

        public double Aliquota3()
        {
            double aliquota3;
            aliquota3 = 0.15;
            return aliquota3;
        }

        public double Aliquota4()
        {
            double aliquota4;
            aliquota4 = 0.225;
            return aliquota4;
        }

        public double Aliquota5()
        {
            double aliquota5;
            aliquota5 = 0.275;
            return aliquota5;
        }

        private decimal SalarioDE1()
        {
            decimal SalarioDE1;
            SalarioDE1 = 0;
            return SalarioDE1;
        }

        private decimal SalarioDE2()
        {
            decimal SalarioDE2;
            SalarioDE2 = SalarioAte1() + 0.01m;
            return SalarioDE2;
        }

        private decimal SalarioDE3()
        {
            decimal SalarioDE3;
            SalarioDE3 = SalarioATE2() + 0.01m; ;
            return SalarioDE3;
        }

        private decimal SalarioDE4()
        {
            decimal SalarioDE4;
            SalarioDE4 = SalarioATE3() + 0.01m; ;
            return SalarioDE4;
        }

        private decimal SalarioDE5()
        {
            decimal SalarioDE5;
            SalarioDE5 = SalarioATE4() + 0.01m; ;
            return SalarioDE5;
        }

        private decimal SalarioPorDependente()
        {
            decimal SalarioDP;
            SalarioDP = 189.59m;
            return SalarioDP;
        }
    }
}
