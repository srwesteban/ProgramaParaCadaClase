using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    public class Circulo
    {
        private double radio { get; set; }

        public Circulo()
        {
            radio = 1.0;

        }
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public double obtenerArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public double obtenerDiametro()
        {
            return radio * 2;
        }
        public override string ToString()
        {
            return $"Soy un circulo mi radio es: {radio}";
        }
    }
}
