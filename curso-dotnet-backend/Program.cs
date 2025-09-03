using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso_dotnet_backend.models;


namespace curso_dotnet_backend
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa(nome:"Dionisio", idade:19);//Outra forma de inicializar o objeto
            Pessoa p3 = new Pessoa();
            Curso curso = new Curso();

            p1.Nome01 = "Diego";
            p1.Idade = 21;

            p3.Nome01 = "Vitor";
            p3.Idade = 16;

            
            curso.Nome = "Infraestrutura de TI";
            curso.Alunos = new List<Pessoa>();
            curso.AdicionarAluno(p1);
            curso.AdicionarAluno(p2);  
            curso.AdicionarAluno(p3);
            curso.ListarAlunoe();
            Console.WriteLine($"Quantidade de alunos no curso de {curso.Nome}: {curso.ObterQuantidadeAlunos()}");
















            //Arrays.ExecutarArrays();
            //Class1.Hello();
            //Interface.MenuIniciar();
            //Listas.ExecutarListas();

            // pessoa.SetNome("Diego");
            // Console.WriteLine($"Nome: {pessoa.GetNome()}");
            // pessoa.SetNomeConsole();
            // Console.WriteLine($"Nome digitado via console: {pessoa.GetNome()}");
     
            //pessoa.RodarLista();
            
            
        }
    }
}