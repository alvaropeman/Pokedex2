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
            ((System.ComponentModel.ISupportInitialize)(this.evolucion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaDescripcion
            // 
            this.cajaDescripcion.BackColor = System.Drawing.Color.Red;
            this.cajaDescripcion.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDescripcion.ForeColor = System.Drawing.Color.Black;
            this.cajaDescripcion.Location = new System.Drawing.Point(24, 23);
            this.cajaDescripcion.Name = "cajaDescripcion";
            this.cajaDescripcion.Size = new System.Drawing.Size(240, 216);
            this.cajaDescripcion.TabIndex = 0;
            this.cajaDescripcion.Text = "label1";
            this.cajaDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evolucion2
            // 
            this.evolucion2.BackColor = System.Drawing.Color.Red;
            this.evolucion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.evolucion2.Location = new System.Drawing.Point(27, 293);
            this.evolucion2.Name = "evolucion2";
            this.evolucion2.Size = new System.Drawing.Size(109, 119);
            this.evolucion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.evolucion2.TabIndex = 4;
            this.evolucion2.TabStop = false;
            // 
            // evolucion
            // 
            this.evolucion.BackColor = System.Drawing.Color.Red;
            this.evolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.evolucion.Location = new System.Drawing.Point(155, 293);
            this.evolucion.Name = "evolucion";
            this.evolucion.Size = new System.Drawing.Size(109, 119);
            this.evolucion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.evolucion.TabIndex = 3;
            this.evolucion.TabStop = false;
            this.evolucion.Click += new System.EventHandler(this.evolucion_Click);
            // 
            // imagenPokemon
            // 
            this.imagenPokemon.Location = new System.Drawing.Point(390, 6);
            this.imagenPokemon.Name = "imagenPokemon";
            this.imagenPokemon.Size = new System.Drawing.Size(109, 125);
            this.imagenPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPokemon.TabIndex = 1;
            this.imagenPokemon.TabStop = false;
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokedex2.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 424);
            this.Controls.Add(this.evolucion2);
            this.Controls.Add(this.evolucion);
            this.Controls.Add(this.imagenPokemon);
            this.Controls.Add(this.cajaDescripcion);
            this.Name = "Ventana2";
            this.Text = "Form1";
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
    }
}