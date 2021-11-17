using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosAtributos
{
    class Produto
    {
        public string nome;
        public float valor;
        


        public float RetornaValorAtualizado(float acrescimo, bool ehImportado)
        {
            if (ehImportado)
            {
                return (valor * acrescimo);
            }
            else
            {
                return valor;
            }

            
        }

        public void ImprimirNoConsole(float valorAtualizado)
        {
            Console.WriteLine($"Nome do produto: {nome}.");
            Console.WriteLine($"Valor do produto: {valor.ToString("F2")}.");
            Console.WriteLine($"Valor atualizado do produto: {valorAtualizado.ToString("F2")}.");
        }
    }
}
