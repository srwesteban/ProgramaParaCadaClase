using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioEmpleado
{
    public class Empleado
    {

        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public  int salarioEmpleado { get; set; }
        
        
        public Empleado(int id, string name, string lastname , int salario)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastname;
            this.salarioEmpleado = salario; 
                        
        }
        public string getName()
        {
            //return name +" "+ lastName;
            //return string.Format("{0} {1}", name,lastName);
            return $" el nombre del empleado es: {name} {lastName}";
        }
        public int getSalarioAnual()
        {
            return salarioEmpleado * 12;
        }
        public int getIncrementarSalario(int porcentaje)
        {
            int incremento = (salarioEmpleado * porcentaje/100) + salarioEmpleado;
            salarioEmpleado = incremento;

            return salarioEmpleado;
        }
        public override string ToString()
        {
            return $"id:{id} nombre:{name} apellido:{lastName} salario:{salarioEmpleado}";
        }

    }
}
