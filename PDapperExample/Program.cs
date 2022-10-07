using System;
using PDapperExample.Model;
using PDapperExample.Services;

namespace PDapperExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente()
            { 
               Nome = "Teste",
               Telefone = "16 997447884"
            
            };

            new ClienteServices().ADD(cliente);
            new ClienteServices().GetAll().ForEach(x=> Console.WriteLine(x));

            Console.WriteLine("UFA!");
        }
    }
}
