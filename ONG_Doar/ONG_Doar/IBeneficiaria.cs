using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    interface IBeneficiaria
    {
        List<IDoacao> DoacoesRecebidas { get; }
        DateTime DataUltimoRecebimento { get; }
        public void ReceberDoacao(IDoacao d);

    }
}
