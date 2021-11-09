using System;

namespace CursoCsharp_ProgramacaoAplicada
{
    class Variaveis
    {
        static void Main(string[] args)
        {
            //string nome = "Raquelle";

            //char letra = 'R';
            //bool chovendo = true;
            //int idade = 35;
            //float numeroQuebrado = 10.5f;
            //double numeroQuebradoDouble = 10.5;
            //decimal numeroQuebradoDecimal = 10.5m;
            //sbyte idade2;

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            string sobreNome = Console.ReadLine();

            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Meu nome é {nome} {sobreNome}");


            ///conversao////
            float numero = 10.6546735f;
            int numero2 = (int)numero; //vai ter perda de informação

            //Console.WriteLine(numero2);
            //Console.WriteLine(n1*n2);
            //Console.ReadKey();


            /////Array////
           int[] numeros = new int[] { 1,2,3};
            string[] nomes = new string[]
            {
                "Raquelle",
                 "Isaac",

            };
            
        }
    }
}
