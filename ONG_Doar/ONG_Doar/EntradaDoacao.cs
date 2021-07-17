using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    class EntradaDoacao : IEntradaDoacao
    {
        public List<IDoacao> Doacoes { get; private set; }

        public IDoadora Doador { get; private set; }

        public DateTime Data { get; private set; }

        public EntradaDoacao(List<IDoacao> doacoes, IDoadora doador, DateTime data)
        {
            Doacoes = doacoes;
            Doador = doador;
            Data = data;
        }
        public EntradaDoacao(IDoacao doacao, IDoadora doador, DateTime data)
        {
            Doacoes = new List<IDoacao>();
            Doacoes.Add(doacao);
            Doador = doador;
            Data = data;
        }
    }
}
