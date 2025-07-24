using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend.models
{
    public class Pessoa
    {
        public Pessoa(string Nome)
        {
            this.Nome = Nome;
        }


        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Eu me chamo {Nome},\n e tenho {Idade} anos.");
        }
        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }
        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }
        public string getNome()
        {
            return this.Nome;
        }   
        public int getIdade()
        {
            return this.Idade;
        }

    }
}