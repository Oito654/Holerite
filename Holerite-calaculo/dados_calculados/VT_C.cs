using Holerite_calaculo.dados_informados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Holerite_calaculo.dados_calculados
{
    class VT_C
    {
        public int Quant_Ref(Holerite holerite, VT_Lista vT_Lista, Periodo_C periodo_C)
        {
            int quant_ref;
            if(holerite.vt._VT == TipoDeVT.POR_MES)
            {
                quant_ref = 1;
            } else if(holerite.vt._VT == TipoDeVT.POR_SEMANA)
            {
                quant_ref = vT_Lista.Quant_Sexta(holerite, periodo_C);
            } else
            {
                quant_ref = vT_Lista.Quant_dias_a_trabalhar(holerite, periodo_C);
            }
            return quant_ref;
        }

        public decimal Valor_vt_mes_seguinte(Holerite holerite, VT_Lista vT_Lista, Periodo_C periodo_C)
        {
            double valor_vt_mes_s;

            valor_vt_mes_s = holerite.vt.ValorVtPeriodo * Quant_Ref(holerite, vT_Lista, periodo_C);
            return (decimal)valor_vt_mes_s;
        }

        public decimal Limite_Desconto(Holerite holerite, VT_Lista vT_Lista)
        {
            double limit_des;
            limit_des = vT_Lista.Aliquota() * (double)holerite.salarioBase;
            return (decimal)limit_des;
        }

        public decimal Valor_Desconto(Holerite holerite, VT_Lista vT_Lista)
        {
            decimal valor_desc;

            if (holerite.vt.descontarVT)
            {
                valor_desc = Limite_Desconto(holerite, vT_Lista);
            } else
            {
                valor_desc = 0;
            }
            return valor_desc;
        }
    }
}
