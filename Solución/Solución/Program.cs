using System;
namespace Solución
{
    class Program
    {
        static void Main(string[] args)
        {
            Funciones _funciones = new();

            bool salir = false;            
            while (!salir) {
                bool opcionVaida = false;
                while (!opcionVaida) {
                    Console.WriteLine("MENÚ");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("1: Scramble");
                    Console.WriteLine("2: Justificador de Texto");
                    Console.WriteLine("3: Cadenas Subsecuentes");
                    Console.WriteLine("4: Abuela Binaria");
                    Console.WriteLine("5: Salir");
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Ingrese el número del problema que desea ver...");
                    string opcionTexto = Console.ReadLine();
                    try
                    {
                        int opcion = Int32.Parse(opcionTexto);
                        if (opcion >= 1 && opcion <= 5) {
                            opcionVaida = true;
                            Console.Clear();
                            switch (opcion) {
                                case 1:
                                    Console.WriteLine("Ingrese la cadena 1: ");
                                    string cadena_1 = Console.ReadLine().ToLower();
                                    Console.WriteLine("Ingrese la cadena 2: ");
                                    string cadena_2 = Console.ReadLine().ToLower();
                                    if (_funciones.Scramble(cadena_1, cadena_2)) {
                                        Console.WriteLine("¡La cadade 2 es una subcadena de la cadena 1!");
                                    }
                                    else {
                                        Console.WriteLine("La cadade 2 no es una subcadena de la cadena 1");
                                    }                                    
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    Console.WriteLine("Ingrese el numero total:");
                                    int total = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el numero uno:");
                                    int numero_1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el numero dos:");
                                    int numero_2 = int.Parse(Console.ReadLine());
                                    int res = _funciones.AbuelaBinaria(total, numero_1, numero_2);
                                    if (res == -1) {
                                        Console.WriteLine("Error: La suma de los 2 números no dan el total ingresado...");
                                    }
                                    else {
                                        Console.WriteLine("La cantidad de avellanas es de: " + res.ToString());
                                    }
                                    break;
                                case 5:
                                    salir = true;
                                    break;
                            }
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Por favor, ingresa una opción válida...");
                    }
                }                
            }                        
        }
    }
}