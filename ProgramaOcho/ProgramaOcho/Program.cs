using System;

namespace ProgramaOcho
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pida al usuario dos números enteros (que se guardarán en las variables num1 
             y num2).Si num2 es cero, deberá mostrar un mensaje de error, y en caso contrario 
             mostrará en pantalla el resto de la división de num1 entre num2.
             */

            Console.Write("Introduzca el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("ERROR: División entre cero");
            }
            else
            {
                int resto = num1 % num2;
                Console.WriteLine("El resto de {0} / {1} es: {2}", num1, num2, resto);
            }

            Console.ReadKey();
        }
    }
}
