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
            
            int op = -1;
            while (op != 0)
            {   
                Console.WriteLine("Por favor, escolha uma das opções abaixo");
                Console.WriteLine("1 - Somar dois numeros");
                Console.WriteLine("2 - Subtrair dois numeros");
                Console.WriteLine("3 - Multiplicar dois numeros");
                Console.WriteLine("4 - Dividir dois numeros");
                Console.WriteLine("5 - Calculos Trigonométricos");
                Console.WriteLine("0 - SAIR");
                op = Convert.ToInt32(Console.ReadLine());

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
                    case 5:
                        Console.WriteLine("Escolha uma função trigonométrica:");
                        Console.WriteLine("1 - Seno");
                        Console.WriteLine("2 - Cosseno");
                        Console.WriteLine("3 - Tangente");
                        Console.WriteLine("9 - Voltar ao menu principal");
                        int opTrigonometria = Convert.ToInt32(Console.ReadLine());
                        switch (opTrigonometria)
                        {
                            case 1:
                                Calculadora.Seno();
                                break;
                            case 2:
                                Calculadora.Coseno();
                                break;
                            case 3:
                                Calculadora.Tangente();
                                break;
                            case 9:
                                Console.WriteLine("Voltando ao menu principal...");
                                continue;
                        }
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