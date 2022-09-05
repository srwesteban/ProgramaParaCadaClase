using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{
    public class Carro
    {
        private string color  { get; set; }
        private Llantas llantas;
        private Chasis chasis;


        public Carro(string color, Llantas llantas, Chasis chasis)
        {
            this.color = color;
            this.llantas = llantas;
            this.chasis = chasis;

        }
        
        public override string ToString()
        {
            return $"\nEspecificaciones:\n\ncolor: {color}, llantas = ({llantas}) chasis = ({chasis})";

        }        
       
    }
    


}
