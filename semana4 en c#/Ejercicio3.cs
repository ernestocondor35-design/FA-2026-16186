using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4_en_c_
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Sistema de conversión ---\n");
            double mo = double.Parse(Console.ReadLine());

            Console.Write("1. Convertir a dolares");
            Console.Write("2. Convertir a dolares");

            Console.WriteLine("Ingrese una opción: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1: 
                    double dolares = mo / 3.75;
                    Console.WriteLine("\nDolares: " + dolares);
                    break;
                case 2:
                    double euros = mo / 4.05;
                    Console.WriteLine("\nEuros: " + euros);
                   break;
                default:
                    Console.WriteLine("Opción incorecta!!!!");
                    break;

            }

        }

    }

}