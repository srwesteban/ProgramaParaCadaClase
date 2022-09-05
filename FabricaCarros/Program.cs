using System;

namespace FabricaCarros
{

    class Program
    {
        public static void Main(String[] args)
        {

            Chasis chasisUno = new Chasis(2,"aluminio");
            Llantas llantasUno = new Llantas(12,"carreras");
            Carro carro = new Carro("rojo",llantasUno,chasisUno);

            Console.WriteLine(carro);
        }
    }
}