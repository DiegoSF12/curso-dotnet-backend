using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend.models
{
    public class Pessoa
    {
        private string nome;
        public  int idade { get; set; }
        List<int> numeros;


        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNomeConsole()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome1 = Console.ReadLine();
            this.SetNome(nome1);
        }

        public void RodarLista()
        {
            numeros = new List<int>();
            while(true)
            {
                Console.WriteLine("Deseja adicionar um numero ? (S/N)");
                string op = Console.ReadLine().ToUpper();
                if (op == "S")
                {
                    Console.WriteLine("Digite o valor a ser inserido: ");
                    numeros.Add(Convert.ToInt32(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("Aplicação encerrada");
                    if(numeros.Count != 0){
                        foreach (int x in numeros)
                        {
                            Console.Write($"{x} ");
                        }
                    }
                    break;
                }
            }
        }
    }
}