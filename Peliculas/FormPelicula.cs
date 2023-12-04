using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ODN;

namespace Peliculas
{
    public partial class FormPelicula : Form
    {
        int _IdPelicula = 0;
        string _NombrePelicula = "";

        public FormPelicula(int IdPelicula)
        {
            _IdPelicula = IdPelicula;
            InitializeComponent();
        }

        public FormPelicula(string NombrePelicula)
        {
            _NombrePelicula = NombrePelicula;
            InitializeComponent();
        }

        public FormPelicula()
        {
            InitializeComponent();
        }

        private void FormPelicula_Load(object sender, EventArgs e)
        {
            ODN.Peliculas Pelicula;

            if (_IdPelicula != 0)
            {
                Pelicula = GetPeliculaById(_IdPelicula);
            }
            else if (_NombrePelicula != "")
            {
                Pelicula = GetPeliculaByNombre(_NombrePelicula);
            }
            else
            {
                Pelicula = new ODN.Peliculas();
            }

            ActualizarDatos(Pelicula);
        }

        private void ActualizarDatos(ODN.Peliculas Pelicula)
        {
            Datos_Pelicula Datos = Pelicula.Datos_Pelicula.ToList()[0];
            Reparto_Pelicula Reparto = Datos.Reparto_Pelicula.ToList()[0];

            string[] Personajes = Reparto.Personajes.Split(',');
            string[] Direccion = Reparto.Direccion.Split(',');
            string[] Guion = Reparto.Guion.Split(',');
            string[] Actores = Reparto.Actores.Split(',');

            lblTitulo.Text = Pelicula.Nombre;
            lblClasificacion.Text = Pelicula.Clasificacion;
            lblDescripcion.Text = Datos.Descripcion;
            lblDuración.Text = Pelicula.Duracion / 60 + "h " + Pelicula.Duracion % 60 + "m";
            lblFecha.Text = Convert.ToDateTime(Pelicula.Fecha_Salida).Year.ToString();
            lblGeneros.Text = Pelicula.Generos.Replace(",", " -");
            lblPuntuacionIMDB.Text = Pelicula.Puntuacion_IMDB;

            ActualizarReparto(Personajes, Direccion, Guion, Actores);

            pbPoster.LoadAsync(@"" + Pelicula.Poster + "");
            pbPoster.SizeMode = PictureBoxSizeMode.Zoom;

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}/?iv_load_policy=3&modestbranding=1&showinfo=0&rel=0&autoplay=0' width='470' height='249' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.wbTrailer.DocumentText = string.Format(html, Datos.Trailer.Split('=')[1]);

            lblOpinion.Text = Datos.Opinion_Usuario;
            lblPuntuacionUsuario.Text = Datos.Puntuacion_Usuario;
            this.Text = Pelicula.Nombre;
        }
        private void ActualizarReparto(string[] Personajes, string[] Direccion, string[] Guion, string[] Actores)
        {
            for (int i = 0; i < Personajes.Length; i++)
            {
                lblReparto.Text += "\n     * " + Personajes[i].Trim();
            }
            lblReparto.Text += "\n\nDirección:";
            for (int i = 0; i < Direccion.Length; i++)
            {
                lblReparto.Text += "\n     * " + Direccion[i].Trim();
            }
            lblReparto.Text += "\n\nGuión:";
            for (int i = 0; i < Guion.Length; i++)
            {
                lblReparto.Text += "\n     * " + Guion[i].Trim();
            }
            lblReparto.Text += "\n\nActores:";
            for (int i = 0; i < Actores.Length; i++)
            {
                lblReparto.Text += "\n     * " + Actores[i].Trim();
            }
        }
        public static ODN.Peliculas GetPeliculaById(int Id)
        {
            ODN.Peliculas Pelicula = PeliculasBLL.PeliculaById(Id);
            return Pelicula;
        }
        public static ODN.Peliculas GetPeliculaByNombre(string Nombre)
        {
            ODN.Peliculas Pelicula = PeliculasBLL.PeliculasByNombre(Nombre).ToList()[0];
            return Pelicula;
        }
    }
}
