using System;

namespace ClassesMetodosAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.Write("Digite o nome do produto: ");
            produto1.nome = Console.ReadLine();

            Console.Write("Digite o valor do produto: ");
            produto1.valor = float.Parse(Console.ReadLine());

            Console.Write("O produto é importado? ");
            if(Console.ReadLine() == "Sim")
            {
                produto1.ehImportado = true;
            }
            else
            {
                produto1.ehImportado = false;
            }

            Produto produto2 = new Produto();
            produto2.nome = "Controle remoto";
            produto2.valor = 10f;
            produto2.ehImportado = true;

        }
    }
}
