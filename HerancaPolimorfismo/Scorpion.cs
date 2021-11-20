using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    class Scorpion : Persomagem  //Herança
    {
        public override void Especial()  //Polimorfismo
        {
            Console.WriteLine("Jogando Serpente");
        }
    }
}
