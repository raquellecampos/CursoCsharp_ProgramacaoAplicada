using System;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 7;

            if(numero< 5)   ///encadeamento
            {
                Console.WriteLine("O número é menor do que 5");
            }
            else if(numero < 8)
            {
                Console.WriteLine("O número é menor do que 8");
            }
            else
            {
                Console.WriteLine("O número é menor do que 5 e 8");
            }


            int num = 10;

            while(num < 100)
            {
                Console.WriteLine(num);
                num++;
            }

           
        }
    }
}
