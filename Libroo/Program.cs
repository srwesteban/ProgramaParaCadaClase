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
            Libro libro;
            string opcion = "";
            do
            {
                Console.WriteLine("ingrese los libros del autor\n");

                Console.WriteLine("1. ingresar titulo");
                string titulo = Console.ReadLine();
                Console.WriteLine("2. ingresar numero de paginas");
                int paginas = Convert.ToInt32(Console.ReadLine());

                libro = new Libro(paginas, titulo);
                autor.agregarlibro(libro);

                Console.WriteLine("desea seguir adicionando libros S para continuar N para terminar");
                opcion = Console.ReadLine();


            } while (opcion != "n");

            Console.WriteLine("el autor " + autor + " ha escrito estos libros");
            autor.listar();
        }
    }


}




