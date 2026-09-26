using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Al_Qaeda_Fying
{
    [Serializable]
    public class Grafo: ICloneable
    {
        List<Nodo> listaNodos;
        ListaVuelos lv;
        public Grafo(ListaVuelos lv)
        {
            this.lv = lv;
            ///crear Nodos
            
            bool existe;
            
            listaNodos = new List<Nodo>();
            foreach (ClassVuelo v in lv)
            {
                existe = false;

                foreach (Nodo nAux in listaNodos)
                {
                    if (v.getOrigen() == nAux.getCiudad().getNom().ToString())
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    Nodo n = new Nodo(v.getOrigen());
                    listaNodos.Add(n);
                }
                existe = false;

                foreach (Nodo nAux2 in listaNodos)
                {
                    if (v.getDestino() == nAux2.getCiudad().getNom().ToString())
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    Nodo n = new Nodo(v.getDestino());
                    listaNodos.Add(n);
                }

            }

            //crea adyacencias
            foreach (Nodo n in listaNodos)
            {
                foreach (ClassVuelo v in lv)
                {
                    if (n.getCiudad().getNom().ToString() == v.getOrigen())
                    {
                        foreach (Nodo nAux in listaNodos)
                        {
                            if (nAux.getCiudad().getNom().ToString() == v.getDestino())
                            {
                                Ady a = new Ady(nAux);
                                n.setAdy(a);
                                a.setPonderacionCosto(v.getCosto());
                                a.setPonderacionTiempo(v.getTiempo());
                            }
                        }

                    }
                }
            }
            

            
        }

        public Nodo Nodo
        {
            get => default(Nodo);
            set
            {
            }
        }




        /////////////////////////////////////////////////////////////////////
        public void imprime()
        {
            foreach (Nodo n in listaNodos)
            {
                Console.Write(n.getCiudad().getNom()+ " -> ");
                n.imprimeLA();
                Console.Write("\n");


            }

        }
        ////////////////////////////////////////////////////////////////////////

        public List<Nodo> getListaNodos()
        {
            return listaNodos;
        }
        
        public void setListaNodos(Nodo n)
        {
            this.listaNodos.Add(n);
            


        }

        //Eliminar nood
        public void eliminarNodo(Nodo n)
        {
            this.listaNodos.Remove(n);
        }


        //CLONACION DEL OBJETO
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }


    ///////////////////////////////////////////////////////////////////////////////////////////
    [Serializable]
    public class Nodo
    {
        Ciudad ciudad;
        List<Ady> listaAdy;

        ElementoDijkstra elemento;

        string Primkruskal;

        public Nodo(string c)
        {
            ciudad = new Ciudad(c);
            listaAdy = new List<Ady>();
            elemento = new ElementoDijkstra(this);
        }

        public Ciudad Ciudad
        {
            get => default(Ciudad);
            set
            {
            }
        }

        public Ady Ady
        {
            get => default(Ady);
            set
            {
            }
        }

        public Ciudad getCiudad()
        {
            return this.ciudad;
        }

        public void setAdy(Ady a)
        {
            this.listaAdy.Add(a);

        }
        public void eiminarAdy(Ady a)
        {
            
            this.listaAdy.Remove(a);
            
        }

        
        public List<Ady> getListaAdyacencia()
        {
            return listaAdy;
        }

        public ElementoDijkstra getElementoD()
        {
            return elemento;
        }

        public Ady getAdy(int i)
        {
            return listaAdy[i];
        }
        public void setPrimKruskal(string c)
        {
            Primkruskal += c;
        }

        public void imprimeLA()
        {
            foreach (Ady a in listaAdy)
            {
                Console.Write(a.getNodo().getCiudad().getNom()+ "->");
            }
        }

    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////
    [Serializable]
    public class Ady
    {
        Nodo n;
        int ponderacionCosto;
        int ponderacionTiempo;

        public Ady(Nodo n)
        {
            this.n = n;
        }

        public Nodo getNodo()
        {
            return n;
        }

        public int getPonderacionCosto()
        {
            return ponderacionCosto;
        }
        public int getPonderacionTiempo()
        {
            return ponderacionTiempo;
        }

        public void setPonderacionCosto(int pC)
        {
            this.ponderacionCosto = pC;
        }
        public void setPonderacionTiempo(int pT)
        {
            this.ponderacionTiempo = pT;
        }



    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////
    [Serializable]
    public class Ciudad
    {
        string nombre;
        int x, y;

        //Constructor
        public Ciudad(string nombre)
        {
            this.nombre = nombre;
        }

        //GET'S
        public string getNom()
        {
            return nombre;
        }
       
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        //SET'S
        public void setNombre(string c)
        {
            this.nombre = c;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        

    }


}



     
