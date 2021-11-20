using System;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa pessoa = new Pessoa("Raquelle", 'F', 35);
                pessoa.Imprimir();
            }
            catch(SistemaException erro)
            {
                Console.WriteLine(erro.Message);
            }

            Console.ReadKey();
        }
    }
}
