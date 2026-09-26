using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    [Serializable]
    public  class ListaVuelos : List<ClassVuelo>
    {

        public ListaVuelos busquedaCoincidencias(string dato,int opc)
        {
            ListaVuelos lvF = new ListaVuelos();
            switch(opc)
            {
                case 1://Buscar por ruta
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < dato.Length; j ++)
                            {
                                if (this[i].getRuta()[j] != dato[j])
                                {
                                    break;
                                }

                            }
                            if (j == dato.Length)
                            {
                                lvF.Add(this[i]);
                            }

                        }

                        break;
                    }
                case 2://buscar por origen 
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            if (this[i].getOrigen() == dato)
                            {
                                lvF.Add(this[i]);
                            }
                        }

                        break;
                    }
                case 3://buscar por destino
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            if (this[i].getDestino() == dato)
                            {
                                lvF.Add(this[i]);
                            }
                        }

                        break;
                    }
            }
            return lvF;
        }



        public ListaVuelos quicksortCosto(ListaVuelos lista, int primero, int ultimo)
        {
     
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = lista[central].getCosto();
            i = primero;
            j = ultimo;
            do
            {
                while (lista[i].getCosto() < pivote) i++;
                while (lista[j].getCosto() > pivote) j--;
                if (i <= j)
                {
                    ClassVuelo temp;
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
        public ListaVuelos quicksortTiempo(ListaVuelos lista, int primero, int ultimo)
        {

            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = lista[central].getTiempo();
            i = primero;
            j = ultimo;
            do
            {
                while (lista[i].getTiempo() < pivote) i++;
                while (lista[j].getTiempo() > pivote) j--;
                if (i <= j)
                {
                    ClassVuelo temp;
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
        
        public ListaVuelos quicksortOrigen(ListaVuelos lista, int primero, int ultimo)
        {

            int i, j, central;
            int pivote;
            central = (primero + ultimo) / 2;
            pivote = Asc(lista[central].getOrigen());
            i = primero;
            j = ultimo;
            do
            {
                while (Asc(lista[i].getOrigen()) < pivote) i++;
                while (Asc(lista[j].getOrigen()) > pivote) j--;
                if (i <= j)
                {
                    ClassVuelo temp;
                    temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksortOrigen(lista, primero, j);
            }
            if (i < ultimo)
            {
                quicksortOrigen(lista, i, ultimo);
            }



            return lista;
        }

        public ListaVuelos quicksortDestino(ListaVuelos lista, int primero, int ultimo)
        {

            int i, j, central;
            int pivote;
            central = (primero + ultimo) / 2;
            pivote = Asc(lista[central].getDestino());
            i = primero;
            j = ultimo;
            do
            {
                while (Asc(lista[i].getDestino()) < pivote) i++;
                while (Asc(lista[j].getDestino()) > pivote) j--;
                if (i <= j)
                {
                    ClassVuelo temp;
                    temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksortDestino(lista, primero, j);
            }
            if (i < ultimo)
            {
                quicksortDestino(lista, i, ultimo);
            }



            return lista;
        }












        public static int Asc(string s)
        {
            return Encoding.ASCII.GetBytes(s)[0];
        }
    }


}
