using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso_dotnet_backend.models;
using Newtonsoft.Json;


namespace curso_dotnet_backend
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Carros.MenuCarros();



            // Carros carro01 = new Carros();
            // Carros carro02 = new Carros();
            // Carros carro03 = new Carros();
            // Carros carro04 = new Carros();
            // Carros carro05 = new Carros();
            // Carros carro06 = new Carros();

            // carro01.Id = 7654;
            // carro02.Id = 8754;
            // carro03.Id = 9898;
            // carro04.Id = 7807;
            // carro05.Id = 1265;
            // carro06.Id = 9876;

            // carro01.Marca = "Volkwagen";
            // carro02.Marca = "Fiat";
            // carro03.Marca = "Chevrolet";
            // carro04.Marca = "Ford";
            // carro05.Marca = "Peugeot";
            // carro06.Marca = "Renault";

            // carro01.Modelo = "Gol";
            // carro02.Modelo = "Palio";
            // carro03.Modelo = "Vectra";
            // carro04.Modelo = "Fiesta";
            // carro05.Modelo = "208";
            // carro06.Modelo = "Sandero";

            // List<Carros> listCarros = new List<Carros>();
            // listCarros.Add(carro01);
            // listCarros.Add(carro02);
            // listCarros.Add(carro03);
            // listCarros.Add(carro04);
            // listCarros.Add(carro05);
            // listCarros.Add(carro06);

            // string obejetoSerializado = JsonConvert.SerializeObject(listCarros, Formatting.Indented);

            // Console.WriteLine(obejetoSerializado);

            // File.WriteAllText("arquivos/relatorioCarros.json", obejetoSerializado);


            //     Console.Clear();
            //     Tuplas lerArquivo = new Tuplas();   
            //     var (sucesso, linhas, quantidadeLinhas) = lerArquivo.LerArquivo(@"C:\Users\TI\Documents\Diego\Lorem ipsum dolor sit amet consecte.txt");
            //     if (sucesso)
            //     {
            //         Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
            //         foreach (string linha in linhas)
            //         {
            //             Console.WriteLine(linha);
            //         }
            //     }
            //     else {
            //         Console.WriteLine("Não foi possivel ler o arquivo");
            //     }
















            // Queue<string> nFila = new Queue<string>();
            // bool rodar = true;
            // while (rodar)
            // {
            //     Console.WriteLine("Digite o nome a ser guardado: ");
            //     string nomeDigitado = Console.ReadLine();
            //     nFila.Enqueue(nomeDigitado);
            //     if (nFila.Count > 4)
            //     {
            //         rodar = false;
            //     }
            // }
            // foreach (string nome in nFila)
            // {
            //     Console.WriteLine($"Nome: {nome}");
            // }
            // Console.WriteLine("Removendo os integrantes da fila pela ordem FIFO");
            // while (nFila.Count > 0)
            // {
            //     Console.WriteLine($"Veja a nova lista");
            //     foreach (string nome in nFila)
            //     {
            //         Console.Clear();
            //         nFila.Dequeue();
            //         Console.WriteLine($"Nome: {nome}");
            //     }
            // }
















            // Pessoa p1 = new Pessoa();
            // Pessoa p2 = new Pessoa(nome: "Dionisio", idade: 19);//Outra forma de inicializar o objeto
            // Pessoa p3 = new Pessoa();
            // Curso curso = new Curso();

            // p1.Nome01 = "Diego";
            // p1.Idade = 21;

            // p3.Nome01 = "Vitor";
            // p3.Idade = 16;


            // curso.Nome = "Infraestrutura de TI";
            // curso.Alunos = new List<Pessoa>();
            // curso.AdicionarAluno(p1);
            // curso.AdicionarAluno(p2);
            // curso.AdicionarAluno(p3);
            // curso.ListarAlunoe();
            // Console.WriteLine($"Quantidade de alunos no curso de {curso.Nome}: {curso.ObterQuantidadeAlunos()}");
















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