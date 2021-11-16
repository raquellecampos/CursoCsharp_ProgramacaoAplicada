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
        public bool ehImportado;


        public float RetornaValorAtualizado()
        {
            if (ehImportado)
            {
                return (valor * 2.17f);
            }
            else
            {
                return valor;
            }

            
        }

        public void ImprimirNoConsole()
        {
            Console.WriteLine(nome);
            Console.WriteLine(valor);
            float valorAtualizado = RetornaValorAtualizado();
            Console.WriteLine("R$ " + valorAtualizado);
        }
    }
}
