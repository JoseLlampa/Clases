using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant1 = new Restaurant();
            Console.WriteLine(restaurant1.getInformacion());
            Console.WriteLine();

            Restaurant restaurant2 = new Restaurant("Parrilla El Puente", 42950001, "12 de Octubre 1185");

            restaurant2.MostrarCodigoArea();

            Console.WriteLine(restaurant2.getInformacion());

            Console.ReadKey();
        }
     
    }
     
}
