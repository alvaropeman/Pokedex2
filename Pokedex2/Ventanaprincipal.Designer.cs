namespace Pokedex2
{
    partial class Ventanaprincipal
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
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.boton_izq = new System.Windows.Forms.Button();
            this.boton_der = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Button();
            this.fisicoPokemon = new System.Windows.Forms.Button();
            this.tipoEspecie = new System.Windows.Forms.Button();
            this.movimmientos = new System.Windows.Forms.Button();
            this.Habitad = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.Button();
            this.preEvolucion = new System.Windows.Forms.PictureBox();
            this.posEvolucion = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preEvolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posEvolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombrePokemon.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.Color.Lime;
            this.nombrePokemon.Location = new System.Drawing.Point(29, 71);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(366, 144);
            this.nombrePokemon.TabIndex = 4;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boton_izq
            // 
            this.boton_izq.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_izq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_izq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_izq.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold);
            this.boton_izq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boton_izq.Location = new System.Drawing.Point(446, 342);
            this.boton_izq.Name = "boton_izq";
            this.boton_izq.Size = new System.Drawing.Size(28, 26);
            this.boton_izq.TabIndex = 0;
            this.boton_izq.UseVisualStyleBackColor = false;
            this.boton_izq.Click += new System.EventHandler(this.button3_Click);
            // 
            // boton_der
            // 
            this.boton_der.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_der.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_der.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_der.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_der.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boton_der.Location = new System.Drawing.Point(511, 343);
            this.boton_der.Name = "boton_der";
            this.boton_der.Size = new System.Drawing.Size(27, 25);
            this.boton_der.TabIndex = 3;
            this.boton_der.UseVisualStyleBackColor = false;
            this.boton_der.Click += new System.EventHandler(this.boton_der_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox2.Location = new System.Drawing.Point(468, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // nombre
            // 
            this.nombre.BackgroundImage = global::Pokedex2.Properties.Resources.botonesMenu2;
            this.nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombre.Location = new System.Drawing.Point(20, 291);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(138, 66);
            this.nombre.TabIndex = 8;
            this.nombre.Text = "nombre";
            this.nombre.UseVisualStyleBackColor = true;
            this.nombre.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // fisicoPokemon
            // 
            this.fisicoPokemon.BackgroundImage = global::Pokedex2.Properties.Resources.botonesMenu2;
            this.fisicoPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fisicoPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fisicoPokemon.Location = new System.Drawing.Point(156, 234);
            this.fisicoPokemon.Name = "fisicoPokemon";
            this.fisicoPokemon.Size = new System.Drawing.Size(126, 57);
            this.fisicoPokemon.TabIndex = 9;
            this.fisicoPokemon.Text = "caracteristicas";
            this.fisicoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fisicoPokemon.UseVisualStyleBackColor = true;
            this.fisicoPokemon.Click += new System.EventHandler(this.fisicoPokemon_Click);
            // 
            // tipoEspecie
            // 
            this.tipoEspecie.BackgroundImage = global::Pokedex2.Properties.Resources.botonesMenu2;
            this.tipoEspecie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tipoEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoEspecie.Location = new System.Drawing.Point(281, 291);
            this.tipoEspecie.Name = "tipoEspecie";
            this.tipoEspecie.Size = new System.Drawing.Size(113, 67);
            this.tipoEspecie.TabIndex = 10;
            this.tipoEspecie.Text = "tipo ";
            this.tipoEspecie.UseVisualStyleBackColor = true;
            this.tipoEspecie.Click += new System.EventHandler(this.tipoEspecie_Click);
            // 
            // movimmientos
            // 
            this.movimmientos.BackgroundImage = global::Pokedex2.Properties.Resources.botonesMenu2;
            this.movimmientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.movimmientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movimmientos.Location = new System.Drawing.Point(156, 291);
            this.movimmientos.Name = "movimmientos";
            this.movimmientos.Size = new System.Drawing.Size(126, 67);
            this.movimmientos.TabIndex = 11;
            this.movimmientos.Text = "movimientos";
            this.movimmientos.UseVisualStyleBackColor = true;
            this.movimmientos.Click += new System.EventHandler(this.movimmientos_Click);
            // 
            // Habitad
            // 
            this.Habitad.BackgroundImage = global::Pokedex2.Properties.Resources.botonesMenu2;
            this.Habitad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Habitad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Habitad.Location = new System.Drawing.Point(282, 233);
            this.Habitad.Name = "Habitad";
            this.Habitad.Size = new System.Drawing.Size(113, 60);
            this.Habitad.TabIndex = 12;
            this.Habitad.Text = "habitat";
            this.Habitad.UseVisualStyleBackColor = true;
            this.Habitad.Click += new System.EventHandler(this.Habitad_Click);
            // 
            // descripcion
            // 
            this.descripcion.BackgroundImage = global::Pokedex2.Properties.Resources.botonesMenu2;
            this.descripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descripcion.ForeColor = System.Drawing.Color.Black;
            this.descripcion.Location = new System.Drawing.Point(20, 234);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(139, 57);
            this.descripcion.TabIndex = 13;
            this.descripcion.Text = "descripcion";
            this.descripcion.UseVisualStyleBackColor = true;
            this.descripcion.Click += new System.EventHandler(this.descripcion_Click);
            // 
            // preEvolucion
            // 
            this.preEvolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.preEvolucion.Location = new System.Drawing.Point(646, 95);
            this.preEvolucion.Name = "preEvolucion";
            this.preEvolucion.Size = new System.Drawing.Size(95, 87);
            this.preEvolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preEvolucion.TabIndex = 15;
            this.preEvolucion.TabStop = false;
            // 
            // posEvolucion
            // 
            this.posEvolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.posEvolucion.Location = new System.Drawing.Point(646, 179);
            this.posEvolucion.Name = "posEvolucion";
            this.posEvolucion.Size = new System.Drawing.Size(95, 88);
            this.posEvolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.posEvolucion.TabIndex = 16;
            this.posEvolucion.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Pokedex2.Properties.Resources.boton_inicio;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(705, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 76);
            this.button3.TabIndex = 17;
            this.button3.Text = "iniciar/\r\nreiniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Ventanaprincipal
            // 
            this.BackgroundImage = global::Pokedex2.Properties.Resources.pokedex2_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.posEvolucion);
            this.Controls.Add(this.preEvolucion);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.Habitad);
            this.Controls.Add(this.movimmientos);
            this.Controls.Add(this.tipoEspecie);
            this.Controls.Add(this.fisicoPokemon);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.boton_izq);
            this.Controls.Add(this.boton_der);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "Ventanaprincipal";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Ventanaprincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preEvolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posEvolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button boton_izq;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button boton_der;
        private System.Windows.Forms.Button nombre;
        private System.Windows.Forms.Button fisicoPokemon;
        private System.Windows.Forms.Button tipoEspecie;
        private System.Windows.Forms.Button movimmientos;
        private System.Windows.Forms.Button Habitad;
        private System.Windows.Forms.Button descripcion;
        private System.Windows.Forms.PictureBox preEvolucion;
        private System.Windows.Forms.PictureBox posEvolucion;
        private System.Windows.Forms.Button button3;
    }
}

