using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar 5 números por consola, guardándolos en una variable escalar. 
             * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. */

            int numero = 0;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0;
            float promedio = 0;
            string cadena = "";

            for (int i=1;i<6;i++)
            {
                Console.WriteLine("Ingrese el {0}° numero",i);
                cadena = Console.ReadLine();

                while (!(int.TryParse(cadena, out numero)))
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el {0}° numero", i);
                    cadena = Console.ReadLine();
                }
                       
                if (i == 1)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else
                {
                    if (numero<minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }

                acumulador += numero;
            }

            promedio = acumulador / 5;

            Console.WriteLine("El minino es {0}",minimo);
            Console.WriteLine("El Maximo es {0}",maximo);
            Console.WriteLine("El promedio es {0}",promedio);

            Console.ReadKey();
        }
    }
}
