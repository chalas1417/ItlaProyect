using System;

namespace CalcularSueldo
{

    public class Calcular
    {

        public void CalcularSueldo()
        {
            int horasTrabajadas = 0;
            int costoHoras = 0;
            decimal sueldo = 0;


            Console.WriteLine("Digite las horas trabajadas");
            horasTrabajadas= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dgite el costo de las horas");
            costoHoras= int.Parse(Console.ReadLine());

            sueldo = (horasTrabajadas * costoHoras);

            Console.WriteLine($"El coste de las horas es:{sueldo}");

            Console.WriteLine($"El sueldo es: {sueldo}");
            Console.ReadLine();
        }

    }
    
}
