

namespace CalcularSueldo.Tarea2.POO
{
    public class EmpleadoAsalariado : Emplleado2
    {
        public decimal SalarioSemanal;

        public EmpleadoAsalariado(string PrimerNombre, 
            string ApellidoPaterno,             
            string numeroSeguroSocial, decimal salarioSemanal)
             : base(PrimerNombre, ApellidoPaterno, numeroSeguroSocial)
        {
            SalarioSemanal = salarioSemanal;
        }
        public override decimal CalcularIngreso()
        {
            return SalarioSemanal;
        }
    }
}
