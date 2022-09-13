using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutor
{
    public class Libro
    {
        public int paginas { get; set; }
        public string titulo { get; set; }

        public Libro(int a, string b)
        {
            this.paginas = a;
            this.titulo = b;
        }
       
        public override string ToString()
        {
            return $"el libro titulado  {titulo} que tiene este numero de paginas {paginas}";
        }
        







    }


}
