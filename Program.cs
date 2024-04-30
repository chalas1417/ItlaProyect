using System;

namespace CalcularSueldo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular();

            calcular.CalcularSueldo();

            SumaProducto sumaProducto = new SumaProducto();
            sumaProducto.RealizaSumaProducto();


    }
     
    }
}

