using System;

namespace CalcularSueldo.Tarea2
{
    internal class Triangulo
    {
        public void BaseTriangulo()
        {
            Console.WriteLine("Ingrese la cantidad de pares de datos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nIngrese la base del triángulo {i + 1}:");
                double baseTriangulo = double.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese la altura del triángulo {i + 1}:");
                double alturaTriangulo = double.Parse(Console.ReadLine());

             
                double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

             
                Console.WriteLine($"El área del triángulo {i + 1} es: {areaTriangulo}");
                Console.ReadLine();
            }

        }




    }
}

