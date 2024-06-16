using System;

namespace CalcularSueldo.Tarea2.POO
{
    public class EmpleadoBaseMasComision : EmpleadoComision
    {
        public decimal SalarioBase = 0;

        public EmpleadoBaseMasComision(string PrimerNombre,
            string ApellidoPaterno,
            string NumeroSeguroSocial,
            decimal salarioBase, decimal tarifacomision, decimal ventasBrutas)
        : base(PrimerNombre, ApellidoPaterno,
              NumeroSeguroSocial, tarifacomision, ventasBrutas)
        {
            SalarioBase = salarioBase;
            TarifaComision = tarifacomision;
            VentasBrutas = ventasBrutas;
        }

        public override decimal CalcularIngreso()

        {
            try
            {
                TarifaComision = (TarifaComision* VentasBrutas + SalarioBase);
                return TarifaComision;
            }
            catch
            {
                return TarifaComision;
            }
        }
    }
}
