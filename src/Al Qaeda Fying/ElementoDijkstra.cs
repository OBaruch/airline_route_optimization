using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    [Serializable]
    public class ElementoDijkstra
    {
        int peso;
        Nodo n;
        Nodo proveniente;

        bool definitivo;

        public ElementoDijkstra(Nodo n)
        {

            this.n = n;

        }

        public int getPeso()
        {
            return peso;
        }

        public Nodo getn()
        {
            return n;
        }

        public Nodo getProveniente()
        {
            return proveniente;
        }

        public bool getDefinitivo()
        {
            return definitivo;
        }



        public void setPeso(int peso)
        {
            this.peso = peso;
        }
       
        public void setDefinitivo()
        {
            definitivo = true;
        }

        public void setProveniente(Nodo p, int peso)
        {
            proveniente = p;
            this.peso = peso;
        }

        public void serReiniciado()
        {
            proveniente = null;
            peso = 0;
            definitivo = false;
        }

       
    }
}
