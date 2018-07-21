using System;

namespace ProgramaSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pida al usuario dos números enteros (que se guardarán en las variables n1 y 
             n2) y muestre su producto en pantalla.
             */

            Console.Write("Introduzca n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int producto = n1 * n2;

            Console.WriteLine("El producto de {0} * {1} es: {2}", n1, n2, producto);

            Console.ReadKey();
        }
    }
}
