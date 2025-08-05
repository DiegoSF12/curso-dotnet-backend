using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend
{
    public class Calculadora
    {
        public static void Soma()
        {
            Console.WriteLine("Digie o primeiro numero: ");
            string entrada = Console.ReadLine();
            int x = Convert.ToInt32(entrada);

            Console.WriteLine("Digie o segundo numero: ");
            entrada = Console.ReadLine();
            int y = int.Parse(entrada);
            Console.WriteLine($"A soma de {x} + {y} é igual a: {x + y}");
        }

        public void subtrair()
        {
            string entrada;
            Console.WriteLine("Digite o primeiro numero: ");
            entrada = Console.ReadLine();
            int x = Convert.ToInt32(entrada);

            
        }
    }
}