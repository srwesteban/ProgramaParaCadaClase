using System;

namespace SalarioEmpleado
{

    class Program
    {
        public static void Main(String[] args)
        {
            Empleado empleado = new Empleado(123465,"William","Esteban", 1000000);
            Console.WriteLine(empleado);

           // empleado.getName()

            empleado.getIncrementarSalario(10);
            Console.WriteLine(empleado);

        }
    }
}
