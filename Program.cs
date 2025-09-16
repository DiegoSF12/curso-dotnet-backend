using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet_backend.Teste
{
    public class teste
    {
        public static void Main(string[] args)
        {
            string dateString = "2022-04-17 18:00";

            DateTime.TryParseExact(dataString,
            "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture,
            DateTimeStyles.None, out DateTime date);

            Console.WriteLine(date);
            
        }
    }
}