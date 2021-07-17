using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    class SaidaDoacao:ISaidaDoacao
    {
        public List<IDoacao> Doacoes { get; private set; }

        public IBeneficiaria Beneficiario { get; private set; }

        public DateTime Data { get; private set; }

        public SaidaDoacao(List<IDoacao> doacoes, IBeneficiaria beneficiario, DateTime data)
        {
            Doacoes = doacoes;
            Beneficiario = beneficiario;
            Data = data;
        }

        public SaidaDoacao(IDoacao doacao, IBeneficiaria beneficiario, DateTime data)
        {
            Doacoes = new List<IDoacao>();
            Doacoes.Add(doacao);
            Beneficiario = beneficiario;
            Data = data;
        }
    }
}
