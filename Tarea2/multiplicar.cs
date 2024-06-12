using System;

namespace CalcularSueldo.Tarea2
{
    public class multiplicar
    {
        public void multi()
        {
            int numero = 0;
            Console.WriteLine("Digite un numero");
            numero = int.Parse(Console.ReadLine()); 
            for (int i = 5; i < 50; i++)
            {
               Console.WriteLine(numero + "X" +i+" = "+ numero*i);
              
            }
            Console.ReadLine();
        }
    }
}
