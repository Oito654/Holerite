
using System;
using System.Collections.Generic;
using System.Text;

namespace HoleriteCalculo.DadosInformados
{
    public class Holerite
    {
        public Holerite(decimal _SalarioBase, DateTime _DataDeAdmissao, int _DependentesSalarioFamilia, decimal _PensaoAlimenticia, int _DependentesIR, int _NumeroDeFaltas, decimal _Adiantamento, decimal _Gratrificacoes, int _HorasExtras50, int _HorasExtras100, int _HorasExtrasNoturno, Periodo periodo, Jornada jornada, VT vt )
        {

            SalarioBase = _SalarioBase;
            DataDeAdmissao = _DataDeAdmissao;
            DependentesSalarioFamilia = _DependentesSalarioFamilia;
            PensaoAlimenticia = _PensaoAlimenticia;
            DependentesIR = _DependentesIR;
            NumeroDeFaltas = _NumeroDeFaltas;
            Adiantamento = _Adiantamento;
            Gratificacoes = _Gratrificacoes;
            HorasExtras50 = _HorasExtras50;
            HorasExtras100 = _HorasExtras100;
            HorasExtrasNoturno = _HorasExtrasNoturno;
            this.periodo = periodo;
            this.jornada = jornada;
            this.vt = vt;
        }
        public decimal SalarioBase { get; set; }
        public DateTime DataDeAdmissao { get; set; }
        public int DependentesSalarioFamilia { get; set; }
        public decimal PensaoAlimenticia { get; set; }
        public int DependentesIR { get; set; }
        public int NumeroDeFaltas { get; set; }
        public decimal Adiantamento { get; set; }
        public decimal Gratificacoes { get; set; }
        public double HorasExtras50 { get; set; }
        public double HorasExtras100 { get; set; }
        public double HorasExtrasNoturno { get; set; }
        public Periodo periodo { get; set; }
        public Jornada jornada { get; set; }
        public VT vt { get; set; }

    }
}
