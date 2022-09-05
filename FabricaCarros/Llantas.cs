using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{
    public class Llantas
    {
        private int tamano;
        private string tipo;
        public Llantas(int tamano, string tipo)
        {
            this.tamano = tamano;
            this.tipo = tipo;
        }
        public override string ToString()
        {
            return $"tamano: {tamano} pulgadas, tipo: {tipo}";
        }
    }
}
