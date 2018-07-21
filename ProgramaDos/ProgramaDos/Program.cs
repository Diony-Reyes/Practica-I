using System;

namespace ProgramaDos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que reciba un numero por teclado y diga si el numero es par o impar

            Console.Write("Introduzca un numero: ");
            int num =  Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero " + num + " es par");
            }
            else
            {
                Console.WriteLine("El numero " + num + " es impar");
            }

            Console.ReadKey();
        }
    }
}
