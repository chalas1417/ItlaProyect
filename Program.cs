using CalcularSueldo.Tarea2;
using CalcularSueldo.Tarea2.POO;
using System;

namespace CalcularSueldo
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpleadoComision empleadoComision = new EmpleadoComision("Alvaro","Blanco","123456",5,6);

            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado("", "", "", 4);

            EmpleadoPorHora empleadoPorHora = new EmpleadoPorHora("", "", "", 2, 3);

            EmpleadoBaseMasComision empleadoBaseMasComision = new EmpleadoBaseMasComision("", "", "", 8, 9, 1);

            multiplicar multiplicar = new multiplicar();
            multiplicar.multi();
            Promedio promedio = new Promedio();
            promedio.MostrarPromedio();

            Calcular calcular = new Calcular();
            Perimetro perimetro = new Perimetro();

            string lado = perimetro.CalcularPerimetro(4);
            Console.WriteLine(lado);

            Suma suma = new Suma();
            suma.CalcalarSuma();



            calcular.CalcularSueldo();

            SumaProducto sumaProducto = new SumaProducto();
            sumaProducto.RealizaSumaProducto();





        }

    }
}

