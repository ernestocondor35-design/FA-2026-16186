using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre, carrera;

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("\nombreIngrese carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine("\n-------- IMPRESIÓN CON + --------");
            Console.WriteLine(nombre + ", Bienvenido al curso FA de la carrera "+carrera);

            Console.WriteLine("\n-------- IMPRESIÓN CON $ --------");
            Console.WriteLine($"{nombre}, Bienvenido al curso FA de la carrera {carrera}");
            Console.ReadKey();



        }
    }
}