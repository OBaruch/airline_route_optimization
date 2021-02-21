namespace Al_Qaeda_Fying
{
    partial class FormMainVuelos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainVuelos));
            this.buttonAsientos = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.buttonListaDePasajeros = new System.Windows.Forms.Button();
            this.labelSeeccionaUnVuelo = new System.Windows.Forms.Label();
            this.listBoxVuelos = new System.Windows.Forms.ListBox();
            this.listBoxEncabezado = new System.Windows.Forms.ListBox();
            this.groupBoxBusquedaVuelos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.radioButtonDestino = new System.Windows.Forms.RadioButton();
            this.radioButtonOrigen = new System.Windows.Forms.RadioButton();
            this.radioButtonRuta = new System.Windows.Forms.RadioButton();
            this.groupBoxAgregarVuelo = new System.Windows.Forms.GroupBox();
            this.buttonEliminarVuelo = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.labelCosto = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelDestino = new System.Windows.Forms.Label();
            this.labelOrigen = new System.Windows.Forms.Label();
            this.labelRuta = new System.Windows.Forms.Label();
            this.buttonAgregarV = new System.Windows.Forms.Button();
            this.buttonGrafo = new System.Windows.Forms.Button();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.groupBoxOrdenamiento = new System.Windows.Forms.GroupBox();
            this.radioButtonOrdenmaientoDestino = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdenamientoOrigen = new System.Windows.Forms.RadioButton();
            this.radioButtonTIEMPO = new System.Windows.Forms.RadioButton();
            this.radioButtonCOSTO = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBoxBusquedaVuelos.SuspendLayout();
            this.groupBoxAgregarVuelo.SuspendLayout();
            this.groupBoxOrdenamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAsientos
            // 
            this.buttonAsientos.BackColor = System.Drawing.Color.Silver;
            this.buttonAsientos.Enabled = false;
            this.buttonAsientos.Location = new System.Drawing.Point(679, 294);
            this.buttonAsientos.Name = "buttonAsientos";
            this.buttonAsientos.Size = new System.Drawing.Size(146, 35);
            this.buttonAsientos.TabIndex = 2;
            this.buttonAsientos.Text = "Ver vuelo seleccionado";
            this.buttonAsientos.UseVisualStyleBackColor = false;
            this.buttonAsientos.Click += new System.EventHandler(this.buttonAsientos_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Enabled = false;
            this.logo.Location = new System.Drawing.Point(560, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(251, 64);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // buttonListaDePasajeros
            // 
            this.buttonListaDePasajeros.BackColor = System.Drawing.Color.Silver;
            this.buttonListaDePasajeros.Location = new System.Drawing.Point(500, 294);
            this.buttonListaDePasajeros.Name = "buttonListaDePasajeros";
            this.buttonListaDePasajeros.Size = new System.Drawing.Size(161, 35);
            this.buttonListaDePasajeros.TabIndex = 4;
            this.buttonListaDePasajeros.Text = "Lista de pasajeros";
            this.buttonListaDePasajeros.UseVisualStyleBackColor = false;
            this.buttonListaDePasajeros.Click += new System.EventHandler(this.buttonListaDePasajeros_Click);
            // 
            // labelSeeccionaUnVuelo
            // 
            this.labelSeeccionaUnVuelo.AutoSize = true;
            this.labelSeeccionaUnVuelo.BackColor = System.Drawing.Color.Transparent;
            this.labelSeeccionaUnVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeeccionaUnVuelo.Location = new System.Drawing.Point(23, 21);
            this.labelSeeccionaUnVuelo.Name = "labelSeeccionaUnVuelo";
            this.labelSeeccionaUnVuelo.Size = new System.Drawing.Size(229, 29);
            this.labelSeeccionaUnVuelo.TabIndex = 5;
            this.labelSeeccionaUnVuelo.Text = "Selecciona un vuelo";
            // 
            // listBoxVuelos
            // 
            this.listBoxVuelos.BackColor = System.Drawing.Color.Silver;
            this.listBoxVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVuelos.FormattingEnabled = true;
            this.listBoxVuelos.ItemHeight = 20;
            this.listBoxVuelos.Location = new System.Drawing.Point(12, 121);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.Size = new System.Drawing.Size(482, 504);
            this.listBoxVuelos.TabIndex = 6;
            this.listBoxVuelos.SelectedIndexChanged += new System.EventHandler(this.listBoxVuelos_SelectedIndexChanged);
            // 
            // listBoxEncabezado
            // 
            this.listBoxEncabezado.BackColor = System.Drawing.Color.Silver;
            this.listBoxEncabezado.Enabled = false;
            this.listBoxEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEncabezado.ItemHeight = 20;
            this.listBoxEncabezado.Items.AddRange(new object[] {
            "Ruta   \t       Origen \t Destino           Tiempo           Costo"});
            this.listBoxEncabezado.Location = new System.Drawing.Point(12, 91);
            this.listBoxEncabezado.Name = "listBoxEncabezado";
            this.listBoxEncabezado.Size = new System.Drawing.Size(482, 24);
            this.listBoxEncabezado.TabIndex = 0;
            // 
            // groupBoxBusquedaVuelos
            // 
            this.groupBoxBusquedaVuelos.BackColor = System.Drawing.Color.Silver;
            this.groupBoxBusquedaVuelos.Controls.Add(this.label1);
            this.groupBoxBusquedaVuelos.Controls.Add(this.textBoxBusca);
            this.groupBoxBusquedaVuelos.Controls.Add(this.radioButtonDestino);
            this.groupBoxBusquedaVuelos.Controls.Add(this.radioButtonOrigen);
            this.groupBoxBusquedaVuelos.Controls.Add(this.radioButtonRuta);
            this.groupBoxBusquedaVuelos.Location = new System.Drawing.Point(500, 91);
            this.groupBoxBusquedaVuelos.Name = "groupBoxBusquedaVuelos";
            this.groupBoxBusquedaVuelos.Size = new System.Drawing.Size(325, 108);
            this.groupBoxBusquedaVuelos.TabIndex = 7;
            this.groupBoxBusquedaVuelos.TabStop = false;
            this.groupBoxBusquedaVuelos.Text = "Busqeuda de vuelos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILTAR POR ";
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(23, 61);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(284, 20);
            this.textBoxBusca.TabIndex = 3;
            this.textBoxBusca.TextChanged += new System.EventHandler(this.textBoxBusca_TextChanged);
            this.textBoxBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBusca_TextChanged);
            // 
            // radioButtonDestino
            // 
            this.radioButtonDestino.AutoSize = true;
            this.radioButtonDestino.Location = new System.Drawing.Point(139, 38);
            this.radioButtonDestino.Name = "radioButtonDestino";
            this.radioButtonDestino.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDestino.TabIndex = 2;
            this.radioButtonDestino.Text = "Destino";
            this.radioButtonDestino.UseVisualStyleBackColor = true;
            this.radioButtonDestino.CheckedChanged += new System.EventHandler(this.radioButtonDestino_CheckedChanged);
            // 
            // radioButtonOrigen
            // 
            this.radioButtonOrigen.AutoSize = true;
            this.radioButtonOrigen.Location = new System.Drawing.Point(77, 38);
            this.radioButtonOrigen.Name = "radioButtonOrigen";
            this.radioButtonOrigen.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOrigen.TabIndex = 1;
            this.radioButtonOrigen.Text = "Origen";
            this.radioButtonOrigen.UseVisualStyleBackColor = true;
            this.radioButtonOrigen.CheckedChanged += new System.EventHandler(this.radioButtonOrigen_CheckedChanged);
            // 
            // radioButtonRuta
            // 
            this.radioButtonRuta.AutoSize = true;
            this.radioButtonRuta.Checked = true;
            this.radioButtonRuta.Location = new System.Drawing.Point(23, 38);
            this.radioButtonRuta.Name = "radioButtonRuta";
            this.radioButtonRuta.Size = new System.Drawing.Size(48, 17);
            this.radioButtonRuta.TabIndex = 0;
            this.radioButtonRuta.TabStop = true;
            this.radioButtonRuta.Text = "Ruta";
            this.radioButtonRuta.UseVisualStyleBackColor = true;
            this.radioButtonRuta.CheckedChanged += new System.EventHandler(this.radioButtonRuta_CheckedChanged);
            // 
            // groupBoxAgregarVuelo
            // 
            this.groupBoxAgregarVuelo.BackColor = System.Drawing.Color.Silver;
            this.groupBoxAgregarVuelo.Controls.Add(this.buttonEliminarVuelo);
            this.groupBoxAgregarVuelo.Controls.Add(this.labelPassword);
            this.groupBoxAgregarVuelo.Controls.Add(this.textBoxPassword);
            this.groupBoxAgregarVuelo.Controls.Add(this.textBoxCosto);
            this.groupBoxAgregarVuelo.Controls.Add(this.textBoxTiempo);
            this.groupBoxAgregarVuelo.Controls.Add(this.textBoxDestino);
            this.groupBoxAgregarVuelo.Controls.Add(this.textBoxOrigen);
            this.groupBoxAgregarVuelo.Controls.Add(this.textBoxRuta);
            this.groupBoxAgregarVuelo.Controls.Add(this.labelCosto);
            this.groupBoxAgregarVuelo.Controls.Add(this.labelTiempo);
            this.groupBoxAgregarVuelo.Controls.Add(this.labelDestino);
            this.groupBoxAgregarVuelo.Controls.Add(this.labelOrigen);
            this.groupBoxAgregarVuelo.Controls.Add(this.labelRuta);
            this.groupBoxAgregarVuelo.Controls.Add(this.buttonAgregarV);
            this.groupBoxAgregarVuelo.Location = new System.Drawing.Point(500, 335);
            this.groupBoxAgregarVuelo.Name = "groupBoxAgregarVuelo";
            this.groupBoxAgregarVuelo.Size = new System.Drawing.Size(325, 216);
            this.groupBoxAgregarVuelo.TabIndex = 8;
            this.groupBoxAgregarVuelo.TabStop = false;
            this.groupBoxAgregarVuelo.Text = "Administrar Vuelos";
            // 
            // buttonEliminarVuelo
            // 
            this.buttonEliminarVuelo.Enabled = false;
            this.buttonEliminarVuelo.Location = new System.Drawing.Point(6, 182);
            this.buttonEliminarVuelo.Name = "buttonEliminarVuelo";
            this.buttonEliminarVuelo.Size = new System.Drawing.Size(313, 28);
            this.buttonEliminarVuelo.TabIndex = 9;
            this.buttonEliminarVuelo.Text = "Eliminar Vuelo ";
            this.buttonEliminarVuelo.UseVisualStyleBackColor = true;
            this.buttonEliminarVuelo.Click += new System.EventHandler(this.buttonEliminarVuelo_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(8, 157);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(60, 150);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(77, 20);
            this.textBoxPassword.TabIndex = 21;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(224, 122);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(95, 20);
            this.textBoxCosto.TabIndex = 20;
            this.textBoxCosto.TextChanged += new System.EventHandler(this.textBoxCosto_TextChanged);
            this.textBoxCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCosto_KeyPress);
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Location = new System.Drawing.Point(60, 124);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(101, 20);
            this.textBoxTiempo.TabIndex = 19;
            this.textBoxTiempo.TextChanged += new System.EventHandler(this.textBoxTiempo_TextChanged);
            this.textBoxTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimpo_KeyPress);
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(224, 81);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(95, 20);
            this.textBoxDestino.TabIndex = 18;
            this.textBoxDestino.TextChanged += new System.EventHandler(this.textBoxDestino_TextChanged);
            this.textBoxDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDestino_KeyPress);
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Location = new System.Drawing.Point(60, 81);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(101, 20);
            this.textBoxOrigen.TabIndex = 17;
            this.textBoxOrigen.TextChanged += new System.EventHandler(this.textBoxOrigen_TextChanged);
            this.textBoxOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrigen_KeyPress);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Enabled = false;
            this.textBoxRuta.Location = new System.Drawing.Point(60, 40);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(126, 20);
            this.textBoxRuta.TabIndex = 16;
            this.textBoxRuta.TextChanged += new System.EventHandler(this.textBoxRuta_TextChanged);
            this.textBoxRuta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRuta_KeyPress);
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCosto.Location = new System.Drawing.Point(177, 122);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(41, 20);
            this.labelCosto.TabIndex = 15;
            this.labelCosto.Text = "Costo";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempo.Location = new System.Drawing.Point(2, 122);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(53, 20);
            this.labelTiempo.TabIndex = 14;
            this.labelTiempo.Text = "Tiempo";
            // 
            // labelDestino
            // 
            this.labelDestino.AutoSize = true;
            this.labelDestino.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestino.Location = new System.Drawing.Point(167, 81);
            this.labelDestino.Name = "labelDestino";
            this.labelDestino.Size = new System.Drawing.Size(51, 20);
            this.labelDestino.TabIndex = 13;
            this.labelDestino.Text = "Destino";
            // 
            // labelOrigen
            // 
            this.labelOrigen.AutoSize = true;
            this.labelOrigen.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigen.Location = new System.Drawing.Point(7, 81);
            this.labelOrigen.Name = "labelOrigen";
            this.labelOrigen.Size = new System.Drawing.Size(47, 20);
            this.labelOrigen.TabIndex = 12;
            this.labelOrigen.Text = "Origen";
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.Location = new System.Drawing.Point(19, 38);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(35, 20);
            this.labelRuta.TabIndex = 11;
            this.labelRuta.Text = "Ruta";
            // 
            // buttonAgregarV
            // 
            this.buttonAgregarV.Enabled = false;
            this.buttonAgregarV.Location = new System.Drawing.Point(164, 148);
            this.buttonAgregarV.Name = "buttonAgregarV";
            this.buttonAgregarV.Size = new System.Drawing.Size(155, 23);
            this.buttonAgregarV.TabIndex = 10;
            this.buttonAgregarV.Text = "Agregar";
            this.buttonAgregarV.UseVisualStyleBackColor = true;
            this.buttonAgregarV.Click += new System.EventHandler(this.buttonAgregarV_Click);
            // 
            // buttonGrafo
            // 
            this.buttonGrafo.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonGrafo.Location = new System.Drawing.Point(515, 584);
            this.buttonGrafo.Name = "buttonGrafo";
            this.buttonGrafo.Size = new System.Drawing.Size(295, 25);
            this.buttonGrafo.TabIndex = 9;
            this.buttonGrafo.Text = "Mapa";
            this.buttonGrafo.UseVisualStyleBackColor = false;
            this.buttonGrafo.Click += new System.EventHandler(this.buttonGrafo_Click);
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Location = new System.Drawing.Point(11, 16);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(87, 13);
            this.labelOrdenar.TabIndex = 6;
            this.labelOrdenar.Text = "ORDENAR POR";
            // 
            // groupBoxOrdenamiento
            // 
            this.groupBoxOrdenamiento.BackColor = System.Drawing.Color.Silver;
            this.groupBoxOrdenamiento.Controls.Add(this.radioButtonOrdenmaientoDestino);
            this.groupBoxOrdenamiento.Controls.Add(this.radioButtonOrdenamientoOrigen);
            this.groupBoxOrdenamiento.Controls.Add(this.radioButtonTIEMPO);
            this.groupBoxOrdenamiento.Controls.Add(this.radioButtonCOSTO);
            this.groupBoxOrdenamiento.Controls.Add(this.labelOrdenar);
            this.groupBoxOrdenamiento.Location = new System.Drawing.Point(500, 211);
            this.groupBoxOrdenamiento.Name = "groupBoxOrdenamiento";
            this.groupBoxOrdenamiento.Size = new System.Drawing.Size(323, 77);
            this.groupBoxOrdenamiento.TabIndex = 10;
            this.groupBoxOrdenamiento.TabStop = false;
            this.groupBoxOrdenamiento.Text = "Ordenamiento ";
            // 
            // radioButtonOrdenmaientoDestino
            // 
            this.radioButtonOrdenmaientoDestino.AutoSize = true;
            this.radioButtonOrdenmaientoDestino.Location = new System.Drawing.Point(205, 35);
            this.radioButtonOrdenmaientoDestino.Name = "radioButtonOrdenmaientoDestino";
            this.radioButtonOrdenmaientoDestino.Size = new System.Drawing.Size(61, 17);
            this.radioButtonOrdenmaientoDestino.TabIndex = 10;
            this.radioButtonOrdenmaientoDestino.TabStop = true;
            this.radioButtonOrdenmaientoDestino.Text = "Destino";
            this.radioButtonOrdenmaientoDestino.UseVisualStyleBackColor = true;
            this.radioButtonOrdenmaientoDestino.CheckedChanged += new System.EventHandler(this.radioButtonOrdenmaientoDestino_CheckedChanged);
            // 
            // radioButtonOrdenamientoOrigen
            // 
            this.radioButtonOrdenamientoOrigen.AutoSize = true;
            this.radioButtonOrdenamientoOrigen.Location = new System.Drawing.Point(143, 35);
            this.radioButtonOrdenamientoOrigen.Name = "radioButtonOrdenamientoOrigen";
            this.radioButtonOrdenamientoOrigen.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOrdenamientoOrigen.TabIndex = 9;
            this.radioButtonOrdenamientoOrigen.TabStop = true;
            this.radioButtonOrdenamientoOrigen.Text = "Origen";
            this.radioButtonOrdenamientoOrigen.UseVisualStyleBackColor = true;
            this.radioButtonOrdenamientoOrigen.CheckedChanged += new System.EventHandler(this.radioButtonOrdenamientoOrigen_CheckedChanged);
            // 
            // radioButtonTIEMPO
            // 
            this.radioButtonTIEMPO.AutoSize = true;
            this.radioButtonTIEMPO.Location = new System.Drawing.Point(76, 35);
            this.radioButtonTIEMPO.Name = "radioButtonTIEMPO";
            this.radioButtonTIEMPO.Size = new System.Drawing.Size(60, 17);
            this.radioButtonTIEMPO.TabIndex = 8;
            this.radioButtonTIEMPO.TabStop = true;
            this.radioButtonTIEMPO.Text = "Tiempo";
            this.radioButtonTIEMPO.UseVisualStyleBackColor = true;
            this.radioButtonTIEMPO.CheckedChanged += new System.EventHandler(this.radioButtonTIEMPO_CheckedChanged);
            // 
            // radioButtonCOSTO
            // 
            this.radioButtonCOSTO.AutoSize = true;
            this.radioButtonCOSTO.Location = new System.Drawing.Point(14, 35);
            this.radioButtonCOSTO.Name = "radioButtonCOSTO";
            this.radioButtonCOSTO.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCOSTO.TabIndex = 7;
            this.radioButtonCOSTO.TabStop = true;
            this.radioButtonCOSTO.Text = "Costo";
            this.radioButtonCOSTO.UseVisualStyleBackColor = true;
            this.radioButtonCOSTO.CheckedChanged += new System.EventHandler(this.radioButtonCOSTO_CheckedChanged);
            // 
            // FormMainVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 637);
            this.Controls.Add(this.groupBoxOrdenamiento);
            this.Controls.Add(this.buttonGrafo);
            this.Controls.Add(this.groupBoxAgregarVuelo);
            this.Controls.Add(this.groupBoxBusquedaVuelos);
            this.Controls.Add(this.listBoxEncabezado);
            this.Controls.Add(this.listBoxVuelos);
            this.Controls.Add(this.labelSeeccionaUnVuelo);
            this.Controls.Add(this.buttonAsientos);
            this.Controls.Add(this.buttonListaDePasajeros);
            this.Controls.Add(this.logo);
            this.Name = "FormMainVuelos";
            this.Text = "Vuelos Al Qaeda Flying";
            this.Load += new System.EventHandler(this.FormMainVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBoxBusquedaVuelos.ResumeLayout(false);
            this.groupBoxBusquedaVuelos.PerformLayout();
            this.groupBoxAgregarVuelo.ResumeLayout(false);
            this.groupBoxAgregarVuelo.PerformLayout();
            this.groupBoxOrdenamiento.ResumeLayout(false);
            this.groupBoxOrdenamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAsientos;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button buttonListaDePasajeros;
        private System.Windows.Forms.Label labelSeeccionaUnVuelo;
        private System.Windows.Forms.ListBox listBoxVuelos;
        private System.Windows.Forms.ListBox listBoxEncabezado;
        private System.Windows.Forms.GroupBox groupBoxBusquedaVuelos;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.RadioButton radioButtonDestino;
        private System.Windows.Forms.RadioButton radioButtonOrigen;
        private System.Windows.Forms.RadioButton radioButtonRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAgregarVuelo;
        private System.Windows.Forms.Button buttonAgregarV;
        private System.Windows.Forms.Button buttonEliminarVuelo;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.TextBox textBoxTiempo;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelDestino;
        private System.Windows.Forms.Label labelOrigen;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonGrafo;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.GroupBox groupBoxOrdenamiento;
        private System.Windows.Forms.RadioButton radioButtonOrdenmaientoDestino;
        private System.Windows.Forms.RadioButton radioButtonOrdenamientoOrigen;
        private System.Windows.Forms.RadioButton radioButtonTIEMPO;
        private System.Windows.Forms.RadioButton radioButtonCOSTO;
    }
}

