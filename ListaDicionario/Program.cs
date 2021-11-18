using System;
using System.Collections.Generic;

namespace ListaDicionario
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente("Raquelle", 35, 'F', 500));
            clientes.Add(new Cliente("Aloisio", 48, 'M', 700));
            clientes.Add(new Cliente("Isaac", 20, 'M', 800));

            foreach(Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.Nome + " - " + "R$" + cliente.Limite);
            }




            //List<string> nomes = new List<string>();
            //nomes.Add("Raquelle");
            //nomes.Add("Isaac Henrique");
            //nomes.Add("Aloisio");
            //nomes.Add("Anna Luísa");

            //nomes.Remove("Raquelle");

            //Console.WriteLine(nomes[1] + " - " + nomes.Count); //Count retorna a quantidades de itens dentro de nome

            ////foreach(string item in nomes)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //Dictionary<int, string> dicionario = new Dictionary<int, string>(); 

            //    dicionario.Add(1, "camiseta");
            //    dicionario.Add(2, "calça");
            //    dicionario.Add(3, "sapato");

            //foreach(KeyValuePair<int, string> item in dicionario) //chave e valor
            //{
            //    Console.WriteLine(item.Key + " - " + item.Value); 
            //}
        }
    }
}
