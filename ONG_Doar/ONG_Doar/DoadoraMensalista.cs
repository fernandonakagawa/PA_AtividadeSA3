using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    class DoadoraMensalista : Doadora, IDoadoraMensalista
    {
        public int DiaDoMesDoacao { get; private set; }
        public DoadoraMensalista(string nome, string cpf, 
            string telefone, string endereco) : base(nome, cpf, telefone, endereco)
        {
        }

        public void IniciarDoacaoMensal(int diaMes)
        {
            this.DiaDoMesDoacao = diaMes;
        }

        public void PararDoacaoMensal()
        {
            this.DiaDoMesDoacao = -1;
        }
    }
}
