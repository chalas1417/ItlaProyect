using System;

namespace CalcularSueldo.Tarea2
{
    public class Multiplos
    {
        public void Multiplo()
        {

            Console.Write("Ingrese la cantidad de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            int multiplosDe3 = 0;
            int multiplosDe5 = 0;
            int multiplosDe3y5 = 0;

            try
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write($"Ingrese el número entero {i + 1}: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero % 3 == 0)
                    {
                        multiplosDe3++;
                    }
                    else if (numero % 5 == 0)
                    {
                        multiplosDe5++;
                    }
                    else if (numero % 3 == 0 && numero % 5 == 0)
                    {
                        multiplosDe3y5++;
                    }
                }

                Console.WriteLine($"Cantidad de números múltiplos de 3: {multiplosDe3}");
                Console.WriteLine($"Cantidad de números múltiplos de 5: {multiplosDe5}");
                Console.WriteLine($"Cantidad de números múltiplos de 3 y 5: {multiplosDe3y5}");



            }
            catch (Exception ex)
            {

               Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}"); ;
            }
        }
    }
}
