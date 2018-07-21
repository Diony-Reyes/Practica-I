using System;

namespace ProgramaCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Guarde en la variable x (entera) el número 23, en la variable y (entera) el 
             número 24, en la variable z (entera) el número 25 y muestre en pantalla la suma 
             de los valores de las tres variables.
             */

            int varX = 23;
            int varY = 24;
            int varZ = 25;
            int suma;

            Console.WriteLine("El resultado de " + varX + " + " + varY + " + " + varZ + " = {0}", suma = varX + varY + varZ);

            Console.ReadKey();
        }   
    }
}
