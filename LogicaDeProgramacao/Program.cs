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


            int nume = 2;

            switch (nume)
            {
                case 1:

                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:

                    break;
            }
           
            //laço for serve pra quando sabemos o tanto que queremos repetir
            for(int i = 0; i < 10; i++) // i+=2
            {
                Console.WriteLine(i);
            }


        }
    }
}
