using System;

namespace CalcularSueldo.Tarea2.POO
{
    public class Personas
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }

        
            public Personas(string nombre, DateTime fechaNacimiento, string ciudad)
            {
                Nombre = nombre;
                FechaNacimiento = fechaNacimiento;
                Ciudad = ciudad;
            }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;

            if (hoy.Month < FechaNacimiento.Month || (hoy.Month == FechaNacimiento.Month && hoy.Day < FechaNacimiento.Day))
            {
                edad--;
            }

            return edad;
        }
        public void MostrarInformacion()
        {
            int edad = CalcularEdad();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }
    }

    


}
