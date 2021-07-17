using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    class Beneficiaria : AbstractPessoa, IBeneficiaria
    {
        public List<IDoacao> DoacoesRecebidas { get; private set; }

        public DateTime DataUltimoRecebimento { get; }

        public Beneficiaria(string nome, string cpf,
            string telefone, string endereco) : base(nome, cpf, telefone, endereco)
        {
            this.DoacoesRecebidas = new List<IDoacao>();
        }

        public void ReceberDoacao(IDoacao d)
        {
            this.DoacoesRecebidas.Add(d);
        }
    }
}
