using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex2;

namespace Pokedex2022_CSharp
{
    public partial class Ventana2 : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
       

        public Ventana2()
        {
            InitializeComponent();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            Application.Exit();
        }
        internal void cambiaDescripcionPokemon(String descripcion)
        {
            cajaDescripcion.Text = descripcion;
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
        internal void habilidad(String descripcion)
        {
            habilidades.Text = descripcion;

        }
        internal void perfil(String descripcion)
        {
            tipo.Text = descripcion;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void evolucion_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventanaprincipal v = new Ventanaprincipal();
            this.Hide();
            v.Show();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }
    }
}