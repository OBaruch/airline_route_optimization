namespace Al_Qaeda_Fying
{
    partial class FormRegistoPasajero
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
            this.labelNombres = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelRutaAutocompletada = new System.Windows.Forms.Label();
            this.labelOrigenAutocompletada = new System.Windows.Forms.Label();
            this.labelTiempoAutocompletada = new System.Windows.Forms.Label();
            this.labelCostoAutocompletada = new System.Windows.Forms.Label();
            this.labelDestinoAutocompletada = new System.Windows.Forms.Label();
            this.textBoxOrigen = new System.Windows.Forms.TextBox();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.buttonReservar = new System.Windows.Forms.Button();
            this.buttonVolverASeleccionarAsientos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAsiento = new System.Windows.Forms.Label();
            this.textNAsiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Enabled = false;
            this.labelNombres.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.Location = new System.Drawing.Point(16, 71);
            this.labelNombres.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(76, 19);
            this.labelNombres.TabIndex = 0;
            this.labelNombres.Text = "Nombre/s";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxNombres.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombres.Location = new System.Drawing.Point(102, 59);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(168, 26);
            this.textBoxNombres.TabIndex = 1;
            this.textBoxNombres.TextChanged += new System.EventHandler(this.textBoxNombres_TextChanged);
            this.textBoxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombres_KeyPress);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Enabled = false;
            this.labelApellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(340, 71);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(72, 19);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellidos";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxApellidos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidos.Location = new System.Drawing.Point(422, 59);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(168, 26);
            this.textBoxApellidos.TabIndex = 3;
            this.textBoxApellidos.TextChanged += new System.EventHandler(this.textBoxApellidos_TextChanged);
            this.textBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidos_KeyPress);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Enabled = false;
            this.labelEdad.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(689, 71);
            this.labelEdad.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(43, 19);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BackColor = System.Drawing.Color.PaleGreen;
            this.textBoxEdad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEdad.Location = new System.Drawing.Point(742, 59);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(49, 26);
            this.textBoxEdad.TabIndex = 5;
            this.textBoxEdad.TextChanged += new System.EventHandler(this.textBoxEdad_TextChanged);
            this.textBoxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelRutaAutocompletada
            // 
            this.labelRutaAutocompletada.AutoSize = true;
            this.labelRutaAutocompletada.Enabled = false;
            this.labelRutaAutocompletada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaAutocompletada.Location = new System.Drawing.Point(472, 170);
            this.labelRutaAutocompletada.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelRutaAutocompletada.Name = "labelRutaAutocompletada";
            this.labelRutaAutocompletada.Size = new System.Drawing.Size(42, 19);
            this.labelRutaAutocompletada.TabIndex = 6;
            this.labelRutaAutocompletada.Text = "Ruta";
            // 
            // labelOrigenAutocompletada
            // 
            this.labelOrigenAutocompletada.AutoSize = true;
            this.labelOrigenAutocompletada.Enabled = false;
            this.labelOrigenAutocompletada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigenAutocompletada.Location = new System.Drawing.Point(73, 170);
            this.labelOrigenAutocompletada.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelOrigenAutocompletada.Name = "labelOrigenAutocompletada";
            this.labelOrigenAutocompletada.Size = new System.Drawing.Size(58, 19);
            this.labelOrigenAutocompletada.TabIndex = 7;
            this.labelOrigenAutocompletada.Text = "Origen ";
            // 
            // labelTiempoAutocompletada
            // 
            this.labelTiempoAutocompletada.AutoSize = true;
            this.labelTiempoAutocompletada.Enabled = false;
            this.labelTiempoAutocompletada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempoAutocompletada.Location = new System.Drawing.Point(650, 170);
            this.labelTiempoAutocompletada.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTiempoAutocompletada.Name = "labelTiempoAutocompletada";
            this.labelTiempoAutocompletada.Size = new System.Drawing.Size(59, 19);
            this.labelTiempoAutocompletada.TabIndex = 8;
            this.labelTiempoAutocompletada.Text = "Tiempo";
            // 
            // labelCostoAutocompletada
            // 
            this.labelCostoAutocompletada.AutoSize = true;
            this.labelCostoAutocompletada.Enabled = false;
            this.labelCostoAutocompletada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoAutocompletada.Location = new System.Drawing.Point(472, 259);
            this.labelCostoAutocompletada.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelCostoAutocompletada.Name = "labelCostoAutocompletada";
            this.labelCostoAutocompletada.Size = new System.Drawing.Size(49, 19);
            this.labelCostoAutocompletada.TabIndex = 9;
            this.labelCostoAutocompletada.Text = "Costo";
            this.labelCostoAutocompletada.Click += new System.EventHandler(this.labelCostoAutocompletada_Click);
            // 
            // labelDestinoAutocompletada
            // 
            this.labelDestinoAutocompletada.AutoSize = true;
            this.labelDestinoAutocompletada.Enabled = false;
            this.labelDestinoAutocompletada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestinoAutocompletada.Location = new System.Drawing.Point(270, 170);
            this.labelDestinoAutocompletada.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelDestinoAutocompletada.Name = "labelDestinoAutocompletada";
            this.labelDestinoAutocompletada.Size = new System.Drawing.Size(61, 19);
            this.labelDestinoAutocompletada.TabIndex = 10;
            this.labelDestinoAutocompletada.Text = "Destino";
            // 
            // textBoxOrigen
            // 
            this.textBoxOrigen.Enabled = false;
            this.textBoxOrigen.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrigen.Location = new System.Drawing.Point(141, 158);
            this.textBoxOrigen.Name = "textBoxOrigen";
            this.textBoxOrigen.Size = new System.Drawing.Size(98, 29);
            this.textBoxOrigen.TabIndex = 11;
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Enabled = false;
            this.textBoxDestino.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDestino.Location = new System.Drawing.Point(341, 158);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(98, 29);
            this.textBoxDestino.TabIndex = 12;
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Enabled = false;
            this.textBoxRuta.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRuta.Location = new System.Drawing.Point(517, 158);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(98, 29);
            this.textBoxRuta.TabIndex = 13;
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Enabled = false;
            this.textBoxTiempo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTiempo.Location = new System.Drawing.Point(719, 158);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(98, 29);
            this.textBoxTiempo.TabIndex = 14;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Enabled = false;
            this.textBoxCosto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCosto.Location = new System.Drawing.Point(531, 249);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(131, 29);
            this.textBoxCosto.TabIndex = 15;
            // 
            // buttonReservar
            // 
            this.buttonReservar.Enabled = false;
            this.buttonReservar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservar.Location = new System.Drawing.Point(668, 246);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Size = new System.Drawing.Size(183, 33);
            this.buttonReservar.TabIndex = 16;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.UseVisualStyleBackColor = true;
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click);
            // 
            // buttonVolverASeleccionarAsientos
            // 
            this.buttonVolverASeleccionarAsientos.BackColor = System.Drawing.Color.Coral;
            this.buttonVolverASeleccionarAsientos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverASeleccionarAsientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVolverASeleccionarAsientos.Location = new System.Drawing.Point(36, 241);
            this.buttonVolverASeleccionarAsientos.Name = "buttonVolverASeleccionarAsientos";
            this.buttonVolverASeleccionarAsientos.Size = new System.Drawing.Size(203, 42);
            this.buttonVolverASeleccionarAsientos.TabIndex = 17;
            this.buttonVolverASeleccionarAsientos.Text = "Cambiar Asiento";
            this.buttonVolverASeleccionarAsientos.UseVisualStyleBackColor = false;
            this.buttonVolverASeleccionarAsientos.Click += new System.EventHandler(this.buttonVolverASeleccionarAsientos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 18;
            // 
            // labelAsiento
            // 
            this.labelAsiento.AutoSize = true;
            this.labelAsiento.Enabled = false;
            this.labelAsiento.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsiento.Location = new System.Drawing.Point(315, 260);
            this.labelAsiento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAsiento.Name = "labelAsiento";
            this.labelAsiento.Size = new System.Drawing.Size(61, 19);
            this.labelAsiento.TabIndex = 20;
            this.labelAsiento.Text = "Asiento";
            // 
            // textNAsiento
            // 
            this.textNAsiento.Enabled = false;
            this.textNAsiento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNAsiento.Location = new System.Drawing.Point(386, 251);
            this.textNAsiento.Name = "textNAsiento";
            this.textNAsiento.Size = new System.Drawing.Size(53, 29);
            this.textNAsiento.TabIndex = 21;
            // 
            // FormRegistoPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 292);
            this.Controls.Add(this.textNAsiento);
            this.Controls.Add(this.labelAsiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolverASeleccionarAsientos);
            this.Controls.Add(this.buttonReservar);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.textBoxTiempo);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.textBoxOrigen);
            this.Controls.Add(this.labelDestinoAutocompletada);
            this.Controls.Add(this.labelCostoAutocompletada);
            this.Controls.Add(this.labelTiempoAutocompletada);
            this.Controls.Add(this.labelOrigenAutocompletada);
            this.Controls.Add(this.labelRutaAutocompletada);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.labelNombres);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FormRegistoPasajero";
            this.Text = "FormRegistoPasajero";
            this.Load += new System.EventHandler(this.FormRegistoPasajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelRutaAutocompletada;
        private System.Windows.Forms.Label labelOrigenAutocompletada;
        private System.Windows.Forms.Label labelTiempoAutocompletada;
        private System.Windows.Forms.Label labelCostoAutocompletada;
        private System.Windows.Forms.Label labelDestinoAutocompletada;
        private System.Windows.Forms.TextBox textBoxOrigen;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.TextBox textBoxTiempo;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Button buttonReservar;
        private System.Windows.Forms.Button buttonVolverASeleccionarAsientos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAsiento;
        private System.Windows.Forms.TextBox textNAsiento;
    }
}