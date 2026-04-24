using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4_c_
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Menor de edad");

            if (edad >= 18 && edad <= 64) Console.WriteLine("Adulto");

            if (edad >= 65) Console.WriteLine("Adulto mayor");

        }

    }

}
