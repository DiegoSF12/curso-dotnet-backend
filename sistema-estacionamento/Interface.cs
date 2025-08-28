using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_estacionamento
{
    public class Interface
    {
        public static void ExibirMenu()
        {
            int op = -1;
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
            Console.WriteLine("Digite o preço inicial: ");
            decimal precoInial01 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o preço da hora: ");
            decimal precoPorHora01 = Convert.ToDecimal(Console.ReadLine());
            SistemaEstacionamento sistema = new SistemaEstacionamento();
            sistema.precoInical = precoInial01;
            sistema.precoPorHora = precoPorHora01;
            while (op != 0)
            {
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        sistema.AdicionarVeiculo();
                        break;
                    case 2:
                        sistema.RemoverVeiculo();
                        break;
                    case 3:
                        sistema.ListarVeiculos();
                        break;
                    case 4:

                        Console.WriteLine("Encerrando a aplicação...");
                        op = 0;
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
        }
    }
}