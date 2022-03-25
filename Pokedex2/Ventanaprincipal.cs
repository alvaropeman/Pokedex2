using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokedex2022_CSharp;

namespace Pokedex2
{
    public partial class Ventanaprincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        DataTable misPokemons2 = new DataTable();
        DataTable misPokemons3 = new DataTable();
        DataTable misPokemons4 = new DataTable();
        DataTable misPokemons5 = new DataTable();
        int idActual = 1;
        int idAnterior = 0;
        int idSiguiente = 2;
        
        int encender = 0;
        
        public Ventanaprincipal()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            Application.Exit();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }







        private void button3_Click(object sender, EventArgs e)
        {
            if (encender >= 1)
            {
                idActual--;
                idAnterior--;
                idSiguiente--;


                if (idActual <= 0) { idActual = 151; }
                if (idSiguiente<= 0) { idSiguiente = 151; }
                if (idAnterior <= 0) { idAnterior = 151; }

                misPokemons = miConexion.getPokemonPorId(idActual);
                misPokemons2 = miConexion.getPreEvolucionPorId(idActual);
                misPokemons3 = miConexion.getPosEvolucionPorId(idActual);
                misPokemons4 = miConexion.getPreEvolucionPorId(idAnterior);
                misPokemons5 = miConexion.getPosEvolucionPorId(idSiguiente);

                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox2.Image = convierteBlobAImagen((Byte[])misPokemons.Rows[0]["imagen"]);
                if (misPokemons.Rows[0]["preEvolucion"].ToString() != "")
                {
                    preEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons2.Rows[0]["imagen"]);
                }
                else if(misPokemons.Rows[0]["posEvolucion"].ToString() != "" && misPokemons3.Rows[0]["posEvolucion"].ToString() != "")
                {
                    preEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons5.Rows[0]["imagen"]);
                }
                else
                {
                    preEvolucion.Image = null;
                }
                if (misPokemons.Rows[0]["posEvolucion"].ToString() != "")
                {
                    posEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons3.Rows[0]["imagen"]);
                }
                else if (misPokemons.Rows[0]["preEvolucion"].ToString() != "" && misPokemons2.Rows[0]["preEvolucion"].ToString() != "")
                {
                    posEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons4.Rows[0]["imagen"]);
                }
                else
                {
                    posEvolucion.Image = null;
                }
            }


        }

        private void Ventanaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void boton_der_Click(object sender, EventArgs e)
        {
            if (encender >= 1)
            {
                idActual++;
                idSiguiente++;
                idAnterior++;

                if (idActual > 151) { idActual = 1; }
                if (idAnterior > 151) { idAnterior = 1; }
                if (idSiguiente > 151) { idSiguiente = 1; }

                misPokemons = miConexion.getPokemonPorId(idActual);
                misPokemons2 = miConexion.getPreEvolucionPorId(idActual);
                misPokemons3 = miConexion.getPosEvolucionPorId(idActual);
                misPokemons4 = miConexion.getPreEvolucionPorId(idAnterior);
                misPokemons5 = miConexion.getPosEvolucionPorId(idSiguiente);

                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox2.Image = convierteBlobAImagen((Byte[])misPokemons.Rows[0]["imagen"]);
                if (misPokemons.Rows[0]["preEvolucion"].ToString() != "")
                {
                    preEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons2.Rows[0]["imagen"]);
                }
               else if (misPokemons.Rows[0]["posEvolucion"].ToString() != "" && misPokemons3.Rows[0]["posEvolucion"].ToString() != "")
                {
                  preEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons5.Rows[0]["imagen"]);
               }
                else
                {
                    preEvolucion.Image = null;
                }
                if (misPokemons.Rows[0]["posEvolucion"].ToString() != "")
                {
                    posEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons3.Rows[0]["imagen"]);
                }
                else if (misPokemons.Rows[0]["preEvolucion"].ToString() != "" && misPokemons2.Rows[0]["preEvolucion"].ToString() != "")
                {
                    posEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons4.Rows[0]["imagen"]);
               }
                else
                {
                    posEvolucion.Image = null;
                }


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click_2(object sender, EventArgs e)
        {
            if (encender >= 1)
            {
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            }
        }

        private void fisicoPokemon_Click(object sender, EventArgs e)
        {
            if (encender >= 1)
            {
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString() + "pesa " + misPokemons.Rows[0]["peso"].ToString() + "  y mide" + misPokemons.Rows[0]["altura"].ToString();
            }
        }

        private void tipoEspecie_Click(object sender, EventArgs e)
        {
            if (encender >= 1)
            {

                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString() + "es de la especie " + misPokemons.Rows[0]["especie"].ToString() + " y tipo " + misPokemons.Rows[0]["tipo2"].ToString() + ", " + misPokemons.Rows[0]["tipo1"].ToString();
            }
        }

        private void movimmientos_Click(object sender, EventArgs e)
        {
            if (encender >= 1)
            {
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString() + " posee los movimientos" + misPokemons.Rows[0]["movimiento1"].ToString() + ", " + misPokemons.Rows[0]["movimiento2"].ToString() + ", " + misPokemons.Rows[0]["movimiento3"].ToString() + ", " + misPokemons.Rows[0]["movimiento4"].ToString() + " y posee la habilidad " + misPokemons.Rows[0]["habilidad"].ToString();
            }
        }

        private void Habitad_Click(object sender, EventArgs e)
        {
            if (encender >= 1)
            {
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString() + " habita en " + misPokemons.Rows[0]["habitat"].ToString();
            }
        }

        private void descripcion_Click(object sender, EventArgs e)
        { if (encender >= 1) {
                
            Ventana2 ventana = new Ventana2();
            
            ventana.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString());
            ventana.habilidad(misPokemons.Rows[0]["habilidad"].ToString());
            ventana.perfil("tipo/ " + misPokemons.Rows[0]["tipo1"].ToString() + " " + misPokemons.Rows[0]["tipo2"].ToString());
                ventana.imagenPokimon(convierteBlobAImagen((Byte[])misPokemons.Rows[0]["imagen"]));
            if(misPokemons.Rows[0]["posEvolucion"].ToString() != "")
                {
                    ventana.imagenEvolucion(convierteBlobAImagen((Byte[])misPokemons3.Rows[0]["imagen"]));
                }
                else if (misPokemons.Rows[0]["preEvolucion"].ToString() != "" && misPokemons2.Rows[0]["preEvolucion"].ToString() != "")
                {
                    ventana.imagenEvolucion(convierteBlobAImagen((Byte[])misPokemons4.Rows[0]["imagen"]));
                }
           

                if (misPokemons.Rows[0]["preEvolucion"].ToString() != "")
            {
                ventana.imagenEvolucion2(convierteBlobAImagen((Byte[])misPokemons2.Rows[0]["imagen"]));
            }
                else if (misPokemons.Rows[0]["posEvolucion"].ToString() != "" && misPokemons3.Rows[0]["posEvolucion"].ToString() != "")
                {
                    ventana.imagenEvolucion2(convierteBlobAImagen((Byte[])misPokemons5.Rows[0]["imagen"]));
                }


                this.Hide();
                ventana.Show();
                
            
        }}

        private void evolucion_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            encender++;
            idActual = 1;
            idAnterior = 0;
            idSiguiente = 2;
            
            

            misPokemons = miConexion.getPokemonPorId(idActual);
            misPokemons2 = miConexion.getPreEvolucionPorId(idActual);
            misPokemons3 = miConexion.getPosEvolucionPorId(idActual);
            misPokemons5 = miConexion.getPosEvolucionPorId(idSiguiente);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox2.Image = convierteBlobAImagen((Byte[])misPokemons.Rows[0]["imagen"]);
            
            preEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons5.Rows[0]["imagen"]);
           
          
           
            if (misPokemons.Rows[0]["posEvolucion"].ToString() != "")
            {
                posEvolucion.Image = convierteBlobAImagen((Byte[])misPokemons3.Rows[0]["imagen"]);
            }
           
            else
            {
                posEvolucion.Image = null;
            }
        }
    }
}
