using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    class Autor
    {
        //variables de la instancia

        private string nombre;
        private string email;
        private char genero;

        public Autor(string nombre, string email, char genero)
        {
            this.nombre = nombre;
            this.email = email; 
            this.genero = genero;
        }

        // metodos

        public string obtenerNombre()
        {
            return nombre;
        }
        public string obtenerEmail()
        {
            return email;
        }
        public void eEmail(string email)
        {
            Console.WriteLine(email);
        }
        public char obtenerGenero()
        {
            return genero;
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}, Email: {email}, Genero: {genero}";
        }



    }
}
