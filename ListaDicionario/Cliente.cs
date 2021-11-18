using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDicionario
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public double Limite { get; set; }

        public Cliente(string nome, int idade, char sexo, double limite)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Limite = limite;
        }
    }
}
