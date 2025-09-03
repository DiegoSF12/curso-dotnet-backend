using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAlunoe()
        {
            Console.WriteLine($"Alunos inscritos no curso de: {Nome} Numero do aluno:{Alunos.Count}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                Console.WriteLine($"Aluno {count + 1}: {Alunos[count].Nome01}, Idade: {Alunos[count].Idade}");
            }
        }
        public int ObterQuantidadeAlunos()
        {
            return Alunos.Count;
        }
    }
}