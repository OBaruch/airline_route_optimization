namespace Al_Qaeda_Fying
{
    partial class FormGrafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrafo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCaso = new System.Windows.Forms.TextBox();
            this.listBoxSeleccionaCiudad = new System.Windows.Forms.ListBox();
            this.labelBorrarCiudad = new System.Windows.Forms.Label();
            this.buttonBorrarCiudad = new System.Windows.Forms.Button();
            this.groupBoxInterconectividad = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTOTAL = new System.Windows.Forms.ListBox();
            this.labelInterconectividadminaTIEMEPOS = new System.Windows.Forms.Label();
            this.labelTOTAL = new System.Windows.Forms.Label();
            this.buttonTiemposPrim = new System.Windows.Forms.Button();
            this.listBoxCostos = new System.Windows.Forms.ListBox();
            this.listBoxRutasOptimas = new System.Windows.Forms.ListBox();
            this.labelInterconectividadminimaporcostos = new System.Windows.Forms.Label();
            this.buttonCostosKruskal = new System.Windows.Forms.Button();
            this.radioButtonDijkstraCosto = new System.Windows.Forms.RadioButton();
            this.radioButtonDijkstraTiempo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBoxInterconectividad.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.textBoxCaso);
            this.panel1.Location = new System.Drawing.Point(4, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 741);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // textBoxCaso
            // 
            this.textBoxCaso.Enabled = false;
            this.textBoxCaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaso.Location = new System.Drawing.Point(24, 22);
            this.textBoxCaso.Name = "textBoxCaso";
            this.textBoxCaso.Size = new System.Drawing.Size(444, 35);
            this.textBoxCaso.TabIndex = 0;
            // 
            // listBoxSeleccionaCiudad
            // 
            this.listBoxSeleccionaCiudad.FormattingEnabled = true;
            this.listBoxSeleccionaCiudad.Location = new System.Drawing.Point(5, 53);
            this.listBoxSeleccionaCiudad.Name = "listBoxSeleccionaCiudad";
            this.listBoxSeleccionaCiudad.Size = new System.Drawing.Size(165, 121);
            this.listBoxSeleccionaCiudad.TabIndex = 1;
            this.listBoxSeleccionaCiudad.SelectedIndexChanged += new System.EventHandler(this.listBoxSeleccionaCiudad_SelectedIndexChanged);
            // 
            // labelBorrarCiudad
            // 
            this.labelBorrarCiudad.AutoSize = true;
            this.labelBorrarCiudad.Location = new System.Drawing.Point(6, 37);
            this.labelBorrarCiudad.Name = "labelBorrarCiudad";
            this.labelBorrarCiudad.Size = new System.Drawing.Size(120, 13);
            this.labelBorrarCiudad.TabIndex = 2;
            this.labelBorrarCiudad.Text = "Selecciona una Ciudad ";
            // 
            // buttonBorrarCiudad
            // 
            this.buttonBorrarCiudad.Enabled = false;
            this.buttonBorrarCiudad.Location = new System.Drawing.Point(6, 180);
            this.buttonBorrarCiudad.Name = "buttonBorrarCiudad";
            this.buttonBorrarCiudad.Size = new System.Drawing.Size(168, 19);
            this.buttonBorrarCiudad.TabIndex = 3;
            this.buttonBorrarCiudad.Text = "Eliminar";
            this.buttonBorrarCiudad.UseVisualStyleBackColor = true;
            this.buttonBorrarCiudad.Click += new System.EventHandler(this.buttonBorrarCiudad_Click);
            // 
            // groupBoxInterconectividad
            // 
            this.groupBoxInterconectividad.Controls.Add(this.radioButtonDijkstraTiempo);
            this.groupBoxInterconectividad.Controls.Add(this.radioButtonDijkstraCosto);
            this.groupBoxInterconectividad.Controls.Add(this.button1);
            this.groupBoxInterconectividad.Controls.Add(this.labelBorrarCiudad);
            this.groupBoxInterconectividad.Controls.Add(this.buttonBorrarCiudad);
            this.groupBoxInterconectividad.Controls.Add(this.label1);
            this.groupBoxInterconectividad.Controls.Add(this.listBoxSeleccionaCiudad);
            this.groupBoxInterconectividad.Controls.Add(this.listBoxTOTAL);
            this.groupBoxInterconectividad.Controls.Add(this.labelInterconectividadminaTIEMEPOS);
            this.groupBoxInterconectividad.Controls.Add(this.labelTOTAL);
            this.groupBoxInterconectividad.Controls.Add(this.buttonTiemposPrim);
            this.groupBoxInterconectividad.Controls.Add(this.listBoxCostos);
            this.groupBoxInterconectividad.Controls.Add(this.listBoxRutasOptimas);
            this.groupBoxInterconectividad.Controls.Add(this.labelInterconectividadminimaporcostos);
            this.groupBoxInterconectividad.Controls.Add(this.buttonCostosKruskal);
            this.groupBoxInterconectividad.Location = new System.Drawing.Point(1394, 40);
            this.groupBoxInterconectividad.Name = "groupBoxInterconectividad";
            this.groupBoxInterconectividad.Size = new System.Drawing.Size(190, 620);
            this.groupBoxInterconectividad.TabIndex = 4;
            this.groupBoxInterconectividad.TabStop = false;
            this.groupBoxInterconectividad.Text = "Interconectividad";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(6, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ruta Optima(Dijkstra)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecciona una ciudad  Origen";
            // 
            // listBoxTOTAL
            // 
            this.listBoxTOTAL.Enabled = false;
            this.listBoxTOTAL.FormattingEnabled = true;
            this.listBoxTOTAL.Location = new System.Drawing.Point(109, 597);
            this.listBoxTOTAL.Name = "listBoxTOTAL";
            this.listBoxTOTAL.Size = new System.Drawing.Size(65, 17);
            this.listBoxTOTAL.TabIndex = 9;
            // 
            // labelInterconectividadminaTIEMEPOS
            // 
            this.labelInterconectividadminaTIEMEPOS.AutoSize = true;
            this.labelInterconectividadminaTIEMEPOS.Location = new System.Drawing.Point(2, 397);
            this.labelInterconectividadminaTIEMEPOS.Name = "labelInterconectividadminaTIEMEPOS";
            this.labelInterconectividadminaTIEMEPOS.Size = new System.Drawing.Size(126, 13);
            this.labelInterconectividadminaTIEMEPOS.TabIndex = 3;
            this.labelInterconectividadminaTIEMEPOS.Text = "TODO POR EL MENOR:";
            // 
            // labelTOTAL
            // 
            this.labelTOTAL.AutoSize = true;
            this.labelTOTAL.Location = new System.Drawing.Point(72, 602);
            this.labelTOTAL.Name = "labelTOTAL";
            this.labelTOTAL.Size = new System.Drawing.Size(34, 13);
            this.labelTOTAL.TabIndex = 8;
            this.labelTOTAL.Text = "Total:";
            // 
            // buttonTiemposPrim
            // 
            this.buttonTiemposPrim.Enabled = false;
            this.buttonTiemposPrim.Location = new System.Drawing.Point(5, 426);
            this.buttonTiemposPrim.Name = "buttonTiemposPrim";
            this.buttonTiemposPrim.Size = new System.Drawing.Size(173, 22);
            this.buttonTiemposPrim.TabIndex = 2;
            this.buttonTiemposPrim.Text = "Tiempo (PRIM)";
            this.buttonTiemposPrim.UseVisualStyleBackColor = true;
            this.buttonTiemposPrim.Click += new System.EventHandler(this.buttonTiemposPrim_Click);
            // 
            // listBoxCostos
            // 
            this.listBoxCostos.Enabled = false;
            this.listBoxCostos.FormattingEnabled = true;
            this.listBoxCostos.Location = new System.Drawing.Point(109, 470);
            this.listBoxCostos.Name = "listBoxCostos";
            this.listBoxCostos.Size = new System.Drawing.Size(65, 121);
            this.listBoxCostos.TabIndex = 7;
            // 
            // listBoxRutasOptimas
            // 
            this.listBoxRutasOptimas.Enabled = false;
            this.listBoxRutasOptimas.FormattingEnabled = true;
            this.listBoxRutasOptimas.Location = new System.Drawing.Point(6, 470);
            this.listBoxRutasOptimas.Name = "listBoxRutasOptimas";
            this.listBoxRutasOptimas.Size = new System.Drawing.Size(97, 121);
            this.listBoxRutasOptimas.TabIndex = 5;
            // 
            // labelInterconectividadminimaporcostos
            // 
            this.labelInterconectividadminimaporcostos.AutoSize = true;
            this.labelInterconectividadminimaporcostos.Location = new System.Drawing.Point(-1, 330);
            this.labelInterconectividadminimaporcostos.Name = "labelInterconectividadminimaporcostos";
            this.labelInterconectividadminimaporcostos.Size = new System.Drawing.Size(126, 13);
            this.labelInterconectividadminimaporcostos.TabIndex = 1;
            this.labelInterconectividadminimaporcostos.Text = "TODO POR EL MENOR:";
            // 
            // buttonCostosKruskal
            // 
            this.buttonCostosKruskal.Location = new System.Drawing.Point(5, 346);
            this.buttonCostosKruskal.Name = "buttonCostosKruskal";
            this.buttonCostosKruskal.Size = new System.Drawing.Size(173, 21);
            this.buttonCostosKruskal.TabIndex = 0;
            this.buttonCostosKruskal.Text = "Costo (KRUSKAL)";
            this.buttonCostosKruskal.UseVisualStyleBackColor = true;
            this.buttonCostosKruskal.Click += new System.EventHandler(this.buttonCostosKruskal_Click);
            // 
            // radioButtonDijkstraCosto
            // 
            this.radioButtonDijkstraCosto.AutoSize = true;
            this.radioButtonDijkstraCosto.Location = new System.Drawing.Point(25, 229);
            this.radioButtonDijkstraCosto.Name = "radioButtonDijkstraCosto";
            this.radioButtonDijkstraCosto.Size = new System.Drawing.Size(52, 17);
            this.radioButtonDijkstraCosto.TabIndex = 12;
            this.radioButtonDijkstraCosto.TabStop = true;
            this.radioButtonDijkstraCosto.Text = "Costo";
            this.radioButtonDijkstraCosto.UseVisualStyleBackColor = true;
            // 
            // radioButtonDijkstraTiempo
            // 
            this.radioButtonDijkstraTiempo.AutoSize = true;
            this.radioButtonDijkstraTiempo.Location = new System.Drawing.Point(83, 229);
            this.radioButtonDijkstraTiempo.Name = "radioButtonDijkstraTiempo";
            this.radioButtonDijkstraTiempo.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDijkstraTiempo.TabIndex = 13;
            this.radioButtonDijkstraTiempo.TabStop = true;
            this.radioButtonDijkstraTiempo.Text = "Tiempo";
            this.radioButtonDijkstraTiempo.UseVisualStyleBackColor = true;
            // 
            // FormGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1596, 774);
            this.Controls.Add(this.groupBoxInterconectividad);
            this.Controls.Add(this.panel1);
            this.Name = "FormGrafo";
            this.Text = "FormGrafo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxInterconectividad.ResumeLayout(false);
            this.groupBoxInterconectividad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCaso;
        private System.Windows.Forms.ListBox listBoxSeleccionaCiudad;
        private System.Windows.Forms.Label labelBorrarCiudad;
        private System.Windows.Forms.Button buttonBorrarCiudad;
        private System.Windows.Forms.GroupBox groupBoxInterconectividad;
        private System.Windows.Forms.Label labelInterconectividadminaTIEMEPOS;
        private System.Windows.Forms.Button buttonTiemposPrim;
        private System.Windows.Forms.Label labelInterconectividadminimaporcostos;
        private System.Windows.Forms.Button buttonCostosKruskal;
        private System.Windows.Forms.ListBox listBoxRutasOptimas;
        private System.Windows.Forms.ListBox listBoxCostos;
        private System.Windows.Forms.Label labelTOTAL;
        private System.Windows.Forms.ListBox listBoxTOTAL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonDijkstraTiempo;
        private System.Windows.Forms.RadioButton radioButtonDijkstraCosto;
    }
}