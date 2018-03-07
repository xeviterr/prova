using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JOCS\n__________________");
            Console.WriteLine("1. Buscaminas");
            Console.WriteLine("2. Solitario");
            Console.WriteLine("Selecciona una opció:");

            string valor = Console.ReadLine();
            if (valor.Contains("1"))
            {
                Console.WriteLine("Buscaminas, aquesta és la bona");
                Console.WriteLine("yeeeeeeeeeeeahhhh aquí va el buscaminas!");
                Console.WriteLine("yeeeeeeeeeeeahhhh aquí va el buscaminas!");
            }
            else
            {
                Console.WriteLine("Solitario");
                Console.WriteLine("Ara estic jugant al solitàrio");
                Console.WriteLine("Canvi colega2");
            }
        }
    }
}
