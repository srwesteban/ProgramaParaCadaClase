using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{
    public class Chasis
    {
        private double peso;
        private string material;// aluminio o acero

        public Chasis(double peso, string material)
        {
            this.peso = peso;
            this.material = material;
        }
        public override string ToString()
        {
            return $"peso: {peso}kg, material: {material}";
        }
    }
}
