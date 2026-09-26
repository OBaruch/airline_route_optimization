namespace Al_Qaeda_Fying
{
    partial class FormPasajeros
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
            this.buttonRegresarAVuelos = new System.Windows.Forms.Button();
            this.labelListaPasajeros = new System.Windows.Forms.Label();
            this.groupBoxBusquedaPasajeros = new System.Windows.Forms.GroupBox();
            this.radioButtonAsiento = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.radioButtonEdad = new System.Windows.Forms.RadioButton();
            this.radioButtonApellidos = new System.Windows.Forms.RadioButton();
            this.radioButtonNombres = new System.Windows.Forms.RadioButton();
            this.buttonEliminarPasajero = new System.Windows.Forms.Button();
            this.listBoxListaPasajeros = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxOrdenar = new System.Windows.Forms.GroupBox();
            this.radioButtonOrdenamientoRuta = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdenamientoAsiento = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdenamietoNombre = new System.Windows.Forms.RadioButton();
            this.labelOrdenarPor = new System.Windows.Forms.Label();
            this.groupBoxBusquedaPasajeros.SuspendLayout();
            this.groupBoxOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegresarAVuelos
            // 
            this.buttonRegresarAVuelos.Location = new System.Drawing.Point(707, 501);
            this.buttonRegresarAVuelos.Name = "buttonRegresarAVuelos";
            this.buttonRegresarAVuelos.Size = new System.Drawing.Size(109, 23);
            this.buttonRegresarAVuelos.TabIndex = 0;
            this.buttonRegresarAVuelos.Text = "Regresar";
            this.buttonRegresarAVuelos.UseVisualStyleBackColor = true;
            this.buttonRegresarAVuelos.Click += new System.EventHandler(this.buttonRegresarAVuelos_Click);
            // 
            // labelListaPasajeros
            // 
            this.labelListaPasajeros.AutoSize = true;
            this.labelListaPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaPasajeros.Location = new System.Drawing.Point(23, 28);
            this.labelListaPasajeros.Name = "labelListaPasajeros";
            this.labelListaPasajeros.Size = new System.Drawing.Size(161, 24);
            this.labelListaPasajeros.TabIndex = 2;
            this.labelListaPasajeros.Text = "Lista de Pasajeros";
            // 
            // groupBoxBusquedaPasajeros
            // 
            this.groupBoxBusquedaPasajeros.BackColor = System.Drawing.Color.Silver;
            this.groupBoxBusquedaPasajeros.Controls.Add(this.radioButtonAsiento);
            this.groupBoxBusquedaPasajeros.Controls.Add(this.label1);
            this.groupBoxBusquedaPasajeros.Controls.Add(this.textBoxBusca);
            this.groupBoxBusquedaPasajeros.Controls.Add(this.radioButtonEdad);
            this.groupBoxBusquedaPasajeros.Controls.Add(this.radioButtonApellidos);
            this.groupBoxBusquedaPasajeros.Controls.Add(this.radioButtonNombres);
            this.groupBoxBusquedaPasajeros.Location = new System.Drawing.Point(563, 96);
            this.groupBoxBusquedaPasajeros.Name = "groupBoxBusquedaPasajeros";
            this.groupBoxBusquedaPasajeros.Size = new System.Drawing.Size(253, 83);
            this.groupBoxBusquedaPasajeros.TabIndex = 8;
            this.groupBoxBusquedaPasajeros.TabStop = false;
            this.groupBoxBusquedaPasajeros.Text = "Busqeuda de pasajeros";
            // 
            // radioButtonAsiento
            // 
            this.radioButtonAsiento.AutoSize = true;
            this.radioButtonAsiento.Location = new System.Drawing.Point(191, 37);
            this.radioButtonAsiento.Name = "radioButtonAsiento";
            this.radioButtonAsiento.Size = new System.Drawing.Size(60, 17);
            this.radioButtonAsiento.TabIndex = 7;
            this.radioButtonAsiento.Text = "Asiento";
            this.radioButtonAsiento.UseVisualStyleBackColor = true;
            this.radioButtonAsiento.CheckedChanged += new System.EventHandler(this.radioButtonAsiento_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILTAR POR ";
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(1, 60);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(250, 20);
            this.textBoxBusca.TabIndex = 3;
            this.textBoxBusca.TextChanged += new System.EventHandler(this.textBoxBusca_TextChanged);
            this.textBoxBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBusca_KeyPress);
            // 
            // radioButtonEdad
            // 
            this.radioButtonEdad.AutoSize = true;
            this.radioButtonEdad.Location = new System.Drawing.Point(145, 37);
            this.radioButtonEdad.Name = "radioButtonEdad";
            this.radioButtonEdad.Size = new System.Drawing.Size(50, 17);
            this.radioButtonEdad.TabIndex = 2;
            this.radioButtonEdad.Text = "Edad";
            this.radioButtonEdad.UseVisualStyleBackColor = true;
            this.radioButtonEdad.CheckedChanged += new System.EventHandler(this.radioButtonEdad_CheckedChanged);
            // 
            // radioButtonApellidos
            // 
            this.radioButtonApellidos.AutoSize = true;
            this.radioButtonApellidos.Location = new System.Drawing.Point(76, 37);
            this.radioButtonApellidos.Name = "radioButtonApellidos";
            this.radioButtonApellidos.Size = new System.Drawing.Size(72, 17);
            this.radioButtonApellidos.TabIndex = 1;
            this.radioButtonApellidos.Text = "Apellido/s";
            this.radioButtonApellidos.UseVisualStyleBackColor = true;
            this.radioButtonApellidos.CheckedChanged += new System.EventHandler(this.radioButtonApellidos_CheckedChanged);
            // 
            // radioButtonNombres
            // 
            this.radioButtonNombres.AutoSize = true;
            this.radioButtonNombres.Checked = true;
            this.radioButtonNombres.Location = new System.Drawing.Point(7, 37);
            this.radioButtonNombres.Name = "radioButtonNombres";
            this.radioButtonNombres.Size = new System.Drawing.Size(72, 17);
            this.radioButtonNombres.TabIndex = 0;
            this.radioButtonNombres.TabStop = true;
            this.radioButtonNombres.Text = "Nombre/s";
            this.radioButtonNombres.UseVisualStyleBackColor = true;
            this.radioButtonNombres.CheckedChanged += new System.EventHandler(this.radioButtonNombres_CheckedChanged);
            // 
            // buttonEliminarPasajero
            // 
            this.buttonEliminarPasajero.Enabled = false;
            this.buttonEliminarPasajero.Location = new System.Drawing.Point(545, 501);
            this.buttonEliminarPasajero.Name = "buttonEliminarPasajero";
            this.buttonEliminarPasajero.Size = new System.Drawing.Size(156, 23);
            this.buttonEliminarPasajero.TabIndex = 9;
            this.buttonEliminarPasajero.Text = "Eliminar Pasajero";
            this.buttonEliminarPasajero.UseVisualStyleBackColor = true;
            this.buttonEliminarPasajero.Click += new System.EventHandler(this.buttonEliminarPasajero_Click);
            // 
            // listBoxListaPasajeros
            // 
            this.listBoxListaPasajeros.FormattingEnabled = true;
            this.listBoxListaPasajeros.Location = new System.Drawing.Point(25, 117);
            this.listBoxListaPasajeros.Name = "listBoxListaPasajeros";
            this.listBoxListaPasajeros.Size = new System.Drawing.Size(512, 407);
            this.listBoxListaPasajeros.TabIndex = 10;
            this.listBoxListaPasajeros.SelectedIndexChanged += new System.EventHandler(this.listBoxListaPasajeros_SelectedIndexChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "RUTA         NOMBRE_APELLIDO                                                   ED" +
                "AD                          ASIENTO"});
            this.listBox1.Location = new System.Drawing.Point(24, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(513, 17);
            this.listBox1.TabIndex = 11;
            // 
            // groupBoxOrdenar
            // 
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOrdenamientoRuta);
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOrdenamientoAsiento);
            this.groupBoxOrdenar.Controls.Add(this.radioButtonOrdenamietoNombre);
            this.groupBoxOrdenar.Controls.Add(this.labelOrdenarPor);
            this.groupBoxOrdenar.Location = new System.Drawing.Point(567, 185);
            this.groupBoxOrdenar.Name = "groupBoxOrdenar";
            this.groupBoxOrdenar.Size = new System.Drawing.Size(249, 55);
            this.groupBoxOrdenar.TabIndex = 12;
            this.groupBoxOrdenar.TabStop = false;
            this.groupBoxOrdenar.Text = "Ordenamiento";
            // 
            // radioButtonOrdenamientoRuta
            // 
            this.radioButtonOrdenamientoRuta.AutoSize = true;
            this.radioButtonOrdenamientoRuta.Location = new System.Drawing.Point(99, 29);
            this.radioButtonOrdenamientoRuta.Name = "radioButtonOrdenamientoRuta";
            this.radioButtonOrdenamientoRuta.Size = new System.Drawing.Size(48, 17);
            this.radioButtonOrdenamientoRuta.TabIndex = 14;
            this.radioButtonOrdenamientoRuta.Text = "Ruta";
            this.radioButtonOrdenamientoRuta.UseVisualStyleBackColor = true;
            this.radioButtonOrdenamientoRuta.CheckedChanged += new System.EventHandler(this.radioButtonOrdenamientoRuta_CheckedChanged);
            // 
            // radioButtonOrdenamientoAsiento
            // 
            this.radioButtonOrdenamientoAsiento.AutoSize = true;
            this.radioButtonOrdenamientoAsiento.Location = new System.Drawing.Point(173, 29);
            this.radioButtonOrdenamientoAsiento.Name = "radioButtonOrdenamientoAsiento";
            this.radioButtonOrdenamientoAsiento.Size = new System.Drawing.Size(60, 17);
            this.radioButtonOrdenamientoAsiento.TabIndex = 13;
            this.radioButtonOrdenamientoAsiento.Text = "Asiento";
            this.radioButtonOrdenamientoAsiento.UseVisualStyleBackColor = true;
            this.radioButtonOrdenamientoAsiento.CheckedChanged += new System.EventHandler(this.radioButtonOrdenamientoAsiento_CheckedChanged);
            // 
            // radioButtonOrdenamietoNombre
            // 
            this.radioButtonOrdenamietoNombre.AutoSize = true;
            this.radioButtonOrdenamietoNombre.Checked = true;
            this.radioButtonOrdenamietoNombre.Location = new System.Drawing.Point(5, 29);
            this.radioButtonOrdenamietoNombre.Name = "radioButtonOrdenamietoNombre";
            this.radioButtonOrdenamietoNombre.Size = new System.Drawing.Size(72, 17);
            this.radioButtonOrdenamietoNombre.TabIndex = 9;
            this.radioButtonOrdenamietoNombre.TabStop = true;
            this.radioButtonOrdenamietoNombre.Text = "Nombre/s";
            this.radioButtonOrdenamietoNombre.UseVisualStyleBackColor = true;
            this.radioButtonOrdenamietoNombre.CheckedChanged += new System.EventHandler(this.radioButtonOrdenamietoNombre_CheckedChanged);
            // 
            // labelOrdenarPor
            // 
            this.labelOrdenarPor.AutoSize = true;
            this.labelOrdenarPor.Location = new System.Drawing.Point(143, 13);
            this.labelOrdenarPor.Name = "labelOrdenarPor";
            this.labelOrdenarPor.Size = new System.Drawing.Size(90, 13);
            this.labelOrdenarPor.TabIndex = 8;
            this.labelOrdenarPor.Text = "ORDENAR POR ";
            // 
            // FormPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(828, 557);
            this.Controls.Add(this.groupBoxOrdenar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBoxListaPasajeros);
            this.Controls.Add(this.buttonEliminarPasajero);
            this.Controls.Add(this.groupBoxBusquedaPasajeros);
            this.Controls.Add(this.labelListaPasajeros);
            this.Controls.Add(this.buttonRegresarAVuelos);
            this.Name = "FormPasajeros";
            this.Text = "FormPasajeros";
            this.TextChanged += new System.EventHandler(this.textBoxBusca_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBusca_TextChanged);
            this.groupBoxBusquedaPasajeros.ResumeLayout(false);
            this.groupBoxBusquedaPasajeros.PerformLayout();
            this.groupBoxOrdenar.ResumeLayout(false);
            this.groupBoxOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegresarAVuelos;
        private System.Windows.Forms.Label labelListaPasajeros;
        private System.Windows.Forms.GroupBox groupBoxBusquedaPasajeros;
        private System.Windows.Forms.RadioButton radioButtonAsiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.RadioButton radioButtonEdad;
        private System.Windows.Forms.RadioButton radioButtonApellidos;
        private System.Windows.Forms.RadioButton radioButtonNombres;
        private System.Windows.Forms.Button buttonEliminarPasajero;
        private System.Windows.Forms.ListBox listBoxListaPasajeros;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxOrdenar;
        private System.Windows.Forms.RadioButton radioButtonOrdenamientoRuta;
        private System.Windows.Forms.RadioButton radioButtonOrdenamientoAsiento;
        private System.Windows.Forms.RadioButton radioButtonOrdenamietoNombre;
        private System.Windows.Forms.Label labelOrdenarPor;
    }
}