namespace curso_dotnet_backend;

public class Arrays
{   

    /// <summary>
    /// Método para executar exemplos com Arrays
    /// </summary> 
    public static void ExecutarArrays()
    {

        int[] arrayInteiros = new int[3];
        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;


        Console.WriteLine("Usando o For");
        for (int contador = 0; contador < arrayInteiros.Length; contador++)
        {
            Console.WriteLine($"Posição N° {contador + 1} - Valor: {arrayInteiros[contador]}");
        }

        Console.WriteLine("Usando o ForEach");
        int contadorForEach = 1;
        foreach (int valor in arrayInteiros)
        {
            Console.WriteLine($"Posição N° {contadorForEach} - Valor: {valor}");
            contadorForEach++;
        }

        Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
        arrayInteiros[3] = 56;
        arrayInteiros[4] = 30;
        arrayInteiros[5] = 23;

        Console.WriteLine("Array redimensionado com novos valores:");
        contadorForEach = 1;
        foreach (int valor in arrayInteiros)
        {
            Console.WriteLine($"Posição N° {contadorForEach} - Valor: {valor}");
            contadorForEach++;
        }
        Array.Sort(arrayInteiros);
        Console.WriteLine("Array ordenado:");
        foreach (int valor in arrayInteiros)
        {
            Console.WriteLine($"Posição N° {contadorForEach} - Valor: {valor}");
            contadorForEach++;
        }

        contadorForEach = 1;
        Array.Reverse(arrayInteiros);
        Console.WriteLine("Array copiado:");
        int[] arrayOrdenado = new int[arrayInteiros.Length];
        Array.Copy(arrayInteiros, arrayOrdenado, arrayInteiros.Length);
        foreach (int valor in arrayOrdenado)
        {
            Console.WriteLine($"Posição N° {contadorForEach} - Valor: {valor}");
            contadorForEach++;
        }
    }
}
