using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend
{
    public class Calculadora
    {
        public static void Somar()
        {
            Console.WriteLine("Digie o primeiro numero: ");
            string entrada = Console.ReadLine();
            int x = Convert.ToInt32(entrada);

            Console.WriteLine("Digie o segundo numero: ");
            entrada = Console.ReadLine();
            int y = int.Parse(entrada);
            Console.WriteLine($"A soma de {x} + {y} é igual a: {x + y}");
        }

        public static void Subtrair()
        {
            string entrada;
            Console.WriteLine("Digite o primeiro numero: ");
            entrada = Console.ReadLine();
            int x = Convert.ToInt32(entrada);

            Console.WriteLine("Digite o segundo numero: ");
            entrada = Console.ReadLine();
            int y = Convert.ToInt32(entrada);
            Console.WriteLine($"A subtração de {x} - {y} é igual a: {x - y}");
        }

        public static void Multiplicar()
        {
            Console.WriteLine("Informe o primeiro numero: ");
            string entrada = Console.ReadLine();
            int x = Convert.ToInt32(entrada);

            Console.WriteLine("Informe o valor do segundo numero: ");
            entrada = Console.ReadLine();
            int y = Convert.ToInt32(entrada);
            Console.WriteLine($"O produto da multiplicação entre {x} * {y} é igual a: {x * y}");

        }

        public static void Dividir()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            string entrada = Console.ReadLine();
            int x = Convert.ToInt32(entrada);

            Console.WriteLine("Digite o valor do segundo numero: ");
            entrada = Console.ReadLine();
            int y = Convert.ToInt32(entrada);
            if (x == 0 || y == 0)
            {
                Console.WriteLine("É IMPOSSIVEL DIVIDIR POR ZERO!!!!");
            }
            else
            {
                Console.WriteLine($"A divisão de {x} / {y} é igual a: {x / y}");
            }
        }
        public static void Seno()
        {
            Console.WriteLine("Por favor, digite o valor em graus");
            string entrada = Console.ReadLine();
            double radiano = Convert.ToDouble(entrada);
            radiano = radiano * Math.PI / 180;
            radiano = Math.Sin(radiano);
            Console.WriteLine($"O valor do Seno de {entrada} é igual a: {Math.Round(radiano, 4)}");
        }

        public static void Coseno()
        {
            Console.WriteLine("Por favor, digite o valor em graus");
            string entrada = Console.ReadLine();
            double radiano = Convert.ToDouble(entrada);
            radiano = radiano * Math.PI / 180;
            radiano = Math.Cos(radiano);
            Console.WriteLine($"O valor do coseno de {entrada} é igual a: {Math.Round(radiano, 4)}");
        }

        public static void Tangente()
        {
            Console.WriteLine("Por favor, digite o valor em graus");
            string entrada = Console.ReadLine();
            double radiano = Convert.ToDouble(entrada);
            radiano *= Math.PI / 180;
            radiano = Math.Tan(radiano);
            Console.WriteLine($"O valor da tangente de {entrada} é igual a {Math.Round(radiano, 4)}");
        }


    }
}