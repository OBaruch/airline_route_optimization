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
    public partial class FormPasajeros : Form
    {

        ListaVuelos lv;
        ListaPasajeros lpC;

        public FormPasajeros( ListaVuelos lv)
        {
            
            this.lv = lv;

            ListaPasajeros lpC = new ListaPasajeros();
            this.lpC = lpC;

            foreach (ClassVuelo v in lv)
            {
                foreach (ClassPasajero pas in v.getListaPasajeros())

                    this.lpC.Add(pas);
            }

           

            InitializeComponent();
            actualizaListaCompleta();


            groupBoxOrdenar.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });

            
            
           
            

        }

        private void listBoxListaPasajeros_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxListaPasajeros.SelectedIndex > -1)                  //Si no hay elementos seleccionado el boton no se habilita
            {
                buttonEliminarPasajero.Enabled = true;
                buttonEliminarPasajero.BackColor = Color.IndianRed;


            }
        }

        private void buttonRegresarAVuelos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxListaPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void buttonBusca_Click(object sender, EventArgs e)
        {

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {



        }
        private void textBoxBusca_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (radioButtonNombres.Checked == true || radioButtonApellidos.Checked == true)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    if (!(char.IsSeparator(e.KeyChar)))
                    {
                        MessageBox.Show("SOLO SE PERMITEN LETRAS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }

                }
            }
            if (radioButtonAsiento.Checked == true || radioButtonEdad.Checked == true)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                
            }



        }

        ListaPasajeros lpCF;
        private void textBoxBusca_TextChanged(object sender, EventArgs e)
        {
            listBoxListaPasajeros.Items.Clear();
            if (textBoxBusca.Text == " ")
            {
                textBoxBusca.Text = "";
                actualizaListaCompleta();

            }

            
            if (radioButtonNombres.Checked == true)
            {
                lpCF = lpC.busquedaCoincidenciasNomApel(textBoxBusca.Text, 1);
              

            }
            else
             {
                 if (radioButtonApellidos.Checked == true)
                 {
                   
                    lpCF = lpC.busquedaCoincidenciasNomApel(textBoxBusca.Text, 2);

                }
                else
                 {

                     if (radioButtonAsiento.Checked == true)
                     {
                       
                        lpCF = lpC.busquedaCoincidenciasNomApel(textBoxBusca.Text, 3);

                     }
                     else //EDAD
                     {
                       
                        lpCF = lpC.busquedaCoincidenciasNomApel(textBoxBusca.Text, 4);

                     }


                }

             }

            
            listBoxListaPasajeros.Items.Clear();
            for (int i = 0; i < lpCF.Count; i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL FILTRO
            {
                listBoxListaPasajeros.Items.Add(lpCF[i]);
            }
            
        }


        private void buttonEliminarPasajero_Click(object sender, EventArgs e)
        {
            
            ClassPasajero s;
            string v;
            string a;
            
            s = (ClassPasajero)listBoxListaPasajeros.SelectedItem;
            v = s.getVuelo().getRuta();
            a = s.getAsiento().ToString();
            foreach (ClassVuelo vueloDelPasajero in lv)
            {
                if (v == vueloDelPasajero.getRuta())
                {
                    vueloDelPasajero.eliminaPasajero(a); //LO ELIMINA DE LA LISTA DEL VUELO
                }
            }

            lpC.Remove(s);    //LO ELIINA DE TODA LA LISTA COMPLETA
            

            actualizaListaCompleta();


            if (radioButtonOrdenamietoNombre.Checked == true)
            {
                OrdenamientoNombre();

            }
            if (radioButtonOrdenamientoAsiento.Checked == true)
            {

                OrdenamientoAsiento();
            }
            if (radioButtonOrdenamientoRuta.Checked == true)
            {

                OrdenamientoRuta();
            }

        }




        private void radioButtonNombres_CheckedChanged(object sender, EventArgs e)
        {
            actualizaTexboxYBoton();
            groupBoxOrdenar.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });
        }

        private void radioButtonApellidos_CheckedChanged(object sender, EventArgs e)
        {
            actualizaTexboxYBoton();
            groupBoxOrdenar.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });
        }

        private void radioButtonEdad_CheckedChanged(object sender, EventArgs e)
        {
            actualizaTexboxYBoton();
            groupBoxOrdenar.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });
        }

        private void radioButtonAsiento_CheckedChanged(object sender, EventArgs e)
        {
            actualizaTexboxYBoton();
            groupBoxOrdenar.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });
        }

       

        //MTODOS PARA HAORRAR CODIGO//////////////////////////////////////////////////////////////
        private void actualizaListaCompleta()
        {
            listBoxListaPasajeros.Items.Clear();
            for (int i = 0; i < lpC.Count; i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL FILTRO
            {
                listBoxListaPasajeros.Items.Add(lpC[i]);
            }
            listBoxListaPasajeros.Refresh();
        }

        private void actualizaTexboxYBoton()
        {
            textBoxBusca.Text = "";
            actualizaListaCompleta();

            buttonEliminarPasajero.Enabled = false;
            buttonEliminarPasajero.BackColor = Color.Silver;

        }

        private void radioButtonOrdenamietoNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrdenamietoNombre.Checked == true)
            {

                OrdenamientoNombre();
            }
           
        }

        private void radioButtonOrdenamientoRuta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrdenamientoRuta.Checked == true)
            {
                OrdenamientoRuta();
            }
        }

        private void radioButtonOrdenamientoAsiento_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrdenamientoAsiento.Checked == true)
            {
                OrdenamientoAsiento();

            }
        }



        public void OrdenamientoRuta()
        {
            if (lpC.Count() != 0)
            {
                ListaPasajeros lp0 = new ListaPasajeros();

                if (lpC.Count() == listBoxListaPasajeros.Items.Count) //ESTO REVISA SI ORDENARA UN LISTA COMPLETA O LA FLTRADA ANTERIORMENTE
                {
                    lp0 = lpC.quicksortRuta(lpC, 0, lpC.Count() - 1);

                }
                else
                {
                    lp0 = lpCF.quicksortRuta(lpCF, 0, lpCF.Count() - 1);

                }

                listBoxListaPasajeros.Items.Clear();

                for (int i = 0; i < lp0.Count(); i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL ORDENAMIENTO
                {
                    listBoxListaPasajeros.Items.Add(lp0[i]);
                }
            }
            else
            {
                MessageBox.Show("No hay elmentos para ordenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
           
        }
        public void OrdenamientoNombre()
        {
            if (lpC.Count() != 0)
            {
                ListaPasajeros lp0 = new ListaPasajeros();

                if (lpC.Count() == listBoxListaPasajeros.Items.Count) //ESTO REVISA SI ORDENARA UN LISTA COMPLETA O LA FLTRADA ANTERIORMENTE
                {
                    lp0 = lpC.quicksortNombre(lpC, 0, lpC.Count() - 1);

                }
                else
                {
                    lp0 = lpCF.quicksortNombre(lpCF, 0, lpCF.Count() - 1);

                }

                listBoxListaPasajeros.Items.Clear();

                for (int i = 0; i < lp0.Count(); i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL ORDENAMIENTO
                {
                    listBoxListaPasajeros.Items.Add(lp0[i]);
                }
            }
            else
            {
                MessageBox.Show("No hay elmentos para ordenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
           
        }
        public void OrdenamientoAsiento()
        {
            if (lpC.Count() != 0)
            {
                ListaPasajeros lp0 = new ListaPasajeros();

                if (lpC.Count() == listBoxListaPasajeros.Items.Count) //ESTO REVISA SI ORDENARA UN LISTA COMPLETA O LA FLTRADA ANTERIORMENTE
                {
                    lp0 = lpC.quicksortAsiento(lpC, 0, lpC.Count() - 1);

                }
                else
                {
                    lp0 = lpCF.quicksortAsiento(lpCF, 0, lpCF.Count() - 1);

                }

                listBoxListaPasajeros.Items.Clear();

                for (int i = 0; i < lp0.Count(); i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL ORDENAMIENTO
                {
                    listBoxListaPasajeros.Items.Add(lp0[i]);
                }
            }
            else
            {
                MessageBox.Show("No hay elmentos para ordenar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
           
        }









    }
}