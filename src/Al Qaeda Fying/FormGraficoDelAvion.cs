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
    public partial class FormGraficoDelAvion : Form
    {
        ClassVuelo vuelo;
        int aSeleccionado;
        
        
        public FormGraficoDelAvion(ClassVuelo vuelo)
        {
            aSeleccionado = 0;
            this.vuelo = vuelo;
            
            InitializeComponent();
            InicializaAsiento();
            labelVuelo.Text += vuelo.getRuta();


        }

        public FormRegistoPasajero FormRegistoPasajero
        {
            get => default(FormRegistoPasajero);
            set
            {
            }
        }

        private void  InicializaAsiento()
        {
            int nAsi;
            for(int i=0;i<vuelo.getListaPasajeros().Count;i++)
            {
                nAsi = vuelo.getListaPasajeros()[i].getAsiento();
                if(nAsi == 1){buttonAsiento1.BackColor = Color.Maroon; buttonAsiento1.Enabled = false;}
                if (nAsi == 2) { buttonAsiento2.BackColor = Color.Maroon; buttonAsiento2.Enabled = false; }
                if (nAsi == 3) { buttonAsiento3.BackColor = Color.Maroon; buttonAsiento3.Enabled = false; }
                if (nAsi == 4) { buttonAsiento4.BackColor = Color.Maroon; buttonAsiento4.Enabled = false; }
                if (nAsi == 5) { buttonAsiento5.BackColor = Color.Maroon; buttonAsiento5.Enabled = false; }
                if (nAsi == 6) { buttonAsiento6.BackColor = Color.Maroon; buttonAsiento6.Enabled = false; }
                if (nAsi == 7) { buttonAsiento7.BackColor = Color.Maroon; buttonAsiento7.Enabled = false; }
                if (nAsi == 8) { buttonAsiento8.BackColor = Color.Maroon; buttonAsiento8.Enabled = false; }
                if (nAsi == 9) { buttonAsiento9.BackColor = Color.Maroon; buttonAsiento9.Enabled = false; }
                if (nAsi == 10) { buttonAsiento10.BackColor = Color.Maroon; buttonAsiento10.Enabled = false; }
                if (nAsi == 11) { buttonAsiento11.BackColor = Color.Maroon; buttonAsiento11.Enabled = false; }
                if (nAsi == 12) { buttonAsiento12.BackColor = Color.Maroon; buttonAsiento12.Enabled = false; }
                if (nAsi == 13) { buttonAsiento13.BackColor = Color.Maroon; buttonAsiento13.Enabled = false; }
                if (nAsi == 14) { buttonAsiento14.BackColor = Color.Maroon; buttonAsiento14.Enabled = false; }
                if (nAsi == 15) { buttonAsiento15.BackColor = Color.Maroon; buttonAsiento15.Enabled = false; }
                if (nAsi == 16) { buttonAsiento16.BackColor = Color.Maroon; buttonAsiento16.Enabled = false; }
                if (nAsi == 17) { buttonAsiento17.BackColor = Color.Maroon; buttonAsiento17.Enabled = false; }
                if (nAsi == 18) { buttonAsiento18.BackColor = Color.Maroon; buttonAsiento18.Enabled = false; }
                if (nAsi == 19) { buttonAsiento19.BackColor = Color.Maroon; buttonAsiento19.Enabled = false; }
                if (nAsi == 20) { buttonAsiento20.BackColor = Color.Maroon; buttonAsiento20.Enabled = false; }
                if (nAsi == 21) { buttonAsiento21.BackColor = Color.Maroon; buttonAsiento21.Enabled = false; }
                if (nAsi == 22) { buttonAsiento22.BackColor = Color.Maroon; buttonAsiento23.Enabled = false; }
                if (nAsi == 23) { buttonAsiento23.BackColor = Color.Maroon; buttonAsiento23.Enabled = false; }
                if (nAsi == 24) { buttonAsiento24.BackColor = Color.Maroon; buttonAsiento24.Enabled = false; }
                if (nAsi == 25) { buttonAsiento25.BackColor = Color.Maroon; buttonAsiento25.Enabled = false; }
                if (nAsi == 26) { buttonAsiento26.BackColor = Color.Maroon; buttonAsiento26.Enabled = false; }
                if (nAsi == 27) { buttonAsiento27.BackColor = Color.Maroon; buttonAsiento27.Enabled = false; }
                if (nAsi == 28) { buttonAsiento28.BackColor = Color.Maroon; buttonAsiento28.Enabled = false; }
                if (nAsi == 29) { buttonAsiento29.BackColor = Color.Maroon; buttonAsiento29.Enabled = false; }
                if (nAsi == 30) { buttonAsiento30.BackColor = Color.Maroon; buttonAsiento30.Enabled = false; }



            }
            
        }
        


        private void button7_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonReservarAsiento_Click(object sender, EventArgs e)
        {
           
            FormRegistoPasajero pas = new FormRegistoPasajero(vuelo,aSeleccionado);
            pas.ShowDialog();

            
            
            if ( pas.GetBandera() == true)
            {
                this.Close();
            }
            

        }
        

        private void buttonAtrasAVuelos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGraficoDelAvion_Load(object sender, EventArgs e)
        {
            ///////////////////////      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAsiento1_Click(object sender, EventArgs e)           //TODOS LOS BOTONES RESPONDEN A ESTE EVENTO
        {
            Button boton;
            boton = (Button)sender;
            aSeleccionado = Int32.Parse(boton.Text);
            if (buttonAsiento1.Capture != false){this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento2.Capture != false){this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento3.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento4.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento5.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento6.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento7.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento8.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento9.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento10.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento11.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento12.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento13.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento14.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento15.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento16.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento17.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento18.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento19.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento20.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento21.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento21.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento22.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento23.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento24.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento25.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento26.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento27.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento28.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento29.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            if (buttonAsiento30.Capture != false) { this.buttonReservarAsiento.Enabled = true; }
            
            


        }

        private void buttonAsiento2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAsiento3_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAsiento4_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAsiento5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento6_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento7_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento8_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento10_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento11_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento12_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento13_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento14_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento16_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento17_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento18_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento19_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento20_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento21_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento22_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento23_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento24_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento25_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento26_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento27_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento28_Click(object sender, EventArgs e)
        {

        }

        private void buttonAsiento29_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
