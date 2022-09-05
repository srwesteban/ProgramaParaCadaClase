using System;
using System.Reflection.PortableExecutable;

namespace FabricaCarros
{

    class Program
    {
        static Carro micarro;
        public static void Main(String[] args)
        {            
            Chasis chasisUno = new Chasis(2,materia.aluminio);
            Llantas llantasUno = new Llantas(12, "carreras");
            Carro carro = new Carro("rojo", llantasUno, chasisUno);
            //Console.WriteLine(carro);

            Console.WriteLine("crear carro\n");
            crearCarro();       
        }
        public static void crearCarro()
        {
            Console.WriteLine("ingrese el color ");
            string color = Console.ReadLine();
            Console.WriteLine("ingrese tamano de llantas");
            int tamano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese tipo de llantas");
            string tipo = Console.ReadLine();
            Console.WriteLine("ingrese el material 1.aluminio 2.acero");
            int opc=Convert.ToInt32(Console.ReadLine());
            int peso=0;
            materia mate = new materia();
            if (opc == 1)
            {
                mate = materia.aluminio;
                peso = 1000;
            }
            if (opc == 2)
            {
                mate = materia.acero;
                peso = 2000;
            }
            Chasis chasisDos = new Chasis(peso, mate);
            Llantas llantasDos = new Llantas(tamano,tipo);
            Carro carroDos = new Carro(color, llantasDos, chasisDos);

            Console.WriteLine(carroDos);
            Console.WriteLine("\nEscoje la fabrica donde seran producidos\n");
            Console.WriteLine("1.fabrica centro 2. fabrica este");
            opc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (opc == 1)
            {
                FabricaUno fabricaUno = new FabricaUno();
                Console.WriteLine("Fabrica centro");
                Console.WriteLine("...");
                fabricaUno.fabricar(carroDos, 100);
            }
            if (opc == 2)
            {
                FabricaDos fabricaDos = new FabricaDos();
                Console.WriteLine("Fabrica este");
                Console.WriteLine("...");
                fabricaDos.fabricarDos(carroDos, 100);
            }   

        }

    }
    
}