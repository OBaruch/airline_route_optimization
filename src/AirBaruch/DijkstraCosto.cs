using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBaruch
{
    [Serializable]
    public class DijkstraCosto
    {
        Grafo g;
        Nodo nInicial;
        int infinito = 0;
        int pesoDefi = 0;
        bool conex = false;
        

        List<ElementoDijkstra> vD = new List<ElementoDijkstra>();

        List<string> vDFinal = new List<string>();
        Dictionary<Nodo, int> nodeIndex = new Dictionary<Nodo, int>();
        Dictionary<Nodo, ElementoDijkstra> nodeElementMap = new Dictionary<Nodo, ElementoDijkstra>();

        public DijkstraCosto(Grafo g, char inicio, bool conex)
        {
            this.conex = conex;
            vD.Clear();
            this.g = g;
            Inicio(inicio);
            iniVecDij();
            generarDijkstra();
            resFinal();
            if (conex)
                conexiones();
        }
        private void Inicio(char c)
        {
            foreach (Nodo n in g.getListaNodos())
            {
                if (n.getCiudad().getNom() == c.ToString())
                {
                    nInicial = n;
                    break;
                }
            }

        }

        private void iniVecDij()
        {
            var nodos = g.getListaNodos();
            infinito = 0;
            nodeIndex.Clear();
            nodeElementMap.Clear();
            foreach (Nodo n in nodos)
            {
                n.getElementoD().serReiniciado();
                nodeIndex[n] = nodeIndex.Count;
                nodeElementMap[n] = n.getElementoD();
            }
                

            foreach (Nodo n in nodos)
            {
                vD.Add(n.getElementoD());
                foreach (Ady ady in n.getListaAdyacencia())
                {
                    infinito += ady.getPonderacionCosto();
                }
            }
            foreach (ElementoDijkstra e in vD)
            {
                if (nInicial == e.getn())
                    e.setPeso(0);
                else
                    e.setPeso(infinito);
            }

        }
        private void generarDijkstra()
        {
            bool bandera = true;
            while (bandera)
            {
                ElementoDijkstra e = seleccionaVD();
                e.setDefinitivo();
                pesoDefi = e.getPeso();
                actualizarPesos(e);
                bandera = checarBandera();
            }
        }
        private ElementoDijkstra seleccionaVD()
        {
            ElementoDijkstra posible = vD[0];
            int pesoM = infinito;

            foreach (ElementoDijkstra e in vD)
            {
                if (e.getDefinitivo() == false)
                {
                    if (e.getPeso() < pesoM)
                    {
                        pesoM = e.getPeso();
                        posible = e;
                    }
                }
            }
            return posible;
        }
        private void actualizarPesos(ElementoDijkstra e)
        {
            Nodo nID = e.getn();
            foreach (Ady ady in nID.getListaAdyacencia())
            {
                Nodo nAdy = ady.getNodo();
                if (nAdy.getElementoD().getDefinitivo() == false)
                {
                    int indexAdy = nodeIndex[nAdy];
                    if (ady.getPonderacionCosto() + pesoDefi < vD[indexAdy].getPeso())
                    {
                        vD[indexAdy].setProveniente(nID, ady.getPonderacionCosto() + pesoDefi);
                    }
                }

            }

        }
        private bool checarBandera()
        {
            foreach (ElementoDijkstra e in vD)
            {
                if (e.getDefinitivo() != true && e.getPeso() != infinito)
                    return true;
            }
            return false;
        }
        private void resFinal()
        {
            for (int i = 0; i < vD.Count(); i++)
            {
                if (vD[i].getPeso() != infinito)
                {
                    string nueFinal = Convert.ToString(vD[i].getPeso()) + "<-" + vD[i].getn().getCiudad().getNom();
                    ElementoDijkstra x = vD[i];
                    while (x.getProveniente() != null)
                    {
                        ElementoDijkstra siguiente = nodeElementMap[x.getProveniente()];
                        nueFinal += "<-" + siguiente.getn().getCiudad().getNom();
                        x = siguiente;
                    }
                    vDFinal.Add(nueFinal);
                }
            }
        }
        //Publicos---------------------------
        public List<string> getvD()
        {
            return vDFinal;
        }
        public void conexiones()
        {
            for (int i = 0; i < vD.Count(); i++)
            {
                if (vD[i].getProveniente() != null)
                {
                    vD[i].getProveniente().setPrimKruskal(vD[i].getn().getCiudad().getNom());
                }
            }
        }
    }
}
