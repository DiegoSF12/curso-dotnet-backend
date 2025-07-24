using curso_dotnet_backend.models;

public class Program
{
    public static void Main(String[] args)
    {
 

        Pessoa p = new Pessoa("Diego");
        p.setIdade(21);
        p.Apresentar();
        string saudacao = "Olá, Mundo!";
        int dinheiro = 550;
        double altura = 1.81;
        //Console.WriteLine();
        Console.WriteLine(saudacao);
        Console.WriteLine($"Valor em conta: {dinheiro}");
        Console.WriteLine($"Altura: "+altura);
        
    }
}