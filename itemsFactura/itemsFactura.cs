using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemsFactura
{
    public class itemFactura
    {
        public string id { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precioUnitario { get; set; }

        public itemFactura(string id, string desc, int cant, double precio)
        {
            this.id = id;
            this.descripcion = desc;
            this.cantidad = cant;
            this.precioUnitario = precio;
        }
        public void items()
        {
            

        }

        public double getTotal()
        {
            double total = this.cantidad * this.precioUnitario;
            return total;
        }
        public override string ToString()
        {
            return $"Codigo:{id}  Nombre del producto: {descripcion} total: {getTotal()}";
        }
    }





}
