using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend
{
    public class Debug
    {
        public static void Main(String[] args)
        {
            int quantidadeEmEstoque = 3;
            int quantidadeComprada = 0;
            bool estoqueSuficiente = quantidadeComprada > 0  && quantidadeEmEstoque >= quantidadeComprada;

            Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
            Console.WriteLine($"Quantidade comprada: {quantidadeComprada}");
            Console.WriteLine($"É possivel realizar a compra? {estoqueSuficiente}");

            if (quantidadeComprada == 0)
            {
                Console.WriteLine("Nenhum produto foi comprado.");
            }
            else if (estoqueSuficiente)
            {
                Console.WriteLine("Compra realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Estoque insuficiente para realizar a compra.");
            }
        }
    }
}