using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace curso_dotnet_backend
{
    public class Interface
    {
        public static void MenuIniciar()
        {   
            int op = 5;
            while (op != 0)
            {
                Console.WriteLine("Por favor, escolha uma das opções abaixo");
                Console.WriteLine("1 - Somar dois numeros");
                Console.WriteLine("2 - Subtrair dois numeros");
                Console.WriteLine("3 - Multiplicar dois numeros");
                Console.WriteLine("4 - Dividir dois numeros");
                Console.WriteLine("0 - SAIR");
                string op2 = Console.ReadLine();
                op = Convert.ToInt32(op2);

                switch (op)
                {
                    case 1:
                        Calculadora.Somar();
                        break;
                    case 2:
                        Calculadora.Subtrair();
                        break;
                    case 3:
                        Calculadora.Multiplicar();
                        break;
                    case 4:
                        Calculadora.Dividir();
                        break;
                    case 0:
                        Console.WriteLine("Operação finalizada");
                        return;
                }
                Console.WriteLine();
            }
        }
    }
}