using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
   abstract class Persomagem
    {
        public string Nome { get; set; }

        public string Cor { get; set; }

        private int Vida { get; set; }

        public Persomagem()
        {
            Vida = 100;
        }

        public void RemoveVida(int dano)
        {
            Vida -= dano;
        }

        public void Correr()
        {

        }

        public void Caminhar()
        {

        }

        public void Pular()
        {

        }

        public void DarSoco()
        {

        }

        public void DarChute()
        {

        }


        //Polimorfismo
        public abstract void Especial();
       
    }
}
