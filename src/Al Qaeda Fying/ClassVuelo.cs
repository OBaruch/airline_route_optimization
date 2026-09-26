using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    [Serializable]
    public class ClassVuelo
    {
        string origen;                      
        string destino;                    
        int costo;
        int tiempo;
        string ruta;
        ListaPasajeros lp;


                                                           /////////////////////////////
        public ClassVuelo(string ori,string dest,int cost, int tiem)
        {
            lp = new ListaPasajeros();
            origen = ori;
            destino = dest;
            costo = cost;
            tiempo = tiem;
            ruta = "SK1" + ori + dest;
            
                                                          ///////////////////////////
        }

        public ListaVuelos ListaVuelos
        {
            get => default(ListaVuelos);
            set
            {
            }
        }

        public override string ToString()                         //Cuando se toma los a tipo abject se pasana tipo tu estring y regresa otros parametros
        {                                                         //se tiene que sobrescribir el metodo to esting en la clase.
            return ruta + "                 "+ origen + "                            " + destino + "                     " + tiempo + "               " + costo;
        }


        public string getRuta()
        {
            return ruta;
        }
        public string getDestino()
        {
            return destino;
        }
        public string getOrigen()
        {
            return origen;
        }
        public int getCosto()
        {
            return  costo;
        }
        public int getTiempo()
        {
            return tiempo;
        }
        public ListaPasajeros getListaPasajeros()
        {
            return lp;
        }

        public void eliminaPasajero(string a)
        {
            int asiento = Int32.Parse(a);

            for (int i = 0; i < lp.Count; i++)
            {
                if (lp[i].getAsiento() == asiento)
                {
                    lp.RemoveAt(i);
                }
                    
            }
            

        }
        

    }


}
