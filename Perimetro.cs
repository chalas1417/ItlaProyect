

using System;

namespace CalcularSueldo
{
    public class Perimetro
    {
        public string CalcularPerimetro(int cuadrado)
        {
            try
            {
                int perimetro = cuadrado  * 4;
                return "El perimetro de "+cuadrado+ " = "+perimetro;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
