

using System;

namespace CalcularSueldo.Tarea2
{
    public class NumeroPositivo
    { 
        public void Positivo()
        {
            Console.Write("Ingrese un número positivo de uno o dos dígitos (1..99): ");
            string input = Console.ReadLine();

           
            if (int.TryParse(input, out int numero) && numero > 0 && numero < 100)
            {
                if (numero < 10)
                {
                    Console.WriteLine("El número tiene un dígito.");
                }
                else
                {
                    Console.WriteLine("El número tiene dos dígitos.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número positivo de uno o dos dígitos (1..99).");
            }
        }
    }
}

