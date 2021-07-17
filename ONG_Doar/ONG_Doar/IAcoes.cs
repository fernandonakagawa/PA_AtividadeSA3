using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    interface IAcoes
    {
        List<IEntradaDoacao> Entradas { get; }
        List<ISaidaDoacao> Saidas { get; }
        List<IDoacao> Estoque { get; }

        public void ReceberDoacao(IDoacao doacao, IDoadora doador);

        public bool FornecerDoacao(TipoDoacao doacao, IBeneficiaria beneficiario);
    }
}
