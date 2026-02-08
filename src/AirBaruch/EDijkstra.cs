using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBaruch
{
    class EDijkstra
    {
        int ponderacionCosto;
        int ponderacionTiempo;
        Nodo destino;

        Nodo proveniente;

        bool definitivo;


        public EDijkstra(int ponderacionCosto, int ponderacionTiempo, Nodo destino, Nodo proveniente, bool definitivo)
        {
            this.ponderacionCosto = ponderacionCosto;
            this.ponderacionTiempo = ponderacionTiempo;
            this.destino = destino;
            this.proveniente = proveniente;
            this.definitivo = definitivo;
        }


    }
}
