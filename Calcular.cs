using System;
using System.ComponentModel;

namespace CalcularSueldo
{

    public class Calcular
    {

        public void CalcularSueldo()
        {
            decimal horasTrabajadas = 0;
            decimal costoHoras = 0;
            decimal sueldo = 0;


            Console.WriteLine("Digite las horas trabajadas");
            horasTrabajadas= Int32Converter(Console.ReadLine());

            Console.WriteLine("Dgite el costo de las horas");
            costoHoras= int.Parse(Console.ReadLine());

            sueldo = (horasTrabajadas * costoHoras);

            Console.WriteLine($"El coste de las horas es:{sueldo}");

            Console.WriteLine($"El sueldo es: {sueldo}");
            Console.ReadLine();
        }

        private int Int32Converter(string v)
        {
            throw new NotImplementedException();
        }
    }
    
}
