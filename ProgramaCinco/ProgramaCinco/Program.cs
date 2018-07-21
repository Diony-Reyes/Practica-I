using System;

namespace ProgramaCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genere el promedio de los valores almacenados en 5 variables enteras.

            Console.Write("Introduzca primver valor: ");
            int var1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca segundo valor: ");
            int var2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca tercer valor: ");
            int var3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca cuarto valor: ");
            int var4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca quinto valor: ");
            int var5 = Convert.ToInt32(Console.ReadLine());

            int prom = (var1 + var2 + var3 + var4 + var5) / 5;

            Console.WriteLine("El promedio de {1}, {2}, {3}, {4} y {5} es igual a {0}", prom, var1, var2, var3, var4, var5);

            Console.ReadKey();
        }
    }
}
