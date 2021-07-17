using System;
using System.Collections.Generic;

namespace ONG_Doar
{
    class Program
    {
        static void Main(string[] args)
        {
            Doadora doador1 = new Doadora("Fernando", "123123123", "22222-222", "Rua Belem");
            Doacao doacao = new Doacao(TipoDoacao.CestaBasica, "");
            Beneficiaria benef1 = new Beneficiaria("Rodrigo", "31233123", "222-222", "Rua X");
            Acoes a = new Acoes();
            
            //List<IDoacao> Doacoes = a.Estoque;
            a.ReceberDoacao(doacao, doador1);
            
            if(a.FornecerDoacao(TipoDoacao.CestaBasica, benef1))
            {
                Console.WriteLine($"{benef1.Nome} recebeu {TipoDoacao.CestaBasica}");
            }

            if (a.FornecerDoacao(TipoDoacao.CestaBasica, benef1))
            {
                Console.WriteLine($"{benef1.Nome} recebeu {TipoDoacao.CestaBasica}");
            }


        }
    }
}
