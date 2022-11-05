using System;

namespace Solución
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROBLEMA 1");
            Console.WriteLine("Ingresa la cadena No. 1");
            string cadena_1 = Console.ReadLine().ToLower();
            Console.WriteLine("Ingresa la cadena No. 2");
            string cadena_2 = Console.ReadLine().ToLower();            

            Console.WriteLine(cadena_1 + cadena_2);
            Console.ReadKey();

        }
    }
}
