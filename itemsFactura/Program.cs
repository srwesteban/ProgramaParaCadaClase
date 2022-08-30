using System;

namespace itemsFactura
{

    class Program
    {
        public static void Main(String[] args)
        {
            itemFactura item = new itemFactura("12321321", "manzana", 2, 1200);
            Console.WriteLine(item);

            Console.WriteLine("Ingrese el nombre del cliente");

            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de la factura");
            string num = Console.ReadLine();
            Console.WriteLine("Ingrese los detalles de la factura");

            string opcion;
            Factura factura = new Factura(nombre,DateTime.Now,num);
            do
            {
                Console.WriteLine("ingrese el id del detalle de la factura");
                string idDetalleFactura = Console.ReadLine();

                Console.WriteLine("Ingrese la descripcion del producto");
                string descrpcionProducto = Console.ReadLine();

                Console.WriteLine("Ingrese el precio unitario");

                double precioUnitarioProducto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese cantida del producto");
                int cantidadProducto = Convert.ToInt32(Console.ReadLine());

                itemFactura itemUno = new itemFactura(idDetalleFactura,descrpcionProducto,cantidadProducto,precioUnitarioProducto);

                factura.agragarDetalle(itemUno);

                Console.WriteLine("Desea seguir adicionando productor S/si N/no");

                opcion = Console.ReadLine();


            } while (opcion.ToLower().Equals("s"));


            Console.WriteLine($"El valor total de la factura es: {factura.liquidarFactura()}");
        }
    }
}
