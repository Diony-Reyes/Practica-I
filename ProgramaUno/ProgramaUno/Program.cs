using System;

namespace ProgramaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Guarde en una variable entera el numero 50, y en otra variable entera el 
             numero 51 y muestre el resultado de multiplicar ambos números.
             */

            int num1 = 50;
            int num2 = 51;
            int mult;

            Console.WriteLine("El producto de " + num1 + " * " + num2 + " es: {0}", mult = num1 * num2);
            Console.ReadKey();
        }
    }
}
