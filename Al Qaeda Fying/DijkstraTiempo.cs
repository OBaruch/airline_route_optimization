using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    [Serializable]
    public class DijkstraTiempo
    {
        Grafo g;
        Nodo nInicial;
        int infinito = 0;
        int pesoDefi = 0;
        bool conex = false;
        

        List<ElementoDijkstra> vD = new List<ElementoDijkstra>();

        List<string> vDFinal = new List<string>();

        public DijkstraTiempo(Grafo g, char inicio, bool conex)
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
            foreach (Nodo n in g.getListaNodos())
            {
                n.getElementoD().serReiniciado();
            }
                

            foreach (Nodo n in g.getListaNodos())
            {
                vD.Add(n.getElementoD());
                for (int i = 0; i < n.getListaAdyacencia().Count(); i++)
                    infinito += n.getAdy(i).getPonderacionTiempo();
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
            for (int i = 0; i < nID.getListaAdyacencia().Count(); i++)
            {
                Nodo nAdy = nID.getAdy(i).getNodo();
                if (nAdy.getElementoD().getDefinitivo() == false)
                {
                    int indexAdy = g.getListaNodos().IndexOf(nAdy);
                    if (nID.getAdy(i).getPonderacionTiempo() + pesoDefi < vD[indexAdy].getPeso())
                    {
                        vD[indexAdy].setProveniente(nID, nID.getAdy(i).getPonderacionTiempo() + pesoDefi);
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
                        for (int k = 0; k < vD.Count(); k++)
                        {
                            if (x.getProveniente() == vD[k].getn())
                            {
                                nueFinal += "<-" + vD[k].getn().getCiudad().getNom();
                                x = vD[k];
                                break;
                            }
                        }
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
                foreach (Nodo n in g.getListaNodos())
                {
                    if (n.getCiudad().getNom() == vD[i].getn().getCiudad().getNom() && vD[i].getProveniente() != null)
                    {
                        foreach (Nodo w in g.getListaNodos())
                        {
                            if (w == vD[i].getProveniente())
                            {
                                w.setPrimKruskal(vD[i].getn().getCiudad().getNom());
                            }
                        }
                    }

                }
            }
        }
    }
}
