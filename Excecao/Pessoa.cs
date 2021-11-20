using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    class Pessoa
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }


        public Pessoa()   //Construtor sem parâmetros
        {

        }

        public Pessoa(string nome, char sexo, int idade)   //Construtor com parâmetros
        {
            if(idade < 0 || idade > 50)
            {
                throw new SistemaException("Idade Inválida");
            }
            if(sexo != 'M' && sexo != 'F')
            {
                throw new SistemaException("Sexo Inválido");
            }

            Nome = nome;
            Sexo = sexo;
            Idade = idade;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Idade: {Idade}");
        }

    }
}
