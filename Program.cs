using CalcularSueldo.Tarea2;
using CalcularSueldo.Tarea2.POO;
using System;

namespace CalcularSueldo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del empleado por comision:");
            string empleadoComisionNombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado por comision:");
            string empleadoComisionApellido = Console.ReadLine();

            Console.WriteLine("Ingrese el seguro social del empleado por comision:");
            string empleadoComisionSeguro = Console.ReadLine();

            Console.WriteLine("Ingrese la tarifa por comision del empleado por comision:");
            decimal empleadoComisionTarifaComision = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese ventas brutas del empleado por comision:");
            decimal empleadoComisionVentasBrutas = Convert.ToDecimal(Console.ReadLine());

            EmpleadoComision empleadoComision= new EmpleadoComision(empleadoComisionNombre, empleadoComisionApellido, empleadoComisionSeguro, empleadoComisionTarifaComision, empleadoComisionVentasBrutas);
           
            Console.WriteLine("Ingrese el nombre del empleado Asalaiado:");
            string empleadoAsalariadoNombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado asalariado:");
            string empleadoAsalariadoApellido = Console.ReadLine();

            Console.WriteLine("Ingrese el seguro social del empleado asalariado:");
            string empleadoAsalariadoSeguro = Console.ReadLine();

            Console.WriteLine("Ingrese la tarifa por comision del empleado por comision:");
            decimal empleadoSueldoSemanal = Convert.ToDecimal(Console.ReadLine());

            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado(empleadoAsalariadoNombre, empleadoAsalariadoApellido, empleadoAsalariadoSeguro, empleadoSueldoSemanal);
            
            Console.WriteLine("Ingrese el nombre del empleado por hora:");
            string empleadoPorHoraNombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado por hora:");
            string empleadoPorHoraApellido = Console.ReadLine();

            Console.WriteLine("Ingrese el seguro social del empleado por hora:");
            string empleadoPorHoraSeguro = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo por hora del empleado :");
            decimal empleadoPorHoraSueldoPorhora = Convert.ToDecimal(Console.ReadLine());
           
            Console.WriteLine("Ingrese las  horas trabajdas");
            decimal empleadoPorHorasTrabajadas = Convert.ToDecimal(Console.ReadLine());
           
            EmpleadoPorHora empleadoPorHora = new EmpleadoPorHora(empleadoPorHoraNombre, empleadoPorHoraApellido, empleadoPorHoraSeguro, empleadoPorHoraSueldoPorhora, empleadoPorHorasTrabajadas);

            Console.WriteLine("Ingrese el nombre del empleado por hora:");
            string empleadoBaseMasComisioNombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del empleado por hora:");
            string empleadoBaseMasComisionApellido = Console.ReadLine();

            Console.WriteLine("Ingrese el seguro social del empleado por hora:");
            string empleadoBaseMasComisionSeguro = Console.ReadLine();

            Console.WriteLine("Ingrese el salario base del empleado :");
            decimal empleadoSalarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese las  tarifas por comision:");
            decimal empleadotarifaComision = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese las  ventas brutas:");
            decimal empleadoVentasBrutas = Convert.ToDecimal(Console.ReadLine());
            EmpleadoBaseMasComision empleadoBaseMasComision = new EmpleadoBaseMasComision(empleadoBaseMasComisioNombre, empleadoBaseMasComisionApellido, empleadoBaseMasComisionSeguro, empleadoSalarioBase, empleadotarifaComision, empleadoVentasBrutas);



            Console.WriteLine($"El empleado: {empleadoComisionNombre} " +
                $"{empleadoComisionApellido} " +
                $"con el seguro social numero {empleadoComisionSeguro} " +
                $"tiene un ingreso de {empleadoComision.CalcularIngreso()}");
            Console.ReadLine();

            Console.WriteLine($"El empleado: {empleadoAsalariadoNombre} " +
                $"{empleadoAsalariadoApellido} " +
                $"con el seguro social numero {empleadoAsalariadoSeguro} " +
                $"tiene un ingreso de {empleadoAsalariado.CalcularIngreso()}");
            Console.ReadLine();

            Console.WriteLine($"El empleado: {empleadoPorHoraNombre} " +
                $"{empleadoPorHoraApellido} " +
                $"con el seguro social numero {empleadoPorHoraSeguro} " +
                $"tiene un ingreso de {empleadoPorHora.CalcularIngreso()}");
            Console.ReadLine();

            Console.WriteLine($"El empleado: {empleadoBaseMasComisioNombre} " +
               $"{empleadoPorHoraApellido} " +
               $"con el seguro social numero {empleadoBaseMasComisionApellido} " +
               $"tiene un ingreso de {empleadoBaseMasComision.CalcularIngreso()}");
            Console.ReadLine();








            multiplicar multiplicar = new multiplicar();
            multiplicar.multi();

            Promedio promedio = new Promedio();
            promedio.MostrarPromedio();

            Calcular calcular = new Calcular();
            Perimetro perimetro = new Perimetro();

            string lado = perimetro.CalcularPerimetro(4);
            Console.WriteLine(lado);

            Suma suma = new Suma();
            suma.CalcalarSuma();

            calcular.CalcularSueldo();

            SumaProducto sumaProducto = new SumaProducto();
            sumaProducto.RealizaSumaProducto();





        }

    }
}

