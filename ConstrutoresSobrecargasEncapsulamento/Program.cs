using System;

namespace ConstrutoresSobrecargasEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Somar(1, 2, 3, 4, 5);
           
        }

        static void Somar(params int[] numeros)
        {
            int resultado = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                resultado += numeros[i];
            }

            Console.Write(resultado);
        }

    }
}
