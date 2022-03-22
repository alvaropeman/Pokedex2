using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class Ventana2 : Form
    {
        public void cambiaDescripcionPokemon(String descripcion)
        {
            cajaDescripcion.Text = descripcion;
        }
      

        public Ventana2()
        {
            InitializeComponent();

        }

        internal void imagenPokimon(Image image)
        {
            imagenPokemon.Image =image;
        }
        internal void imagenEvolucion(Image image)
        {
            evolucion.Image = image;
        }
        internal void imagenEvolucion2(Image image)
        {
            evolucion2.Image = image;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void evolucion_Click(object sender, EventArgs e)
        {

        }
    }
}