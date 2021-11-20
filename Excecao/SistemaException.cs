using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecao
{
    class SistemaException : ApplicationException   //Classe pra tartar exceções
    {
        public SistemaException(string message) : base(message)  //construtor classe filha/pai
        {

        }
    }
}
