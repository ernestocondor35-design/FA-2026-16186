using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4_c_
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el año: ");
            int an = int.Parse(Console.ReadLine());

            if (an % 4 == 0 & an % 10 != 0) || an % 400 == 0)
            {
                Console.WriteLine("\nEl año es bisiesto");

            }else Console.WriteLine("\n El año no es bisiesto");

            if (an % 2 == 0) Console.WriteLine("\nEl año es par");
            else Console.WriteLine("\nEl año es impar");

        }

    }

}
