using System;

namespace ProgramaDiez
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pida al usuario un número indefinido de números (mientras se tecleen 
             números que no sea cero). Después de la introducción de cada número aparecerá 
             en pantalla información sobre el número de datos introducidos y la suma hasta el 
             momento, así:
             "Has introducido 5 números y su suma es 38"
             */

            int num;
            int sum=0;
            int cont=0;

            do
            {
                Console.Write("Digite un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num != 0)
                {
                    cont++;
                    sum = sum + num;
                }
                
            } while (num != 0);

            Console.WriteLine("Has introducido {0} números y su suma es {1}", cont, sum);

            Console.ReadKey();
        }
    }
}
