using System;
using System.Collections.Generic;
using System.Text;

namespace ONG_Doar
{
    interface IPessoa
    {
        string Nome { get; }
        string Cpf { get; }
        string Telefone { get; }
        string Endereco { get; }
    }
}
