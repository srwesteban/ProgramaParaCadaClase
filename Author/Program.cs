using System;

namespace Author
{

    class Program
    {
     
        public static void Main(String[] args)
        {
            Autor autor = new Autor("william","will@gmail.com",((char)'m'));
            Console.WriteLine("Autor de ejemplo: "+ autor);

            Console.WriteLine("\nCrear nuevo autor\n");
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su email");
            string email = Console.ReadLine();
            char genero;
            do
            {
                Console.WriteLine("Ingrese su genero F o M");
                genero = Convert.ToChar(Console.ReadLine());
            } while(genero != 'f' && genero !='m');            

            Autor autor2 = new Autor(nombre,email,genero);

            Console.WriteLine(autor2);
        }
    }

}