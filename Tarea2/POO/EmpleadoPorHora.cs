namespace CalcularSueldo.Tarea2.POO
{
    public class EmpleadoPorHora : Emplleado2
    {
        private decimal SueldoPorHora = 0;
        private decimal HorasTrabajadas;
        public EmpleadoPorHora(string primerNombre,
            string apellidoPaterno,
            string numeroSeguroSocial,
            decimal sueldoPorHora,
            decimal horasTrabajadas)
                    : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }
        public override decimal CalcularIngreso()
        {
            try
            {
                if (HorasTrabajadas <= 40)
                {
                    SueldoPorHora = SueldoPorHora * HorasTrabajadas;
                }
                else
                {
                    SueldoPorHora = (40 * SueldoPorHora) +
                        (HorasTrabajadas - 40) *
                        (SueldoPorHora * (decimal)1.5);

                }
                return SueldoPorHora;
            }
            catch
            {
                return SueldoPorHora;
            }
        }
    }
}
