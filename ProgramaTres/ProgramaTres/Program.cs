using System;

namespace ProgramaTres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Que solicite la edad del usuario y diga si es un niño, un adolescente, un joven, o un adulto

            //0 a 12 --> niñ@s 
            //13 a 19 --> adolescentes
            //20 a 29 --> jovenes
            //30 en adelante --> adult@s

            Console.Write("Introudzca la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 0 && edad <= 12)
            {
                Console.WriteLine("Eres un(a) niño(a).");
            }
            else if (edad >= 13 && edad <= 19)
            {
                Console.WriteLine("Eres un(a) adolescente.");
            }
            else if (edad >= 20 && edad <= 29)
            {
                Console.WriteLine("Eres un(a) joven.");
            }
            else
            {
                Console.WriteLine("Eres un(a) adulto(a).");
            }

            Console.ReadKey();
        }
    }
}
