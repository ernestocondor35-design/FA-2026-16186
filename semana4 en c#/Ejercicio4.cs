using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4_en_c_
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA DE CALCULO DE ÁREAS ---");

            Console.WriteLine("1. Área del cuadrado");
            Console.WriteLine("2. Área del triangulo");
            Console.WriteLine("3. Área del rectanfulo");
            Console.WriteLine("4. Área del circulo\n");

            Console.WriteLine("Ingrese una opcion: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Write("Ingresa el lado del cuadrado: ");
                    int l = int.Parse(Console.ReadLine());
                    Console.Write("\nÁrea del cuadrado: " + (l * l));
                    break;
                case 2:
                    Console.Write("Ingresa el lado del triángulo: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del triangulo: ");
                    int h = int.Parse(Console.ReadLine());
                    Console.Write("\nÁrea del triangulo: " + (b*h/2));
                   break;
                case 3:
                    Console.Write("Ingresa la base del rectangulo: ");
                    int br = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa la altura del rectangulo: ");
                    int hr = int.Parse(Console.ReadLine());
                    Console.Write("\nÁrea del triangulo: " + (br * hr ));
                    break;
                case 4:
                    Console.Write("\nIngresa la radio del circulo: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea del circulo: " + (Math.PI * Math.Pow(r, 2)));                   
                    break;
                default:
                    Console.WriteLine("\nOpcipon incorrecta!!");
                    break;

            }
        }
    }
}
     
