using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    interface IDoadoraMensalista: IDoadora
    {
        int DiaDoMesDoacao { get; }

        public void IniciarDoacaoMensal(int diaMes);
        public void PararDoacaoMensal();
    }
}
