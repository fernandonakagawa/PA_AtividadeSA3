using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    class Doacao : IDoacao
    {
        public TipoDoacao Tipo { get; private set; }

        public string Descricao { get; set; }

        public Doacao(TipoDoacao tipo, string descricao)
        {
            Tipo = tipo;
            Descricao = descricao;
        }
    }
}
