using CalcularSueldo.Tarea2;
using System;

namespace CalcularSueldo
{
    public class SumaProducto
    {
      
        public void RealizaSumaProducto()
        {
            int numero1 = 0;
            int numero2 = 0;
            int suma = 0;
            int producto = 0;


            try
            {
                Console.WriteLine("Digite el numero1");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el numero2");
                numero2 = int.Parse(Console.ReadLine());

                suma= (numero1 + numero2);

                producto = (numero1 * numero2);

                Console.WriteLine("La suma es:" + Convert.ToString(suma) + " & el producto es:" +Convert.ToString(producto));
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio el siguiente error:{ex.Message}");

            }

           
        }
    
        
    }
}
