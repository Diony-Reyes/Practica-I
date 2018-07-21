using System;

namespace ProgramaSiete
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pida al usuario dos números reales (que se guardarán en las variables dato1 y 
             dato2).Si dato2 es cero, deberá mostrar un mensaje de error, y en caso contrario 
             mostrará en pantalla el resultado de dividir dato1 entre dato2.
             */

            Console.Write("Introduzca el primer dato: ");
            float dato1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Introduzca el segundo dato: ");
            float dato2 = Convert.ToSingle(Console.ReadLine());

            if (dato2 == 0)
            {
                Console.WriteLine("ERROR: División entre cero.");
            }
            else
            {
                float resultado = dato1 / dato2;

                Console.WriteLine("El resultado de {0} / {1} es: {2}", dato1, dato2, resultado);
            }

            Console.ReadKey();
            
        }
    }
}
