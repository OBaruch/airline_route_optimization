using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Qaeda_Fying
{
    public partial class FormRegistoPasajero : Form
    {
        bool bandera;
        ClassVuelo vuelo;
        FormGraficoDelAvion aSeleccionado;

       


        ListaPasajeros lp = new ListaPasajeros();

        string nombre;
        string apellidos;
        string edad;
        int asiento;

        public FormRegistoPasajero(ClassVuelo vuelo, int asiento)
        {

            this.asiento = asiento;
            this.vuelo = vuelo;
            

            InitializeComponent();
            InicializaTextos();

            bandera = false;


            

            //textBoxAsiento.Text =                   //NUMERO DE ASIENTO SELECCIONADO
        }


        private void InicializaTextos()
        {
            textBoxRuta.Text = vuelo.getRuta(); 
            textBoxOrigen.Text = vuelo.getOrigen();
            textBoxDestino.Text = vuelo.getDestino();
            textBoxCosto.Text = vuelo.getCosto().ToString() + " " + "Pesos";
            textBoxTiempo.Text = vuelo.getTiempo().ToString() + " " + "Min";
            textNAsiento.Text = asiento.ToString();
        }


        public bool GetBandera()
        {
            return bandera;
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            bandera = true;

            nombre = textBoxNombres.Text;
            apellidos = textBoxApellidos.Text;
            edad = textBoxEdad.Text;
            


            ClassPasajero pasajero = new ClassPasajero(nombre, apellidos, Int32.Parse(edad), asiento,vuelo);

            vuelo.getListaPasajeros().Add(pasajero);
            


            MessageBox.Show("'" + getNombre() + "'" + " se a reservado exitosmente el asiento " +getAsiento() , "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();


        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public string getEdad()
        {
            return edad;
        }
        public string getAsiento()
        {
            return asiento.ToString();
        }


        private void FormRegistoPasajero_Load(object sender, EventArgs e)
        {
        }

        private void buttonVolverASeleccionarAsientos_Click(object sender, EventArgs e)
        {
            buttonReservar.Enabled = false;
            this.Close();

        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
           
        }
        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {

            if (textBoxEdad.Text != "" && textBoxApellidos.Text != "" && textBoxNombres.Text != "")
            {
                buttonReservar.Enabled = true;
            }
            else
            {
                buttonReservar.Enabled = false;
            }
        
        }
        private void textBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                if(!(char.IsSeparator(e.KeyChar)))
                {
                     MessageBox.Show("SOLO SE PERMITEN LETRAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     e.Handled = true;
                     return;
                }
               
            }

        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            if(textBoxApellidos.Text == " ")
            {
                textBoxApellidos.Text = "";
            }
            if (textBoxEdad.Text != "" && textBoxApellidos.Text != "" && textBoxNombres.Text != "")
            {
                buttonReservar.Enabled = true;
            }
            else
            {
                buttonReservar.Enabled = false;
            }
        }
        private void textBoxNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                if (!(char.IsSeparator(e.KeyChar)))
                {
                    MessageBox.Show("SOLO SE PERMITEN LETRAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }

        }

        private void textBoxNombres_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombres.Text == " ")
            {
                textBoxNombres.Text = "";
            }
            if (textBoxEdad.Text != "" && textBoxApellidos.Text != "" && textBoxNombres.Text != "")
            {
                buttonReservar.Enabled = true;
            }
            else
            {
                buttonReservar.Enabled = false;
            }
        }

        private void textBoxAsiento_TextChanged(object sender, EventArgs e)
        {
        /////////////////////////////////////////////////////////////////
        }

        private void labelCostoAutocompletada_Click(object sender, EventArgs e)
        {

        }
       
    }
}
