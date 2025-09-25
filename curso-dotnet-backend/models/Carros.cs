using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

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



        public static void CadastrarVeiculos()
        {
            bool loop = true;
            int id;
            string marca, modelo;
            List<Carros> carros = new List<Carros>();
            Console.WriteLine("Bem vindo a seção de cadastro de veículos.\nPressione ENTER para inicar o cadastro...");
            Console.ReadLine();
            while (loop)
            {
                Console.WriteLine("Digite o ID do veículo");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Agora digite a marca");
                marca = Console.ReadLine();
                Console.WriteLine("E por fim, o modelo");
                modelo = Console.ReadLine();

                carros.Add(new Carros(id, marca, modelo));
                Console.WriteLine("Deseja adicionar algum outro veículo? (S/n)");
                string op = Console.ReadLine().ToUpper();
                if (op != "S")
                {
                    Console.WriteLine("Programa encerrado");
                    loop = false;

                }
            }
            
        }
        
    }
}