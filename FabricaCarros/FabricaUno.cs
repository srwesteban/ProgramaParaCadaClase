using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{
    public class FabricaUno
    {
        public List<Carro> listaCarros { get; set; }

        public FabricaUno()
        {
            listaCarros = new List<Carro>();
        }
    
        public void fabricar(Carro c, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                listaCarros.Add(c);
                Console.WriteLine(listaCarros[i] + "numero de carro: " + (i + 1));
            }              
            
        }
    }
   


}
