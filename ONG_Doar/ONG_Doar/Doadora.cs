using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    class Doadora : AbstractPessoa, IDoadora
    {
        public List<IDoacao> Doacoes { get; private set; }
        public Doadora(string nome, string cpf,
            string telefone, string endereco) : base(nome, cpf, telefone, endereco)
        {
            this.Doacoes = new List<IDoacao>();
        }

        public void Doar(IDoacao d)
        {
            this.Doacoes.Add(d);
        }
    }
}
