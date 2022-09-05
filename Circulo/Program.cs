using System;
using System.Formats.Asn1;

namespace Circulo
{
    public class Program   
    {
        public static void Main(String[] args)
        {
            Circulo circulo = new Circulo();
            Console.WriteLine(circulo);

            double a = circulo.obtenerArea();
            double b = circulo.obtenerDiametro();

            Console.WriteLine($"mi area es: {a}");
            Console.WriteLine($"mi diametro es: {b}");


        }



    }



    




}
