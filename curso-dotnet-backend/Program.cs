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
            //Arrays.ExecutarArrays();
            //Class1.Hello();
            //Interface.MenuIniciar();
            //Listas.ExecutarListas();
            Pessoa pessoa = new Pessoa();
            // pessoa.SetNome("Diego");
            // Console.WriteLine($"Nome: {pessoa.GetNome()}");
            // pessoa.SetNomeConsole();
            // Console.WriteLine($"Nome digitado via console: {pessoa.GetNome()}");
            Console.Clear();
            pessoa.RodarLista();
        }
    }
}