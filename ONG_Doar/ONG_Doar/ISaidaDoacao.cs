using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    interface ISaidaDoacao
    {
        List<IDoacao> Doacoes { get; }
        IBeneficiaria Beneficiario { get; }
        DateTime Data { get; }
    }
}
