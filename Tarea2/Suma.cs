using System;

namespace CalcularSueldo.Tarea2
{
    public class Suma
    {
        public void CalcalarSuma()
        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;

            try
            {
                Console.WriteLine("Ingrese el primer número:");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer número:");
                numero3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el cuarto número:");
                numero4 = Convert.ToInt32(Console.ReadLine());

                //suma de los primeros dos numeros
                int suma = numero1 + numero2;

                // resultado del producto numero3 y numero4
                int producto = numero3 * numero4;

                // Informar los resultados
                Console.WriteLine("La suma de los dos primeros números es: " + suma);
                Console.WriteLine("El producto del tercer y cuarto número es: " + producto);

                Console.ReadLine(); // Esperar para cerrar programa
            }
            catch (Exception ex)
            { 
               
            Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
            }
        }
    }
}
