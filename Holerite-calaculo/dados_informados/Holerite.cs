using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_informados
{
    public class Holerite
    {
        public Holerite(decimal _sb, DateTime _dA, decimal _sF, decimal _pA, decimal _dIR, decimal _nF, decimal _adi, decimal _gra, double _hr50, double _hr100, double _hrN, Periodo periodo, Jornada jornada, VT vt )
        {
            salarioBase = _sb;
            dataDeAdmissao = _dA;
            salarioFamilia = _sF;
            pensaoAlimenticia = _pA;
            dependentesIR = _dIR;
            numeroDeFaltas = _nF;
            adiantamento = _adi;
            gratificações = _gra;
            horasExtras50 = _hr50;
            horasExtras100 = _hr100;
            horasExtrasNoturno = _hrN;
            this.periodo = periodo;
            this.jornada = jornada;
            this.vt = vt;
        }
        public decimal salarioBase { 
            get;
            set; }
        public DateTime dataDeAdmissao { 
            get; 
            set; }
        public decimal salarioFamilia {
            get; 
            set; }
        public decimal pensaoAlimenticia { 
            get; 
            set; }
        public decimal dependentesIR {
            get; 
            set; }
        public decimal numeroDeFaltas {
            get; 
            set; }
        public decimal adiantamento { 
            get; 
            set; }
        public decimal gratificações {
            get; 
            set; }
        public double horasExtras50 { 
            get; 
            set; }
        public double horasExtras100 {
            get; 
            set; }
        public double horasExtrasNoturno { 
            get; 
            set; }
        public Periodo periodo {
            get; 
            set; }
        public Jornada jornada {
            get; 
            set; }
        public VT vt {
            get; 
            set; }

    }
}
