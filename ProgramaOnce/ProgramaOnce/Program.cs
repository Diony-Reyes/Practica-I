using System;

namespace ProgramaOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que reciba un numero y muestre su tabla de multiplicar.


            Console.Write("Introuduzca un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());            
            int prodc;

            Console.Clear();
            Console.WriteLine("TABLA DEL {0}", num);
            Console.WriteLine();

            for (int i=1; i<=10; i++)
            {
                prodc = num * i;
                Console.WriteLine(num + " * " + i + " = " + prodc);
            }

            Console.ReadKey();
        }
    }
}
