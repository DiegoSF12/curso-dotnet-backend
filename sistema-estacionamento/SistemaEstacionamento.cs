using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace sistema_estacionamento
{
    public class SistemaEstacionamento
    {
        public decimal precoInical = 0;
        public decimal precoPorHora = 0;
        public decimal valorTotal = 0;
        List<string> veiculos = new List<string>();

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido: ");
            string placa = Console.ReadLine().ToUpper();
            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digie o número de horas que o veículo permaneceu estacionado: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInical + (precoPorHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O vcículo {placa} foi removido e o preço final foi de R$ {valorTotal}"); 
            }
        }


        public void ListarVeiculos()
        {
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine($"Veiculos: {veiculo}");
            }
        }
    }
}