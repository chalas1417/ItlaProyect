using System;

namespace CalcularSueldo.Tarea2
{
    public class BucleFor
    {
        public void NumeroEntero()
        {
            Console.Write("Ingrese la cantidad de números enteros: ");
            int n = int.Parse(Console.ReadLine());

            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 1000)
                {
                    contador += 1;
                }
            }


            Console.WriteLine($"La cantidad de valores mayores o iguales a 1000 es: {contador}");
        }
    }
    }
