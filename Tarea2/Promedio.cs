using System;


namespace CalcularSueldo.Tarea2
{
    public class Promedio
    {
        public void MostrarPromedio()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            try
            {
                Console.WriteLine("Digite la primera nota");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la segunda nota");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la tercena nota");
                num3 = Convert.ToInt32(Console.ReadLine());

                double promedio = (num1+ num2 + num3)/3;

                if (promedio >=7)
                {
                    Console.WriteLine("Promovido");
                }
                else if (promedio >=4 && promedio <7)
                {
                    Console.WriteLine("Regular");
                }
                else if (promedio < 4)
                {
                    Console.WriteLine("Reprobado");
                }
                Console.WriteLine("El promedio de las notas es: "+promedio);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocurrio el siguiente error:{ex.Message}");
            }
        }
    }
}
