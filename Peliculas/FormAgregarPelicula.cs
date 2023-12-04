using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODN;
using BLL;

namespace Peliculas
{
    public partial class FormAgregarPelicula : Form
    {
        JsonByID.Root _pelicula = new JsonByID.Root();
        JsonImage.Root _poster = new JsonImage.Root();
        string _error = "";
        public FormAgregarPelicula()
        {
            InitializeComponent();
        }
        public FormAgregarPelicula(JsonByID.Root pelicula, JsonImage.Root poster)
        {
            InitializeComponent();
            _pelicula = pelicula;
            _poster = poster;
        }
        private void FormAgregarPelicula_Load(object sender, EventArgs e)
        {
            if (_pelicula.imdb_id != null)
            {
                txtTitulo.Text = _pelicula.title;
                txtDescripcion.Text = _pelicula.description;
                dtFechaSalida.Value = Convert.ToDateTime(_pelicula.release_date);
                txtHours.Text = (_pelicula.runtime / 60).ToString();
                txtMinutes.Text = (_pelicula.runtime % 60).ToString();
                txtPoster.Text = _poster.poster;
                txtIMDBRating.Text = _pelicula.imdb_rating;
                txtTrailer.Text = "https://www.youtube.com/watch?v=" + _pelicula.youtube_trailer_key;
                foreach (string x in _pelicula.genres) { if (txtGeneros.Text == "") { txtGeneros.Text += x; } else { txtGeneros.Text += ", " + x; } }
                foreach (string x in _pelicula.directors) { if (txtDireccion.Text == "") { txtDireccion.Text += x; } else { txtDireccion.Text += ", " + x; } }
                foreach (string x in _pelicula.stars) { if (txtActor.Text == "") { txtActor.Text += x; } else { txtActor.Text += ", " + x; } }
            }
        }

        private void btnCargarPoster_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files |*.jpg;*.jpeg;*.png";
            OFD.FilterIndex = 1;
            OFD.Multiselect = false;
            OFD.Title = "Por favor seleccione la imágen que desea subir";

            if (OFD.ShowDialog() == DialogResult.OK) { txtPoster.Text = OFD.FileName; }
        }

        private void btnCargarTrailer_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Video Files |*.mp4; *.avi; *.amv; *.mpeg; *.webm";
            OFD.FilterIndex = 1;
            OFD.Multiselect = false;
            OFD.Title = "Por favor seleccione el video que desea subir";

            if (OFD.ShowDialog() == DialogResult.OK) { txtTrailer.Text = OFD.FileName; }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!CheckTXT())
            {
                MessageBox.Show(_error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ODN.Peliculas Pelicula = RellenarPelicula();
            var res = PeliculasBLL.Add(Pelicula);
            if (res) 
            { 
                lblSuccess.Visible = true;
                lblClosing.Visible = true;
                int i = 3;
                while (i > 0)
                {
                    lblClosing.Text = "Cerrando formulario en " + i + "...";
                    i--;
                    System.Threading.Thread.Sleep(1000);
                }
                this.Close();
            } 
            else 
            { 
                lblError.Visible = true; 
                lnklblError.Visible = true;
            }
        }

        public ODN.Peliculas RellenarPelicula()
        {
            ODN.Peliculas Peliculas = new ODN.Peliculas();
            Datos_Pelicula Datos = new Datos_Pelicula();
            Reparto_Pelicula Reparto = new Reparto_Pelicula();

            Peliculas.Clasificacion = txtClasificacion.Text;
            Peliculas.Duracion = Convert.ToInt32(txtHours.Text) * 60 + Convert.ToInt32(txtMinutes.Text);
            Peliculas.Fecha_Salida = dtFechaSalida.Value;
            Peliculas.Generos = txtGeneros.Text;
            Peliculas.Nombre = txtTitulo.Text;
            Peliculas.Poster = txtPoster.Text;
            Peliculas.Puntuacion_IMDB = txtIMDBRating.Text;
            Datos.Descripcion = txtDescripcion.Text;
            Datos.Opinion_Usuario = txtUserOpinion.Text;
            Datos.Puntuacion_Usuario = txtUserRating.Text;
            Datos.Trailer = txtTrailer.Text;
            Reparto.Actores = txtActor.Text;
            Reparto.Direccion = txtDireccion.Text;
            Reparto.Guion = txtGuion.Text;
            Reparto.Personajes = txtPersonaje.Text;
            Datos.Reparto_Pelicula.Add(Reparto);
            Peliculas.Datos_Pelicula.Add(Datos);            

            return Peliculas;
        }

        private bool CheckTXT()
        {
            bool boolOK = false;
            List<string> ListTXT = new List<string>();
            ListTXT.AddRange(new List<string>
            {
                txtTitulo.Text,
                txtDescripcion.Text,
                txtClasificacion.Text,
                txtPoster.Text,
                txtGeneros.Text,
                txtIMDBRating.Text,
                txtTrailer.Text,
                txtDireccion.Text,
                txtActor.Text,
                txtPersonaje.Text
            });
            for (int i = 0; i < ListTXT.Count; i++)
            {
                if (ListTXT[i] == "")
                {
                    _error = "La película debe incluir ";
                    switch (i)
                    {
                        case 0:
                            _error += "un título";
                            break;
                        case 1:
                            _error += "un resumen";
                            break;
                        case 2:
                            _error += "una clasificación";
                            break;
                        case 3:
                            _error += "un poster";
                            break;
                        case 4:
                            _error += "al menos un género";
                            break;
                        case 5:
                            _error += "una puntuación de IMDB";
                            break;
                        case 6:
                            _error += "un trailer";
                            break;
                        case 7:
                            _error += "al menos un/a director/a";
                            break;
                        case 8:
                            _error += "al menos un/a actor/actriz";
                            break;
                        case 9:
                            _error += "al menos un personaje";
                            break;
                    }
                    return boolOK;
                }
                if (ListTXT[i].Length > 4 && i == 5)
                {
                    _error = "El campo Puntuación IMDB no puede superar los 4 caracteres";
                    return boolOK;
                } //IMDBRating
                if (ListTXT[i].Length > 10 && i == 2)
                {
                    _error = "El campo Clasificación no puede superar los 10 caracteres";
                    return boolOK;
                } //Clasificacion
                if (ListTXT[i].Length > 200 && i == 0)
                {
                    _error = "El campo Título no puede superar los 200 caracteres";
                    return boolOK;
                } //Titulo
                if (ListTXT[i].Length > 250 && (i == 3 || i == 4 || i == 6 || i == 7 || i == 8))
                {
                    string campo = "";
                    switch (i)
                    {
                        case 3:
                            campo += "Poster ";
                            break;
                        case 4:
                            campo += "Generos ";
                            break;
                        case 6:
                            campo += "Trailer ";
                            break;
                        case 7:
                            campo += "Dirección ";
                            break;
                        case 8:
                            campo += "Actores/Actrices ";
                            break;
                    }
                    _error = "El campo" + campo + "no puede superar los 250 caracteres";
                    return boolOK;
                } //Poster, Generos, Trailer, Direccion, Actor
                if (ListTXT[i].Length > 1000 && (i == 1 || i == 9))
                {
                    string campo = "";
                    switch (i)
                    {
                        case 1:
                            campo = "Resumen ";
                            break;
                        case 9:
                            campo = "Personajes ";
                            break;
                    }
                    _error = "El campo" + campo + "no puede superar los 1000 caracteres";
                    return boolOK;
                } //Descripcion, Personajes
            }
            boolOK = true;
            return boolOK;
        }

    }
}
