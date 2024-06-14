
using System.Runtime.Remoting.Messaging;

namespace CalcularSueldo.Tarea2.POO
{
    public class EmpleadoComision : Emplleado2
    {
        public decimal VentasBrutas;

        public decimal TarifaComision;

        public EmpleadoComision(string PrimerNombre,
            string ApellidoPaterno,
            string NumeroSeguroSocial,
            decimal tarifaComision,
            decimal ventasBrutas)
       : base(PrimerNombre, ApellidoPaterno, NumeroSeguroSocial)
        {
            TarifaComision = tarifaComision;
            VentasBrutas = ventasBrutas;
        }
        public override decimal CalcularIngreso()
        {

            return TarifaComision * VentasBrutas;

        }


    }
}
