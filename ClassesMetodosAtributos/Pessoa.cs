using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosAtributos
{
    class Pessoa
    {
        public string nome;
        public char sexo;
        public int idade;
        public int sono;


        public void Comer()
        {
            Console.WriteLine($"{nome} está comendo!");
        }

        public void Caminhar()
        {
            Console.WriteLine($"{nome} está caminhando!");
        }

        public int HorasSono()
        {
            return sono;
        }
    }
}
