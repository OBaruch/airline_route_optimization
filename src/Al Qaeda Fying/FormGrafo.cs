using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Al_Qaeda_Fying
{
    public partial class FormGrafo : Form
    {
        int u1;
        int u2;

        Nodo actual_l;

        Grafo g;
        ListaVuelos lv;
        int bandera =0 ;


        int x;
        int y;

        int fontSize = 8;

        string textbox = "MAPA";

        public FormGrafo(Grafo g,int bandera,ListaVuelos lv)
        {
            this.g = g;
            this.lv = lv;

            this.bandera = bandera;


            InitializeComponent();


            
            DibujarAdyacencias(1,g);
            DibujarNodos(1,g);


            RefrescarListaCiudades();




            if (bandera == 1)
            {
                textbox = "AGREGA CIUDAD ORIGEN"; 
            }
            if (bandera == 2)
            {
                textbox = "AGREGA CIUDAD DESTINO";
            }
            textBoxCaso.Text = textbox;

            

        }



        public void DibujarNodos(int opc,Grafo g)
        {
            
            Pen lapiz = new Pen(Color.Red);
            SolidBrush mySolidBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Arial", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Icon newIcon = new Icon("pin.ico");
            Icon newIcon2 = new Icon("marca.ico");

            if (opc ==1 )//OPCION GRAFO NORMAL 
            {
                foreach (Nodo nAux in g.getListaNodos())
                {

                    panel1.CreateGraphics().DrawIcon(newIcon, nAux.getCiudad().getX() - 10, nAux.getCiudad().getY() - 30);
                    panel1.CreateGraphics().DrawString(nAux.getCiudad().getNom(), drawFont, drawBrush, nAux.getCiudad().getX(), nAux.getCiudad().getY() + 20);


                }
            }

            if(opc==2)//DIBUJAR ARM 
            {

                foreach (Nodo nAux in g.getListaNodos())
                {

                    panel1.CreateGraphics().DrawIcon(newIcon2, nAux.getCiudad().getX() - 10, nAux.getCiudad().getY() - 30);
                    panel1.CreateGraphics().DrawString(nAux.getCiudad().getNom(), drawFont, drawBrush, nAux.getCiudad().getX(), nAux.getCiudad().getY() + 20);


                }

            }
            
        }

        public void DibujarAdyacencias(int opc,Grafo g)
        {
            Pen lapiz = new Pen(Color.Black);
            Pen lapiz2 = new Pen(Color.Red,7);
            Pen lapiz3= new Pen(Color.FromArgb(100, 255, 0, 0), 8);

            Font drawFont = new Font("Arial", fontSize);
            SolidBrush drawBrush = new SolidBrush(Color.DarkRed);

            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            lapiz.CustomEndCap = bigArrow;

            
            if(opc == 1)//GRAFO NORMAL 
            {
                foreach (Nodo nAux in g.getListaNodos())
                {
                    foreach (Ady a in nAux.getListaAdyacencia())
                    {
                        int xM, yM;

                        xM = ((nAux.getCiudad().getX() + a.getNodo().getCiudad().getX()) / 2);
                        yM = ((nAux.getCiudad().getY() + a.getNodo().getCiudad().getY()) / 2);

                        panel1.CreateGraphics().DrawLine(lapiz, nAux.getCiudad().getX() + 15, nAux.getCiudad().getY() + 15, a.getNodo().getCiudad().getX() + 15, a.getNodo().getCiudad().getY() + 15);

                        panel1.CreateGraphics().DrawString(nAux.getCiudad().getNom() + " -> " + a.getNodo().getCiudad().getNom() + " Costo: $" + a.getPonderacionCosto().ToString(), drawFont, drawBrush, xM - 7, yM - 5);
                        panel1.CreateGraphics().DrawString(" Timepo:" + a.getPonderacionTiempo().ToString() + " Min", drawFont, drawBrush, xM - 7, yM + 10);


                    }

                }

            }
            if (opc == 2)//DIBUJAR ARM 
            {
                foreach (Nodo nAux in g.getListaNodos())
                {
                    foreach (Ady a in nAux.getListaAdyacencia())
                    {
                        panel1.CreateGraphics().DrawLine(lapiz3, nAux.getCiudad().getX() + 15, nAux.getCiudad().getY() + 15, a.getNodo().getCiudad().getX() + 15, a.getNodo().getCiudad().getY() + 15);
                    }

                }
            }




        }

        private void panel1_Click(object sender, EventArgs e){}
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (bandera == 1 || bandera == 2)
            {

                x = e.X;
                y = e.Y;
                MessageBox.Show("Punto almacenado");
                Thread.Sleep(1000);
                this.Close();

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DibujarAdyacencias(1,g);
            DibujarNodos(1,g);
            
        }



        
        public int getX()
        {
            return x-13;
        }
        public int getY()
        {
            return y-13;
        }

        private void listBoxSeleccionaCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSeleccionaCiudad.SelectedIndex > -1)                  //Si no hay elementos seleccionado el boton no se habilita
            {
                buttonBorrarCiudad.Enabled = true;
                buttonTiemposPrim.Enabled = true;
                button1.Enabled = true;
                
            }

                if (bandera == 0)
            {
                buttonBorrarCiudad.Enabled = true;
            }
            if (bandera == 1 || bandera == 2)
            {
                MessageBox.Show("CREANDO CIUDAD 'ACCESO DENEGADO'", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }




        }
        public void RefrescarListaCiudades()
        {
            listBoxSeleccionaCiudad.Items.Clear();
            foreach (Nodo n in g.getListaNodos())
            {
                listBoxSeleccionaCiudad.Items.Add(n.getCiudad().getNom());
            }
        }

        private void buttonBorrarCiudad_Click(object sender, EventArgs e)
        {
            listBoxRutasOptimas.Items.Clear();
            listBoxTOTAL.Items.Clear();
            listBoxCostos.Items.Clear();
            buttonTiemposPrim.Enabled = false;
            //listBoxSeleccionaCiudad.ClearSelected();

            DialogResult dialogResult = MessageBox.Show("ESTA SEGURO DE HACER ESTOS CAMBIOS, AL ACEPTAR SE MODIFICARAN DATOS QUE NO SE PUEDEN RECUPERAR", "ALERTA", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                List<ClassVuelo> lvSec = new List<ClassVuelo>();

                string CiudadeSeleccionada = (string)listBoxSeleccionaCiudad.SelectedItem;



                //Crea una lista secundaria de vuelos que se eliminaran y elimina de la lista oficial esos vuelos
                int num = lv.Count();
                int x = 0;
                while (x < num)
                {
                    if (lv[x].getOrigen() != CiudadeSeleccionada)
                    {

                        x++;
                    }
                    else
                    {
                        lvSec.Add(lv[x]);

                        lv.Remove(lv[x]);
                        num--;
                    }

                }





                int num2 = lv.Count();
                int r = 0;
                while (r < num2)
                {
                    if (lv[r].getDestino() != CiudadeSeleccionada)
                    {

                        r++;
                    }
                    else
                    {
                        lvSec.Add(lv[r]);

                        lv.Remove(lv[r]);
                        num2--;
                    }
                }










                ///////////////////////////////////////////ELIMINAR ADYACENCIA SELECCIONADA

                List<Nodo> ListaNodoAux = g.getListaNodos();



                foreach (ClassVuelo vAux in lvSec)
                {
                    //ELIMINA LA ADYACENCIA 
                    bool quebrar = false;
                    for (int t = 0; t < ListaNodoAux.Count(); t++)
                    {
                        if (ListaNodoAux[t].getCiudad().getNom().ToString() == vAux.getOrigen())
                        {
                            List<Ady> ListaAdyAux = ListaNodoAux[t].getListaAdyacencia();
                            for (int p = 0; p < ListaAdyAux.Count(); p++)
                            {
                                if (ListaAdyAux[p].getNodo().getCiudad().getNom().ToString() == vAux.getDestino())
                                {
                                    ListaNodoAux[t].eiminarAdy(ListaAdyAux[p]);

                                    quebrar = true;
                                    break;
                                }
                            }

                            if (quebrar == true) { break; }

                        }

                    }





                    //Elimina nodos
                    for (int i = 0; i < 2; i++)
                    {
                        foreach (Nodo n in g.getListaNodos())
                        {
                            if (n.getListaAdyacencia().Count() == 0)
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
                }




                panel1.Refresh();
                RefrescarListaCiudades();

                buttonBorrarCiudad.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                RefrescarListaCiudades();

                buttonBorrarCiudad.Enabled = false;
            }

           


        }

        private void buttonCostosKruskal_Click(object sender, EventArgs e)
        {
            
            panel1.Refresh();
            listBoxRutasOptimas.Items.Clear();
            listBoxTOTAL.Items.Clear();
            listBoxCostos.Items.Clear();
            buttonTiemposPrim.Enabled = false;
            listBoxSeleccionaCiudad.ClearSelected();

            ListaVuelos listaKruskal = new ListaVuelos();

            //Crear un grafo igual al anterior 
            Grafo grafoDirigido = new Grafo(lv);
            grafoDirigido = g;

            //Conbertir el grafo en NO dirigido (NO NESESARIO)

            //Crear lista de Prioridad(Aristas)
            ListaAristas candidatos = new ListaAristas();
            

            foreach(Nodo n in grafoDirigido.getListaNodos())
            {
                foreach(Ady nA in n.getListaAdyacencia())
                {
                    Arista arista = new Arista(n, nA.getNodo(), nA.getPonderacionCosto(), nA.getPonderacionTiempo());
                    candidatos.Add(arista);

                }
            }


            //Ordenar candidatos de menor a mayor
            ListaAristas CandidatosOrdenados = new ListaAristas();
            CandidatosOrdenados= candidatos.quicksortCosto(candidatos,0,candidatos.Count()-1);



            //CREAR COMPONENTES CONEXSOS
            List<List<string>> CC = new List<List<string>>();
            
           for (int w =0 ; w < g.getListaNodos().Count() ;w++)
            {
                List<string> P = new List<string>();
                CC.Add(P);

                CC[w].Add(g.getListaNodos()[w].getCiudad().getNom());
            }






            //ALGROTIMO KRUSKAL

            for(int z = 0; z< CandidatosOrdenados.Count(); z++)
            {
                Arista V = CandidatosOrdenados[z];
                
                while (CC.Count() > 1)
                {
                    
                    //BUSCA EN QUE CADENA SE ENCUENTRA EL ORIGEN
                    int i;
                    int j;

                    for (i = 0; i < CC.Count(); i++)
                    {
                        for (j = 0; j < CC[i].Count(); j++)
                        {
                            if (V.getNodoOrigen().getCiudad().getNom() == CC[i][j])
                            {
                                u1 = i;
                                goto End1;

                            }
                        }
                    }End1:

                    //BUSCA EN QUE CADENA SE ENCUENTRA EL DESTINO
                    int q=0;
                    int j2;

                    while(q < CC.Count())
                    {
                        for (j2 = 0; j2 < CC[q].Count(); j2++)
                        {
                            if (V.getNodoDestinon().getCiudad().getNom() == CC[q][j2])
                            {
                                u2 = q;

                                goto End;

                            }
                        }
                        q++;
                    }
                    End:





                    if (u1 != u2)
                    {
                        for (int o = 0; o < CC[u2].Count(); o++)
                        {

                            CC[u1].Add(CC[u2][o]);

                        }

                        CC.Remove(CC[u2]);

                        ClassVuelo vue = new ClassVuelo(V.getNodoOrigen().getCiudad().getNom(), V.getNodoDestinon().getCiudad().getNom(), V.getPonderacionCosto(), V.getPonderacionTimepo());
                        listaKruskal.Add(vue);
                        
                    }



                    break;
                }
                


            }
            Grafo ARM = new Grafo(listaKruskal);
            
            //ESTALECERLE LAS CORDENADAS AL ARM
            for(int a = 0; a<g.getListaNodos().Count();a++)
            {
                for (int k = 0; k < ARM.getListaNodos().Count(); k++)
                {
                    if (ARM.getListaNodos()[k].getCiudad().getNom() == g.getListaNodos()[a].getCiudad().getNom())
                    {
                        ARM.getListaNodos()[k].getCiudad().setX(g.getListaNodos()[a].getCiudad().getX());
                        ARM.getListaNodos()[k].getCiudad().setY(g.getListaNodos()[a].getCiudad().getY());
                        
                    }

                }
            }


            int suma = 0;
            foreach(ClassVuelo vs in listaKruskal)
            {
                listBoxRutasOptimas.Items.Add(vs.getRuta());
            }
            foreach (ClassVuelo vs in listaKruskal)
            {
                listBoxCostos.Items.Add( "$ " + vs.getCosto());
                suma += vs.getCosto();
            }

            listBoxTOTAL.Items.Add("$ "+suma);
           


            DibujarAdyacencias(2, ARM);
           // DibujarNodos(2, ARM);

            DibujarAdyacencias(1, g);
            DibujarNodos(1, g);

            


        }

        private void buttonTiemposPrim_Click(object sender, EventArgs e)
        {
           
            panel1.Refresh();
            listBoxRutasOptimas.Items.Clear();
            listBoxTOTAL.Items.Clear();
            listBoxCostos.Items.Clear();
            ////////////////////////////
            //Comprobar que el grafo sea conexo


            //Crear un grafo igual al oficial PARA TRABJAR CON EL Y PODERLO MODIFICAR
            Grafo grafoDirigidoP = new Grafo(lv);


            ListaAristas ARM = new ListaAristas(); //ARM 
            ListaVuelos listaPrim = new ListaVuelos(); //Lista de vuelos igual  ARM para grafo
            ListaAristas candidatos = new ListaAristas();

            foreach(Nodo n in grafoDirigidoP.getListaNodos())
            {
                foreach(Ady a in n.getListaAdyacencia())
                {
                    Arista arist = new Arista(n,a.getNodo(),a.getPonderacionCosto(),a.getPonderacionTiempo());
                    candidatos.Add(arist);
                }
            }
            candidatos.quicksortTiempo(candidatos, 0, candidatos.Count - 1);

            //INICILAIZA LISTA DE NODOS 
            List<Nodo> S = new List<Nodo>();

            ////Seleccionar un origen y agregarlo s
            
            foreach (Nodo n in grafoDirigidoP.getListaNodos())
            {
                if (n.getCiudad().getNom() == (string)listBoxSeleccionaCiudad.SelectedItem)
                {
                    S.Add(n);
                    break;
                }
            }

            

            //Algoritmo
            while (ARM.Count < grafoDirigidoP.getListaNodos().Count()-1)
            {
                Arista ar = candidatos.seleccionFactibel(candidatos,S);
                
                ARM.Add(ar);
                if(S.Contains(ar.getNodoOrigen()))
                {
                    S.Add(ar.getNodoDestinon());
                }
                else 
                {
                    S.Add(ar.getNodoOrigen());
                }

            }

            //llenar lista de vuelos priam en base a las lista optenida de aristas del ARM para construir grafo(ARM)

            foreach(Arista a in ARM)
            {
                ClassVuelo v = new ClassVuelo(a.getNodoOrigen().getCiudad().getNom(), a.getNodoDestinon().getCiudad().getNom(), a.getPonderacionCosto(), a.getPonderacionTimepo());
                listaPrim.Add(v);
            }

            Grafo ARMG = new Grafo(listaPrim);

            //establecer coordeadas
            foreach (Nodo n in ARMG.getListaNodos())
            {
                foreach (Nodo n2 in g.getListaNodos())
                {
                    if (n.getCiudad().getNom() == n2.getCiudad().getNom())
                    {
                        n.getCiudad().setX(n2.getCiudad().getX());
                        n.getCiudad().setY(n2.getCiudad().getY());

                    }
                }
            }

            //LLENAR LISTAS DE TIEMPO Y TOTAL
            int suma = 0;
            foreach (ClassVuelo vs in listaPrim)
            {
                listBoxRutasOptimas.Items.Add(vs.getRuta());
                
            }
            foreach (ClassVuelo vs in listaPrim)
            {
                listBoxCostos.Items.Add(vs.getTiempo()+" Min");
                suma += vs.getTiempo();
            }

            listBoxTOTAL.Items.Add(suma + " Min");


            //DIBUJAR ADYACENCIAS Y NODOS

            DibujarAdyacencias(2, ARMG);
            // DibujarNodos(2, ARM);

            DibujarAdyacencias(1, g);
            DibujarNodos(1, g);


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            /////////////////////////////////
            if(radioButtonDijkstraCosto.Checked == true)
            {
                panel1.Refresh();
                listBoxRutasOptimas.Items.Clear();
                listBoxTOTAL.Items.Clear();
                listBoxCostos.Items.Clear();
                ///////////////////////////////////
                string inicio = (string)listBoxSeleccionaCiudad.SelectedItem;
                char ini = inicio[0];

                DijkstraCosto dc = new DijkstraCosto(g, ini, true);
                foreach (string s in dc.getvD())
                {
                    listBoxRutasOptimas.Items.Add(s);
                }


                

            }
            if (radioButtonDijkstraTiempo.Checked == true)
            {
                panel1.Refresh();
                listBoxRutasOptimas.Items.Clear();
                listBoxTOTAL.Items.Clear();
                listBoxCostos.Items.Clear();
                ///////////////////////////////////////
                string inicio = (string)listBoxSeleccionaCiudad.SelectedItem;
                char ini = inicio[0];

                DijkstraTiempo dt = new DijkstraTiempo(g, ini, true);
                foreach (string s in dt.getvD())
                {
                    listBoxRutasOptimas.Items.Add(s);
                }
            }





        }
    }
}


