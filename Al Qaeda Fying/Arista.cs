using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    class Arista
    {
        Nodo origen;
        Nodo destino;
        int ponderacionCosto;
        int ponderacionTiempo;

        public Arista(Nodo origen, Nodo destino, int ponderacionCosto, int ponderacionTiempo)
        {
            this.origen = origen;
            this.destino = destino;
            this.ponderacionCosto = ponderacionCosto;
            this.ponderacionTiempo = ponderacionTiempo;
        }

        internal ListaAristas ListaAristas
        {
            get => default(ListaAristas);
            set
            {
            }
        }

        public Nodo getNodoOrigen()
        {
            return origen;
        }

        public Nodo getNodoDestinon()
        {
            return destino;
        }

        public int getPonderacionCosto()
        {
            return ponderacionCosto;
        }

        public int getPonderacionTimepo()
        {
            return ponderacionTiempo;
        }
    }
}
