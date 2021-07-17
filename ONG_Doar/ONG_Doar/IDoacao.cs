using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    public enum TipoDoacao
    {
        Dinheiro10,
        CestaBasica,
        PecaRoupa,
    }
    //item unitário indivisível
    interface IDoacao
    {
        //tipo qtd desc
        TipoDoacao Tipo { get; }
        string Descricao { get; }

    }
}
