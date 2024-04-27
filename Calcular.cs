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

        public void SumaProducto() 
        {
            int numero1 = 0;
            int numero2 = 0;
            decimal producto= 0;

            Console.WriteLine("Digite el numero1");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el numero2");
            numero2 = int.Parse(Console.ReadLine());


            producto = (numero1 + numero2);

            Console.WriteLine($"La suma es:{producto}");

            Console.ReadLine();
            
         

        
        }
    }

}
