using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    interface IEntradaDoacao
    {
        //doacoes, doador e data
        List<IDoacao> Doacoes { get; }
        IDoadora Doador { get; }
        DateTime Data { get; }
    }
}
