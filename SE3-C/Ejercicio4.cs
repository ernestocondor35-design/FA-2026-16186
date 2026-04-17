using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(num)}");
            Console.WriteLine($"Redondeando: {Math.Round(num, 0)}");
            Console.WriteLine($"Al cubo: {Math.Pow(num,3)}");
            Console.WriteLine($"Raiz cubica: {Math.Pow(num,1/3d)}");



        }
    }
}