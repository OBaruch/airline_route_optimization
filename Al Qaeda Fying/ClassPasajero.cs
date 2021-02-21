using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al_Qaeda_Fying
{
    [Serializable]
    public class ClassPasajero
    {
        
        string nombres;
        string apellidos;
        int edad;
        int  asiento;
        ClassVuelo vueloDelPasajero;
        
         

        public ClassPasajero(string nombres, string apellidos, int edad, int asiento, ClassVuelo vueloDelPasajero)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.asiento = asiento;
            this.vueloDelPasajero = vueloDelPasajero;
          
        }

        public ListaPasajeros ListaPasajeros
        {
            get => default(ListaPasajeros);
            set
            {
            }
        }

        public override string ToString()
        {
            
            return vueloDelPasajero.getRuta() + "       " + nombres + "__" + apellidos + "                             " + edad + "                                   " + asiento;
        }

  
        public int getAsiento()
        {
            return asiento;
        }
        public string getNombre()
        {
            return nombres;
        }
        public string getApellido()
        {
            return apellidos;
        }
        public int getEdad()
        {
            return edad;
        }
        public ClassVuelo getVuelo()
        {
            return vueloDelPasajero;
        }


    }

    
}
