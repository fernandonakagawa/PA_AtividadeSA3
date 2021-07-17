using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    interface IDoadora:IPessoa
    {
        List<IDoacao> Doacoes { get; }
        public void Doar(IDoacao d);
    }
}
