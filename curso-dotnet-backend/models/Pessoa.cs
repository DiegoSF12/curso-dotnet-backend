using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace curso_dotnet_backend.models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome01 = nome;
            Idade = idade;
        }
        public Pessoa()
        {
            
        }

        private string nome;
        private string _nome01;
        private int _idade;
        public string Nome01
        {
            get => _nome01.ToUpper(); //Body expression, serve para que possamos simplificar retornos e atribuições simples
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome01 = value;
            }
        }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }
        List<int> numeros; 


        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome() => nome; //Body expression, serve para que possamos simplificar retornos e atribuições simples
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