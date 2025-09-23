using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend.models
{
    public class Tuplas
    {
        public (bool situacao, string[] Linhas, int quantidadeLinhas) LerArquivo(string caminhoArquivo)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}