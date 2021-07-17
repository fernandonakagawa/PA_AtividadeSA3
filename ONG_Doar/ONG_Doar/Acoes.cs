using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    class Acoes : IAcoes
    {
        public List<IEntradaDoacao> Entradas { get; private set; }
        public List<ISaidaDoacao> Saidas { get; private set; }

        public List<IDoacao> Estoque { 
            get
            {
                List<IDoacao> estoque = new List<IDoacao>();
                foreach(IEntradaDoacao ed in Entradas)
                {
                    foreach(IDoacao d in ed.Doacoes)
                    {
                        estoque.Add(d);
                    }
                }
                foreach(ISaidaDoacao sd in Saidas)
                {
                    foreach(IDoacao d in sd.Doacoes)
                    {
                        estoque.Remove(d);
                    }
                }
                return estoque;
            }
        }

        public Acoes()
        {
            this.Entradas = new List<IEntradaDoacao>();
            this.Saidas = new List<ISaidaDoacao>();
        }

        public bool FornecerDoacao(TipoDoacao tipoDoacao, IBeneficiaria beneficiario)
        {
            List<IDoacao> estoque = this.Estoque;
            foreach(IDoacao d in estoque)
            {
                if(d.Tipo == tipoDoacao)
                {
                    SaidaDoacao sd = new SaidaDoacao(d, beneficiario, DateTime.Now);
                    Saidas.Add(sd);
                    return true;
                }
            }
            return false;
        }

        public void ReceberDoacao(IDoacao doacao, IDoadora doador)
        {
            EntradaDoacao ed = new EntradaDoacao(doacao, doador, DateTime.Now);
            this.Entradas.Add(ed);
        }
    }
}
