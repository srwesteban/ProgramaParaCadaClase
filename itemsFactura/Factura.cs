using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemsFactura
{
    internal class Factura
    {
        public string nombreCliente { get; set; }
        public DateTime fecha { get; set; }
        public string numero { get; set; }
        public List<itemFactura> detalles { get; set; }

        public Factura(string nombreCliente, DateTime fecha, string numero)
        {
            this.nombreCliente = nombreCliente;
            this.fecha = fecha;
            this.numero = numero;

            detalles = new List<itemFactura>();
        }
        public void agragarDetalle(itemFactura a)
        {
            detalles.Add(a);
        }
        public double liquidarFactura()
        {
            double valorTotal = 0;

            foreach(itemFactura itemFactura in detalles)
            {
                valorTotal= valorTotal + itemFactura.getTotal();
            }
            return valorTotal;
        }
    }
}
