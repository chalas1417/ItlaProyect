

namespace CalcularSueldo.Tarea2.POO
{
    public class EmpleadoBaseMasComision : EmpleadoComision
    {
        public decimal SalarioBase;

        public EmpleadoBaseMasComision(string PrimerNombre, 
            string ApellidoPaterno,
            string NumeroSeguroSocial,
            decimal salarioBase,decimal tarifacomision, decimal ventasBrutas)
        : base(PrimerNombre, ApellidoPaterno, 
              NumeroSeguroSocial, tarifacomision, ventasBrutas)
        {
            SalarioBase = salarioBase;
            TarifaComision = tarifacomision;
            VentasBrutas = ventasBrutas;
        }

        public override decimal CalcularIngreso() 
        {

            return (TarifaComision * VentasBrutas) + VentasBrutas; 
            
        }
    }
}
