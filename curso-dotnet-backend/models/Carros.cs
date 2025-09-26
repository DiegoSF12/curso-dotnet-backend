using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace curso_dotnet_backend.models
{
    public class Carros
    {
        
        public Carros(int id, string marca, string modelo)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
        }

        private int _id;
        private string _modelo;
        private string _marca;
        public int Id
        {
            get => _id;
            set
            {
                if (value == 0)
                {
                    throw new Exception("O valor do campo não pode ser vazio");
                }
                _id = value;
            }
        }
        public string Marca
        {
            get => _marca;
            set
            {
                if (value == null)
                {
                    throw new Exception("O valor do campo não pode ser vazio");
                }
                _marca = value;
            }
        }
        public string Modelo
        {
            get => _modelo;
            set
            {
                if (value == null)
                {
                    throw new Exception("O valor do campo não pode ser vazio");
                }
                _modelo = value;
            }
        }

        public static void ListarVeiculos(List<Carros> listaCarros)
        {
            foreach (Carros carro in listaCarros)
            {
                Console.WriteLine($"ID: {carro.Id}\nMarca: {carro.Marca}\nModelo: {carro.Modelo}");
            }
        }

        public static void CadastrarVeiculos()
        {
            bool loop = true, loopWhile = true;
            int id, opcaoSwitch;
            string marca, modelo, opcaoWhile;
            List<Carros> carros = new List<Carros>();
            Console.WriteLine("Bem vindo ao catalogo de veiculos, vejas os opções que temos");
            while (loop)
            {
                Console.WriteLine("1 - Cadastrar veiculos\n2 - Listar Veiculos cadastrados (Objetos comuns)\n3 - Listar veiculos (JSON)\n0 - Sair");
                opcaoSwitch = Convert.ToInt32(Console.ReadLine());
                switch (opcaoSwitch)
                {
                    case 1:
                        while (loopWhile)
                        {
                            Console.WriteLine("Digite o ID do veículo");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Agora digite a marca");
                            marca = Console.ReadLine();
                            Console.WriteLine("E por fim, o modelo");
                            modelo = Console.ReadLine();

                            carros.Add(new Carros(id, marca, modelo));
                            Console.WriteLine("Deseja adicionar algum outro veículo? (S/n)");
                            opcaoWhile = Console.ReadLine().ToUpper();
                            if (opcaoWhile != "S")
                            {
                                Console.WriteLine("Programa encerrado");
                                loopWhile = false;

                            }
                        }
                        loopWhile = true;
                        break;
                    case 2:
                        Carros.ListarVeiculos(carros);
                        break;
                    case 3:
                        string serializado = JsonConvert.SerializeObject(carros, Formatting.Indented);
                        Console.WriteLine(serializado);
                        Console.WriteLine("Deseja salvar o arquivo?(S/n)");
                        string opcao = Console.ReadLine();
                        if (opcao == "S")
                        {
                            Console.WriteLine("Digite o caminho para salvar");
                            string caminho = Console.ReadLine();
                            File.WriteAllText(@caminho, serializado);
                        }
                            break;
                    case 0:
                        Console.WriteLine("Aplicação encerrada");
                        loop = false;
                        break;


                }

            }
        }
        
    }
}