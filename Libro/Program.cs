using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibroAutor
{
    class Program
    {
        public static void Main(String[] args)
        {


            Console.WriteLine("Escriba el nombre del autor");

            string nombre = Console.ReadLine();

            Autor autor = new Autor(nombre);

            string opcion = "";
            do
            {
                Console.WriteLine("ingresar libros del autor");

                Console.WriteLine("ingresar titulo");
                string titulo = Console.ReadLine();
                int paginas = Convert.ToInt32(Console.ReadLine());

                Libro libro = new Libro(paginas, titulo);
                autor.agregarlibro(libro);

                Console.WriteLine("desea seguir adicionando libros S para continuar N para terminar");
                opcion = Console.ReadLine();


            } while (opcion == "n");

            Console.WriteLine(autor);
        }
    }


}




