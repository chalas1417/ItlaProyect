namespace CalcularSueldo.Tarea2.POO
{
    public abstract class Emplleado2
    {
        public string PrimerNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string NumeroSeguridadSocial { get; set; }
        public Emplleado2(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguridadSocial = numeroSeguroSocial;
        }
        public abstract decimal CalcularIngreso();

    }
}
