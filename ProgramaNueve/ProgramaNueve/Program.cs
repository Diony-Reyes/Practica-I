using System;

namespace ProgramaNueve
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pida al usuario un número entero, diga si es par o impar, y repita todo lo 
             anterior hasta que el número que se introduzca sea 0. (Nota: para saber si un 
             número es par, se mira si el resto de su división entre 2 es 0).
             */

            int num;

            do
            {
                Console.Write("Inserte el numero donde indica la flecha --> ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num != 0)
                {
                    int resto = num % 2;

                    if (resto == 0) Console.WriteLine("El numero {0} es par", num);
                    else Console.WriteLine("El numero {0} es impar", num);
                }                

            } while (num != 0);

            Console.ReadKey();
        }
    }
}
