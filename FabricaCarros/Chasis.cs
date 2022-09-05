using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{    public enum materia
    {
        aluminio, acero
    }
    public class Chasis
    {
        private double peso;
        private materia material;// aluminio o acero

        public Chasis(double peso, materia material)
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
