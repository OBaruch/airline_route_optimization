using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    [Serializable]
    public class ListaPasajeros: List<ClassPasajero>
    {

        public ListaPasajeros busquedaCoincidenciasNomApel(string dato,int opc )
        {
            ListaPasajeros lpF = new ListaPasajeros();
            
                switch (opc)
                {
                    case 1://Buscar por nombre
                        {
                            for (int i = 0; i < this.Count; i++)
                            {
                            string nombre = this[i].getNombre();
                                int j;

                                if(dato.Length >  this[i].getNombre().Length)
                                {
                                break;
                                }


                                for (j = 0; j < dato.Length; j++)
                                {
                                    if (nombre[j] != dato[j])
                                    {

                                        break;
                                    }

                                }
                        
                                if (j == dato.Length)
                                {
                                    lpF.Add(this[i]);
                                }
                            }


                          break;
                        }
                    case 2://buscar por apellido
                        {
                                for (int i = 0; i < this.Count; i++)
                                {
                                    string apellido = this[i].getApellido().ToString();
                                    int j;


                                    if (dato.Length > this[i].getApellido().Length)
                                    {
                                        break;
                                    }
                            for (j = 0; j < dato.Length; j++)
                                    {
                                        if (apellido[j] != dato[j])
                                        {
                                         break;
                                            
                                        }

                                    }
                                    if (j == dato.Length)
                                    {
                                        lpF.Add(this[i]);
                                    }
                                }

                                break;
                        }
                        case 3://buscar por asiento
                        {
                                for (int i = 0; i < this.Count; i++)
                                {
                                    
                                    string asiento = this[i].getAsiento().ToString();
                                    int j;


                                    if (dato.Length > asiento.Length)
                                    {
                                        break;
                                    }
                            for (j = 0; j < dato.Length; j++)
                                    {
                                        if (asiento[j]!= dato[j])
                                        {

                                            break;
                                        }

                                    }
                                    if (j == dato.Length)
                                    {
                                        lpF.Add(this[i]);
                                    }
                                }

                                break;
                        }
                        case 4://buscar por edad
                        {
                            for (int i = 0; i < this.Count; i++)
                            {
                                string edad = this[i].getEdad().ToString();
                                int j;


                                if (dato.Length > this[i].getEdad().ToString().Length)
                                {
                                    break;
                                }
                                 for (j = 0; j < dato.Length; j++)
                                 {
                                    if (edad[j] != dato[j])
                                    {

                                        break;
                                    }

                                 }
                                if (j == dato.Length)
                                {
                                    lpF.Add(this[i]);
                                }
                            }

                            break;
                        }
                }
            
            
            return lpF;
        }


        public ListaPasajeros quicksortNombre(ListaPasajeros lista, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = Asc(lista[central].getNombre()[0].ToString());
            i = primero;
            j = ultimo;

            
            do
            {
                
                
                while (Asc(lista[i].getNombre()[0].ToString()) < pivote) i++;
                while (Asc(lista[j].getNombre()[0].ToString()) > pivote) j--;
                if (i <= j)
                {
                    ClassPasajero temp;
                    temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksortNombre(lista, primero, j);
            }
            if (i < ultimo)
            {
                quicksortNombre(lista, i, ultimo);
            }



            return lista;
        }

        public ListaPasajeros quicksortRuta(ListaPasajeros lista, int primero, int ultimo)
        {
            
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = Asc(lista[central].getVuelo().getRuta()[3].ToString());
            i = primero;
            j = ultimo;


            do
            {


                while (Asc(lista[i].getVuelo().getRuta()[3].ToString()) < pivote) i++;
                while (Asc(lista[j].getVuelo().getRuta()[3].ToString()) > pivote) j--;
                if (i <= j)
                {
                    ClassPasajero temp;
                    temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksortRuta(lista, primero, j);
            }
            if (i < ultimo)
            {
                quicksortRuta(lista, i, ultimo);
            }



            return lista;
        }

        public ListaPasajeros quicksortAsiento(ListaPasajeros lista, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = lista[central].getAsiento();
            i = primero;
            j = ultimo;


            do
            {


                while (lista[i].getAsiento() < pivote) i++;
                while (lista[j].getAsiento()> pivote) j--;
                if (i <= j)
                {
                    ClassPasajero temp;
                    temp = lista[i];
                    lista[i] = lista[j];
                    lista[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksortAsiento(lista, primero, j);
            }
            if (i < ultimo)
            {
                quicksortAsiento(lista, i, ultimo);
            }



            return lista;
        }


        public static int Asc(string s)
        {
            return Encoding.ASCII.GetBytes(s)[0];
        }

    }
}
