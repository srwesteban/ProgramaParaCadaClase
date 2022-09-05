using System;

namespace cuentaBancaria
{

    class Program
    {
        static Cuenta micuenta; 

        public static void Main(String[] args)
        {

            micuenta = new Cuenta();

            int opcion;
            do
            {
                Console.WriteLine("Menu ");          
                Console.WriteLine("1.crear cuenta");
                Console.WriteLine("2.consiganr");
                Console.WriteLine("3.retirar");
                Console.WriteLine("4.transferir");
                Console.WriteLine("5. ver saldo");
                Console.WriteLine("0 para salir");
                opcion = (Convert.ToInt32(Console.ReadLine()));


                switch (opcion)
                {

                    case 1:
                        crearCuenta();

                        break;

                    case 2:

                        consignar();

                        break;

                    case 3:

                        retirar();

                        break;

                    case 4:
                        transferir();

                        break;


                    case 5:

                        Console.WriteLine(micuenta);

                        break;
                }

            } while (opcion != 0);
        }

        public static void transferir()
        {
            Console.WriteLine("Valor a transferir");

            int transfe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese numero de cuenta");

            string cuent = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la cuenta");

            string nombreCuenta = Console.ReadLine();

            Cuenta otracuenta = new Cuenta(cuent,nombreCuenta);
            micuenta.transferir(otracuenta,transfe);
            Console.WriteLine(micuenta);
            Console.WriteLine(otracuenta);


        }

        public static void retirar()
        {
            Console.WriteLine("Ingrese el valor a retirar");
            int retirarValor = Convert.ToInt32(Console.ReadLine());
            micuenta.debitar(retirarValor);

            Console.WriteLine(micuenta);

        }

        public static void consignar()
        {
            Console.WriteLine("Ingrese el valor a consigar");

            int consigar = Convert.ToInt32(Console.ReadLine());

            micuenta.creditar(consigar);
            Console.WriteLine(micuenta);

        }
        public static void crearCuenta()
        {

            Console.WriteLine("Ingrese el id de su cuenta");
            string id = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la cuenta");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el valor de la cuenta");
            int balance = Convert.ToInt32(Console.ReadLine());

            Cuenta otraCuenta = new Cuenta(id,nombre,balance);

            micuenta = otraCuenta;
        }


    }
}
