using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    class ListaAristas : List<Arista>
    {
        public ListaAristas quicksortCosto(ListaAristas lista, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = lista[central].getPonderacionCosto();
            i = primero;
            j = ultimo;


            do
            {


                while (lista[i].getPonderacionCosto() < pivote) i++;
                while (lista[j].getPonderacionCosto() > pivote) j--;
                if (i <= j)
                {
                    Arista temp;
                    temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksortCosto(lista, primero, j);
            }
            if (i < ultimo)
            {
                quicksortCosto(lista, i, ultimo);
            }



            return lista;
        }

        public ListaAristas quicksortTiempo(ListaAristas lista, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = lista[central].getPonderacionTimepo();
            i = primero;
            j = ultimo;


            do
            {


                while (lista[i].getPonderacionTimepo() < pivote) i++;
                while (lista[j].getPonderacionTimepo() > pivote) j--;
                if (i <= j)
                {
                    Arista temp;
                    temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksortTiempo(lista, primero, j);
            }
            if (i < ultimo)
            {
                quicksortTiempo(lista, i, ultimo);
            }



            return lista;
        }
        public Arista seleccionFactibel(ListaAristas candidatos , List<Nodo> S)
        {
            Nodo Dvacio = new Nodo("Destino Vacio EEROR");
            Nodo Ovacio = new Nodo("Inicio Vacio ERROR");
            Arista arista = new Arista(Ovacio, Dvacio,0,0);
           

            foreach(Arista c in candidatos)
            {
                if(!S.Contains(c.getNodoOrigen()) && !S.Contains(c.getNodoDestinon()))
                {
                    continue;
                }
                if (S.Contains(c.getNodoOrigen()) && S.Contains(c.getNodoDestinon()))
                {
                    continue;
                }


                if(S.Contains(c.getNodoOrigen()) && !S.Contains(c.getNodoDestinon()))
                {
                    arista = c;
                    break;
                    
                }
                if(S.Contains(c.getNodoDestinon()) && !S.Contains(c.getNodoOrigen()))
                {
                    arista = c;
                    break;
                }
                
            }

            return arista;
            
        }

    }
}
