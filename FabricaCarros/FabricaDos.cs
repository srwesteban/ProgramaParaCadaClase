using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaCarros
{
    public class FabricaDos
    {
        public List<Carro> listaCarrosDos { get; set; }
        public int catidad { get; set; }

        public FabricaDos()
        {
            listaCarrosDos = new List<Carro>();
           
        }
        public void fabricarDos(Carro c, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                listaCarrosDos.Add(c);
                Console.WriteLine(listaCarrosDos[i] + "numero de carro: " + (i + 1));
            }
        }
    }
   
}
