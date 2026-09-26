using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Al_Qaeda_Fying
{
    public partial class FormMainVuelos : Form
    {
        ClassVuelo vuelo;
        ListaVuelos lv;
        Grafo g;
        

        ////////////////////////////CREAR NUEVO VUELO 
        string origen;
        string destino;
        string costo;
        string tiempo;
        ////////////////////////////
        public FormMainVuelos(ListaVuelos lv, Grafo g)
        {

            this.g = g;
            this.lv = lv;
            
            InitializeComponent();
            
 
            for (int i=0;i<lv.Count;i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTVIEW DISENIADOR
            {                                                      
                listBoxVuelos.Items.Add(lv[i]);                    //DADO QUE LOS ELEMENTOS ALMACENADOS EN LA LISTA SON DE TIPO OBJECT
            }                                                      //SE TIENE QUE HACER EL METODO Override ToString (en la clase vuelo)
            
        }

        public FormGrafo FormGrafo
        {
            get => default(FormGrafo);
            set
            {
            }
        }

        public FormGraficoDelAvion FormGraficoDelAvion
        {
            get => default(FormGraficoDelAvion);
            set
            {
            }
        }

        public FormPasajeros FormPasajeros
        {
            get => default(FormPasajeros);
            set
            {
            }
        }

        public ListaVuelos getListaVuelos()
        {
            return lv;
        }


        

        private void buttonAsientos_Click(object sender, EventArgs e)
        {
            ClassVuelo vuelo = (ClassVuelo)listBoxVuelos.SelectedItem;
            FormGraficoDelAvion VentanaAvion = new FormGraficoDelAvion(vuelo);
            VentanaAvion.ShowDialog();
            
        }

        private void buttonListaDePasajeros_Click(object sender, EventArgs e)
        {
            FormPasajeros VentanaPasajeros = new FormPasajeros(lv);
            VentanaPasajeros.ShowDialog();
        
        }

        private void listaDeVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormMainVuelos_Load(object sender, EventArgs e)
        {
        }

        private void listBoxVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxVuelos.SelectedIndex > -1 )                  //Si no hay elementos seleccionado el boton no se habilita
            {
                buttonAsientos.Enabled = true;
                buttonAsientos.BackColor = Color.GreenYellow;
                buttonEliminarVuelo.Enabled = true;
                buttonEliminarVuelo.BackColor = Color.IndianRed;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)//Button Filtrar
        {

        }
        private void textBoxBusca_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

        }

        ListaVuelos lvF;
        private void textBoxBusca_TextChanged(object sender, EventArgs e)
        {
            
            
            if (radioButtonRuta.Checked == true)
            {
                
                
                lvF = lv.busquedaCoincidencias(textBoxBusca.Text, 1);
                
            }
            else
            {
                if (radioButtonOrigen.Checked == true)
                {
                   
                    
                    lvF = lv.busquedaCoincidencias(textBoxBusca.Text, 2);
                    
                }
                else
                {


                    lvF = lv.busquedaCoincidencias(textBoxBusca.Text, 3);
                        
                }
                
            }
            
            listBoxVuelos.Items.Clear();
            for (int i = 0; i < lvF.Count; i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL FILTRO
            {
                listBoxVuelos.Items.Add(lvF[i]);
            }
            listBoxVuelos.Refresh();

            buttonAsientos.Enabled = false;
            if (textBoxBusca.Text == " " || textBoxBusca.Text == "")
            {
                textBoxBusca.Text = "";
                RefrescarListaCompleta();
            }
        }

        private void buttonMostrarTodo_Click(object sender, EventArgs e)
        {
            
           
        }

        private void radioButtonRuta_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBusca.Text = "";
            RefrescarListaCompleta();

            buttonAsientos.Enabled = false;
            buttonEliminarVuelo.Enabled = false;
            buttonEliminarVuelo.BackColor = Color.Silver;
            buttonAsientos.BackColor = Color.Silver;

            groupBoxOrdenamiento.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });

        }

        private void radioButtonOrigen_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBusca.Text = "";
            RefrescarListaCompleta();

            buttonAsientos.Enabled = false;
            buttonEliminarVuelo.Enabled = false;
            buttonEliminarVuelo.BackColor = Color.Silver;
            buttonAsientos.BackColor = Color.Silver;

            groupBoxOrdenamiento.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });
        }

        private void radioButtonDestino_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBusca.Text = "";
            RefrescarListaCompleta();

            buttonAsientos.Enabled = false;
            buttonEliminarVuelo.Enabled = false;
            buttonEliminarVuelo.BackColor = Color.Silver;
            buttonAsientos.BackColor = Color.Silver;

            groupBoxOrdenamiento.Controls.OfType<RadioButton>().ToList().ForEach((radiobutton) =>
            {
                radiobutton.AutoCheck = false;
                radiobutton.Checked = false;
                radiobutton.AutoCheck = true;
            });
        }

        private void buttonAgregarV_Click(object sender, EventArgs e)
        {

            origen = textBoxOrigen.Text;
            destino = textBoxDestino.Text;
            tiempo = textBoxTiempo.Text;
            costo = textBoxCosto.Text;

            ClassVuelo vuelo = new ClassVuelo(origen, destino, Int32.Parse(costo), Int32.Parse(tiempo));
            lv.Add(vuelo);




            RefrescarListaCompleta();

            if (radioButtonCOSTO.Checked == true)
            {

                OrdenarCosto();
            }

            if (radioButtonTIEMPO.Checked == true)
            {
                OrdenarTimepo();

            }
            if (radioButtonOrdenamientoOrigen.Checked == true)
            {

                OrdenarOrigen();
            }
            if (radioButtonOrdenmaientoDestino.Checked == true)
            {
                OrdenarDestino();

            }

            




            bool encontrado = false;
            int i = 0;
            while(encontrado == false && i<g.getListaNodos().Count())
            {
                if(g.getListaNodos()[i].getCiudad().getNom() == vuelo.getOrigen())
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            if(encontrado == false)
            {
                FormGrafo grafo = new FormGrafo(g, 1,lv);
                grafo.ShowDialog();

                Nodo n = new Nodo(vuelo.getOrigen());
                
                g.setListaNodos(n);
                n.getCiudad().setX(grafo.getX());
                n.getCiudad().setY(grafo.getY());
                
            }

            encontrado = false;
            i = 0;
            while (encontrado == false && i < g.getListaNodos().Count())
            {
                if (g.getListaNodos()[i].getCiudad().getNom() == vuelo.getDestino())
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            if (encontrado == false)
            {
                FormGrafo grafo = new FormGrafo(g, 2,lv);
                grafo.ShowDialog();

                Nodo n = new Nodo(vuelo.getDestino());
                
                g.setListaNodos(n);
                n.getCiudad().setX(grafo.getX());
                n.getCiudad().setY(grafo.getY());
                
            }


            foreach (Nodo nA in g.getListaNodos())
            {
                

                    if (nA.getCiudad().getNom() == vuelo.getOrigen())
                    {
                        foreach (Nodo nAux2 in g.getListaNodos())
                        {
                            if (nAux2.getCiudad().getNom() == vuelo.getDestino())
                            {

                                Ady a = new Ady(nAux2);
                                a.setPonderacionCosto(Int32.Parse(textBoxCosto.Text));
                                a.setPonderacionTiempo(Int32.Parse(textBoxTiempo.Text));
                                nA.setAdy(a);
                            }
                        }
                    }
 
            }

            textBoxRuta.Text = "";
            textBoxOrigen.Text = "";
            textBoxDestino.Text = "";
            textBoxTiempo.Text = "";
            textBoxCosto.Text = "";
            textBoxPassword.Text = "";




        }

        private void textBoxRuta_TextChanged(object sender, EventArgs e)
        {
            foreach(ClassVuelo v in lv)
            {
                if(textBoxRuta.Text == v.getRuta())
                {
                    MessageBox.Show("NO SE PUEDE DUPLICAR EL NOMBRE DE UN VUELO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxOrigen.Text = "";
                    textBoxDestino.Text = "";
                }
            }
                
            
            

            if (textBoxRuta.Text == " ")
            {
                textBoxRuta.Text = "";
            }
            if (textBoxRuta.Text != "" && textBoxOrigen.Text != "" && textBoxDestino.Text != "" && textBoxTiempo.Text != "" && textBoxCosto.Text != "" )
            {
                
                if (textBoxPassword.Text == "123")
                {
                    buttonAgregarV.Enabled = true;
                    buttonAgregarV.BackColor = Color.IndianRed;
                }
            }
            else
            {
                buttonAgregarV.Enabled = false;
                buttonAgregarV.BackColor = Color.Silver;
            }
        }
        private void textBoxRuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

        }

        private void textBoxOrigen_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOrigen.Text == textBoxDestino.Text &&  textBoxOrigen.Text != "" && textBoxDestino.Text != "")
            {
                MessageBox.Show("EL ORIGEN NO PUEDE SER IGUAL AL DESTINO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxOrigen.Text = "";
                textBoxDestino.Text = "";
            }

            if (textBoxOrigen.Text == " ")
            {
                textBoxOrigen.Text = "";
            }
            if (textBoxOrigen.Text != "" && textBoxOrigen.Text != "B" && textBoxOrigen.Text != "A" && textBoxOrigen.Text != " " && textBoxOrigen.Text != "C" && textBoxOrigen.Text != "D" && textBoxOrigen.Text != "E" && textBoxOrigen.Text != "F" && textBoxOrigen.Text != "G" && textBoxOrigen.Text != "H" && textBoxOrigen.Text != "I" && textBoxOrigen.Text != "J" && textBoxOrigen.Text != "K" && textBoxOrigen.Text != "L" && textBoxOrigen.Text != "M" && textBoxOrigen.Text != "N" && textBoxOrigen.Text != "Ñ" && textBoxOrigen.Text != "O" && textBoxOrigen.Text != "P" && textBoxOrigen.Text != "Q" && textBoxOrigen.Text != "R" && textBoxOrigen.Text != "S" && textBoxOrigen.Text != "T" && textBoxOrigen.Text != "U" && textBoxOrigen.Text != "V" && textBoxOrigen.Text != "W" && textBoxOrigen.Text != "X" && textBoxOrigen.Text != "Y" && textBoxOrigen.Text != "Z" )
            {
                textBoxOrigen.Text = "";
                MessageBox.Show("SOLO SE PERMITE UN CARACTER", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            if (textBoxRuta.Text != "" && textBoxOrigen.Text != "" && textBoxDestino.Text != "" && textBoxTiempo.Text != "" && textBoxCosto.Text != "" )
            {
                
                if (textBoxPassword.Text == "123")
                {
                    buttonAgregarV.Enabled = true;
                    buttonAgregarV.BackColor = Color.IndianRed;
                }
            }
            else
            {
                buttonAgregarV.Enabled = false;
                buttonAgregarV.BackColor = Color.Silver;
            }
            textBoxRuta.Text = "SK1" + textBoxOrigen.Text + textBoxDestino.Text;
        }
        private void textBoxOrigen_KeyPress(object sender, KeyPressEventArgs e)
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



        private void textBoxDestino_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOrigen.Text == textBoxDestino.Text && textBoxOrigen.Text != "" && textBoxDestino.Text != "")
            {
                MessageBox.Show("EL ORIGEN NO PUEDE SER IGUAL AL DESTINO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxOrigen.Text = "";
                textBoxDestino.Text = "";
            }
            if (textBoxDestino.Text == " ")
            {
                textBoxDestino.Text = "";
            }
            if (textBoxDestino.Text != "" && textBoxDestino.Text != "B" && textBoxDestino.Text != "A" && textBoxDestino.Text != " " && textBoxDestino.Text != "C" && textBoxDestino.Text != "D" && textBoxDestino.Text != "E" && textBoxDestino.Text != "F" && textBoxDestino.Text != "G" && textBoxDestino.Text != "H" && textBoxDestino.Text != "I" && textBoxDestino.Text != "J" && textBoxDestino.Text != "K" && textBoxDestino.Text != "L" && textBoxDestino.Text != "M" && textBoxDestino.Text != "N" && textBoxDestino.Text != "Ñ" && textBoxDestino.Text != "O" && textBoxDestino.Text != "P" && textBoxDestino.Text != "Q" && textBoxDestino.Text != "R" && textBoxDestino.Text != "S" && textBoxDestino.Text != "T" && textBoxDestino.Text != "U" && textBoxDestino.Text != "V" && textBoxDestino.Text != "W" && textBoxDestino.Text != "X" && textBoxDestino.Text != "Y" && textBoxDestino.Text != "Z" )
            {
                textBoxDestino.Text = "";
                MessageBox.Show("SOLO SE PERMITE UN CARACTER", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (textBoxRuta.Text != "" && textBoxOrigen.Text != "" && textBoxDestino.Text != "" && textBoxTiempo.Text != "" && textBoxCosto.Text != "")
            {
                
                if (textBoxPassword.Text == "123")
                {
                    buttonAgregarV.Enabled = true;
                    buttonAgregarV.BackColor = Color.IndianRed;
                }
            }
            else
            {
                buttonAgregarV.Enabled = false;
                buttonAgregarV.BackColor = Color.Silver;
            }
            textBoxRuta.Text = "SK1" + textBoxOrigen.Text + textBoxDestino.Text;
        }
        private void textBoxDestino_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxTiempo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTiempo.Text == " ")
            {
                textBoxTiempo.Text = "";
            }
            if (textBoxRuta.Text != "" && textBoxOrigen.Text != "" && textBoxDestino.Text != "" && textBoxTiempo.Text != "" && textBoxCosto.Text != "")
            {
                
                if (textBoxPassword.Text == "123")
                {
                    buttonAgregarV.Enabled = true;
                    buttonAgregarV.BackColor = Color.IndianRed;
                }
            }
            else
            {
                buttonAgregarV.Enabled = false;
                buttonAgregarV.BackColor = Color.Silver;
            }
        }
        private void textBoxTimpo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void textBoxCosto_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCosto.Text == " ")
            {
                textBoxCosto.Text = "";
            }
            if (textBoxRuta.Text != "" && textBoxOrigen.Text != "" && textBoxDestino.Text != "" && textBoxTiempo.Text != "" && textBoxCosto.Text != "" )
            {
                
                if (textBoxPassword.Text == "123")
                {
                    buttonAgregarV.Enabled = true;
                    buttonAgregarV.BackColor = Color.IndianRed;
                }
                
            }
            else
            {
                buttonAgregarV.Enabled = false;
                buttonAgregarV.BackColor = Color.Silver;
            }
        }
        private void textBoxCosto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
            if (textBoxPassword.Text == " ")
            {
                textBoxPassword.Text = "";
            }
            textBoxPassword.PasswordChar = '*';
            if (textBoxRuta.Text != "" && textBoxOrigen.Text != "" && textBoxDestino.Text != "" && textBoxTiempo.Text != "" && textBoxCosto.Text != "")
            {
                
                if (textBoxPassword.Text == "123")
                {
                    buttonAgregarV.Enabled = true;
                    buttonAgregarV.BackColor = Color.IndianRed;
                }
                else
                {
                    buttonAgregarV.Enabled = false;
                    buttonAgregarV.BackColor = Color.Silver;
                }

            }
        }

        private void buttonEliminarVuelo_Click(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == "123")
            {

                ///////////////////////////////////////////ELIMINAR ADYACENCIA SELECCIONADA
                ClassVuelo vueloSeleccionado = (ClassVuelo)listBoxVuelos.SelectedItem;
                List<Nodo> ListaNodoAux = g.getListaNodos();

                //bool EsAdyacente = true;

               // bool encontrado2 = false;
                //int q = 0;
               // bool segundoWhile = false;
               // int s = 0;






                //ELIMINA LA ADYACENCIA 
                bool quebrar = false;
                for (int t = 0; t < ListaNodoAux.Count(); t++)
                {
                    if (ListaNodoAux[t].getCiudad().getNom().ToString() == vueloSeleccionado.getOrigen())
                    {
                        List<Ady> ListaAdyAux = ListaNodoAux[t].getListaAdyacencia();
                        for (int p = 0; p < ListaAdyAux.Count(); p++)
                        {
                            if (ListaAdyAux[p].getNodo().getCiudad().getNom().ToString() == vueloSeleccionado.getDestino())
                            {
                                ListaNodoAux[t].eiminarAdy(ListaAdyAux[p]);

                                quebrar = true;
                                break;
                            }
                        }

                        if (quebrar == true) { break; }

                    }

                }

                
                /*
                //REVISA Y DICE SI  EL ORIGEN SIGUE SIENDO ADYACAENTE A ALGUN OTRO NODO 
                while (encontrado2 == false && q < g.getListaNodos().Count())
                {
                    while (segundoWhile == false && s < g.getListaNodos()[q].getListaAdyacencia().Count())
                    {
                        if (g.getListaNodos()[q].getListaAdyacencia()[s].getNodo().getCiudad().getNom() == vueloSeleccionado.getOrigen())/////////
                        {
                            encontrado2 = true;
                            break;



                        }
                        else
                        {
                            s++;
                        }


                    }
                    q++;
                    if (encontrado2 == true) { break; }

                }
                if (encontrado2 == false) ////////////
                {

                    EsAdyacente = false;


                }
                *///AL BOLVER A PONER ASEGURARME DE PONER EL BOOLENAO EN LAS PARTE DE ELIMINAR NODOS DESPUES DE ==0



               




                //Elimina nodos
                for (int i = 0; i < 2; i++)
                {
                    foreach (Nodo n in g.getListaNodos())
                    {
                        if (n.getListaAdyacencia().Count() == 0 )
                        {
                            bool delete = true;
                            foreach (Nodo n2 in g.getListaNodos())
                            {
                                for (int j = 0; j < n2.getListaAdyacencia().Count(); j++)
                                {
                                    if (n.getCiudad().getNom() == n2.getListaAdyacencia()[j].getNodo().getCiudad().getNom())
                                    {
                                        delete = false;
                                    }
                                }
                               
                            }
                            if (delete == true)
                            {
                                int indexEliNodo = g.getListaNodos().IndexOf(n);
                                g.getListaNodos().RemoveAt(indexEliNodo);
                                break;
                            }
                        }
                        
                    }
                }




                ///////////////////////////////////////////ELIMINAR RUTA DE LA LISTA
                lv.Remove((ClassVuelo)listBoxVuelos.SelectedItem);
                RefrescarListaCompleta();

                buttonAsientos.Enabled = false;
                buttonEliminarVuelo.Enabled = false;
                buttonEliminarVuelo.BackColor = Color.Silver;
                buttonAsientos.BackColor = Color.Silver;
                textBoxPassword.Text = "";





            }
            else
            {
                MessageBox.Show("SIN PERMISO DE ADMINISTRADOR. 'INGRESA LA CONTRASEÑA'", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            
        }

        private void RefrescarListaCompleta()
        {
            listBoxVuelos.Items.Clear();
            for (int i = 0; i < lv.Count; i++)
            {
                listBoxVuelos.Items.Add(lv[i]);
            }
            listBoxVuelos.Refresh();


        }

        private void buttonGrafo_Click(object sender, EventArgs e)
        {
            FormGrafo grafo = new FormGrafo(g,0,lv);
            grafo.ShowDialog();
            RefrescarListaCompleta();

        }

        private void radioButtonCOSTO_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonCOSTO.Checked == true)
            {

                OrdenarCosto();
            }
           

        }

        private void radioButtonTIEMPO_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTIEMPO.Checked == true)
            {
                OrdenarTimepo();

            }

        }

        private void radioButtonOrdenamientoOrigen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrdenamientoOrigen.Checked == true)
            {

                OrdenarOrigen();
            }

        }

        private void radioButtonOrdenmaientoDestino_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOrdenmaientoDestino.Checked == true)
            {
                OrdenarDestino();

            }
        }


        private void OrdenarCosto()
        {
            ListaVuelos lv0 = new ListaVuelos();

            if (lv.Count() == listBoxVuelos.Items.Count) //ESTO REVISA SI ORDENARA UN LISTA COMPLETA O LA FLTRADA ANTERIORMENTE
            {
                lv0 = lv.quicksortCosto(lv, 0, lv.Count() - 1);

            }
            else
            {
                lv0 = lvF.quicksortCosto(lvF, 0, lvF.Count() - 1);

            }

            listBoxVuelos.Items.Clear();

            for (int i = 0; i < lv0.Count(); i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL ORDENAMIENTO
            {
                listBoxVuelos.Items.Add(lv0[i]);
            }
        }

        private void OrdenarTimepo()
        {
            ListaVuelos lv0 = new ListaVuelos();

            if (lv.Count() == listBoxVuelos.Items.Count) //ESTO REVISA SI ORDENARA UN LISTA COMPLETA O LA FLTRADA ANTERIORMENTE
            {
                lv0 = lv.quicksortTiempo(lv, 0, lv.Count() - 1);

            }
            else
            {
                lv0 = lvF.quicksortTiempo(lvF, 0, lvF.Count() - 1);

            }

            
            

            listBoxVuelos.Items.Clear();

            for (int i = 0; i < lv0.Count(); i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL ORDENAMIENTO
            {
                listBoxVuelos.Items.Add(lv0[i]);
            }

        }
        private void OrdenarOrigen()
        {
            ListaVuelos lv0 = new ListaVuelos();

            if (lv.Count() == listBoxVuelos.Items.Count) //ESTO REVISA SI ORDENARA UN LISTA COMPLETA O LA FLTRADA ANTERIORMENTE
            {
                lv0 = lv.quicksortOrigen(lv, 0, lv.Count() - 1);

            }
            else
            {
                lv0 = lvF.quicksortOrigen(lvF, 0, lvF.Count() - 1);

            }

            listBoxVuelos.Items.Clear();

            for (int i = 0; i < lv0.Count(); i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL ORDENAMIENTO
            {
                listBoxVuelos.Items.Add(lv0[i]);
            }
        }
        private void OrdenarDestino()
        {
            ListaVuelos lv0 = new ListaVuelos();

            if (lv.Count() == listBoxVuelos.Items.Count) //ESTO REVISA SI ORDENARA UN LISTA COMPLETA O LA FLTRADA ANTERIORMENTE
            {
                lv0 = lv.quicksortDestino(lv, 0, lv.Count() - 1);

            }
            else
            {
                lv0 = lvF.quicksortDestino(lvF, 0, lvF.Count() - 1);
            
            }

            listBoxVuelos.Items.Clear();

            for (int i = 0; i < lv0.Count(); i++)                        //SE AGREGAN LOS ELEMENTOS A LAS LISTA CON EL ORDENAMIENTO
            {
                listBoxVuelos.Items.Add(lv0[i]);
            }
        }

       


    }
}
