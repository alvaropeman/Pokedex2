namespace Pokedex2022_CSharp
{
    partial class Ventana2
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
            this.cajaDescripcion = new System.Windows.Forms.Label();
            this.evolucion2 = new System.Windows.Forms.PictureBox();
            this.evolucion = new System.Windows.Forms.PictureBox();
            this.imagenPokemon = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.habilidades = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.evolucion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaDescripcion
            // 
            this.cajaDescripcion.BackColor = System.Drawing.Color.White;
            this.cajaDescripcion.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDescripcion.ForeColor = System.Drawing.Color.Black;
            this.cajaDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cajaDescripcion.Location = new System.Drawing.Point(326, 354);
            this.cajaDescripcion.Name = "cajaDescripcion";
            this.cajaDescripcion.Size = new System.Drawing.Size(536, 143);
            this.cajaDescripcion.TabIndex = 0;
            // 
            // evolucion2
            // 
            this.evolucion2.BackColor = System.Drawing.Color.Transparent;
            this.evolucion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.evolucion2.Location = new System.Drawing.Point(151, 307);
            this.evolucion2.Name = "evolucion2";
            this.evolucion2.Size = new System.Drawing.Size(113, 118);
            this.evolucion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.evolucion2.TabIndex = 4;
            this.evolucion2.TabStop = false;
            // 
            // evolucion
            // 
            this.evolucion.BackColor = System.Drawing.Color.Transparent;
            this.evolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.evolucion.Location = new System.Drawing.Point(27, 307);
            this.evolucion.Name = "evolucion";
            this.evolucion.Size = new System.Drawing.Size(123, 118);
            this.evolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.evolucion.TabIndex = 3;
            this.evolucion.TabStop = false;
            this.evolucion.Click += new System.EventHandler(this.evolucion_Click);
            // 
            // imagenPokemon
            // 
            this.imagenPokemon.Location = new System.Drawing.Point(27, 97);
            this.imagenPokemon.Name = "imagenPokemon";
            this.imagenPokemon.Size = new System.Drawing.Size(237, 213);
            this.imagenPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPokemon.TabIndex = 1;
            this.imagenPokemon.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pokedex2.Properties.Resources.descripcion1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(723, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 42);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // habilidades
            // 
            this.habilidades.BackColor = System.Drawing.Color.White;
            this.habilidades.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidades.ForeColor = System.Drawing.Color.Black;
            this.habilidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.habilidades.Location = new System.Drawing.Point(319, 281);
            this.habilidades.Name = "habilidades";
            this.habilidades.Size = new System.Drawing.Size(560, 42);
            this.habilidades.TabIndex = 6;
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.White;
            this.tipo.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.ForeColor = System.Drawing.Color.Black;
            this.tipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipo.Location = new System.Drawing.Point(315, 150);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(560, 47);
            this.tipo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(318, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "HABILIDAD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(315, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "PERFIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokedex2.Properties.Resources.descripcion3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.habilidades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.evolucion2);
            this.Controls.Add(this.evolucion);
            this.Controls.Add(this.imagenPokemon);
            this.Controls.Add(this.cajaDescripcion);
            this.DoubleBuffered = true;
            this.Name = "Ventana2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ventana2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evolucion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cajaDescripcion;
        private System.Windows.Forms.PictureBox imagenPokemon;
        private System.Windows.Forms.PictureBox evolucion;
        private System.Windows.Forms.PictureBox evolucion2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label habilidades;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}