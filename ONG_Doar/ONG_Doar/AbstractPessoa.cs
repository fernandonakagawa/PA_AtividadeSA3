using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    abstract class AbstractPessoa : IPessoa
    {
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public string Telefone { get; private set; }

        public string Endereco { get; private set; }

        protected AbstractPessoa(string nome, string cpf, 
            string telefone, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
