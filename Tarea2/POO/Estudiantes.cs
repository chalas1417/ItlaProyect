using System;

namespace CalcularSueldo.Tarea2.POO
{
    public class Estudiantes : Personas
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiantes(string nombre, DateTime fechaNacimiento, string ciudad, string carrera, string matricula)
        : base(nombre, fechaNacimiento, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }
    }
}
