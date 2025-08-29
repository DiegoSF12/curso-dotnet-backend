using System.Diagnostics.Contracts;

namespace curso_dotnet_backend;

public class Listas
{
    public static void ExecutarListas()
    {
        List<string> estados = new List<string>();

        estados.Add("MG");
        estados.Add("BA");
        estados.Add("PE");
        estados.Add("GO");
        string[] UFs = new[]
                        {
                    "AC","AL","AP","AM","BA","CE","DF","ES","GO","MA",
                    "MT","MS","MG","PA","PB","PR","PE","PI","RJ","RN",
                    "RS","RO","RR","SC","SP","SE","TO"
                    };


        for (int contador = 0; contador < estados.Count; contador++)
        {
            Console.WriteLine($"Posição {contador} - estado: {estados[contador]})");
        }
        estados.AddRange(UFs);
        estados.Sort();
        Console.WriteLine("Lista de estados em Alfabetica");
        foreach (var item in estados)
        {
            Console.WriteLine(item);

        }




    }
}
