using CalcularSueldo.Tarea2;
using System;

namespace CalcularSueldo
{
    public class Program
    {
        static void Main(string[] args)
        {
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

