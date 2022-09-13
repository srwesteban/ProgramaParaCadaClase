﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroAutor
{
    public class Autor
    {
        public string Name { get; set; }
        public List<Libro> listalibros { get; set; }


        public Autor(string name)
        {

            this.Name = name;

            listalibros = new List<Libro>();
        }

        public void agregarlibro(Libro a)
        {
            listalibros.Add(a);

        }
    }

}
