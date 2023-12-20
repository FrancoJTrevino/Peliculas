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
        ODN.Peliculas _pelicula = new ODN.Peliculas();
        string _error = "";

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
            if (_IdPelicula != 0)
            {
                _pelicula = GetPeliculaById(_IdPelicula);
                ActualizarDatos(_pelicula);
            }
            else if (_NombrePelicula != "")
            {
                _pelicula = GetPeliculaByNombre(_NombrePelicula);
                ActualizarDatos(_pelicula);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarPelicula(_pelicula);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            this.Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar ésta pelicula?", "Advertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var res = PeliculasBLL.Delete(_pelicula.Id);
            if (res)
            {
                MessageBox.Show("La película se ha eliminado correctamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pbStar1_MouseHover(object sender, EventArgs e)
        {
            var tooltip = new ToolTip();
            tooltip.SetToolTip(pbStar1, lblPuntuacionIMDB.Text);
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
            scaleFont(lblTitulo);
            lblClasificacion.Text = Pelicula.Clasificacion;
            lblDescripcion.Text = Datos.Descripcion;
            lblDuración.Text = Pelicula.Duracion / 60 + "h " + Pelicula.Duracion % 60 + "m";
            lblFecha.Text = Convert.ToDateTime(Pelicula.Fecha_Salida).Year.ToString();
            lblGeneros.Text = Pelicula.Generos.Replace(",", " -");
            lblPuntuacionIMDB.Text = Pelicula.Puntuacion_IMDB.Trim();
            AsignarEstrellasIMDB(Convert.ToDouble(Pelicula.Puntuacion_IMDB.Trim()));

            ActualizarReparto(Personajes, Direccion, Guion, Actores);

            pbPoster.LoadAsync(@"" + Pelicula.Poster + "");
            pbPoster.SizeMode = PictureBoxSizeMode.Zoom;

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}/?iv_load_policy=3&modestbranding=1&showinfo=0&rel=0&autoplay=0' width='470' height='249' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.wbTrailer.DocumentText = string.Format(html, Datos.Trailer.Split('=')[1]);

            lblOpinion.Text = Datos.Opinion_Usuario;
            lblPuntuacionUsuario.Text = Datos.Puntuacion_Usuario.Trim();
            if (lblPuntuacionUsuario.Text != "")
            {
                AsignarEstrellasUser(Convert.ToDouble(Datos.Puntuacion_Usuario.Trim()));
            }
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
        private void AsignarEstrellasIMDB(double Puntuacion)
        {
            int posicion = 0;
            int dec = Convert.ToInt32((Puntuacion * 10) % 10);
            List<Bitmap> imagenes = new List<Bitmap>();
            imagenes = AsignarImagenes(imagenes);
            for (int i = 0; i < Puntuacion; i++)
            {
                switch (Puntuacion)
                {
                    case var x when Puntuacion < 1:
                        posicion = 0;
                        break;
                    case var x when Puntuacion >= 1 && posicion < 1:
                        pbStar1.Image = imagenes[10];
                        posicion = 1;
                        break;
                    case var x when Puntuacion >= 2 && posicion < 2:
                        pbStar2.Image = imagenes[10];
                        posicion = 2;
                        break;
                    case var x when Puntuacion >= 3 && posicion < 3:
                        pbStar3.Image = imagenes[10];
                        posicion = 3;
                        break;
                    case var x when Puntuacion >= 4 && posicion < 4:
                        pbStar4.Image = imagenes[10];
                        posicion = 4;
                        break;
                    case var x when Puntuacion >= 5 && posicion < 5:
                        pbStar5.Image = imagenes[10];
                        posicion = 5;
                        break;
                    case var x when Puntuacion >= 6 && posicion < 6:
                        pbStar6.Image = imagenes[10];
                        posicion = 6;
                        break;
                    case var x when Puntuacion >= 7 && posicion < 7:
                        pbStar7.Image = imagenes[10];
                        posicion = 7;
                        break;
                    case var x when Puntuacion >= 8 && posicion < 8:
                        pbStar8.Image = imagenes[10];
                        posicion = 8;
                        break;
                    case var x when Puntuacion >= 9 && posicion < 9:
                        pbStar9.Image = imagenes[10];
                        posicion = 9;
                        break;
                    case var x when Puntuacion == 10:
                        pbStar10.Image = imagenes[10];
                        posicion = 10;
                        break;
                }
            }
            switch (posicion)
            {
                case 0:
                    pbStar1.Image = imagenes[dec];
                    break;
                case 1:
                    pbStar2.Image = imagenes[dec];
                    break;
                case 2:
                    pbStar3.Image = imagenes[dec];
                    break;
                case 3:
                    pbStar4.Image = imagenes[dec];
                    break;
                case 4:
                    pbStar5.Image = imagenes[dec];
                    break;
                case 5:
                    pbStar6.Image = imagenes[dec];
                    break;
                case 6:
                    pbStar7.Image = imagenes[dec];
                    break;
                case 7:
                    pbStar8.Image = imagenes[dec];
                    break;
                case 8:
                    pbStar9.Image = imagenes[dec];
                    break;
                case 9:
                    pbStar10.Image = imagenes[dec];
                    break;
            }
        }
        private void AsignarEstrellasUser(double Puntuacion)
        {
            int posicion = 0;
            int dec = Convert.ToInt32((Puntuacion * 10) % 10);
            List<Bitmap> imagenes = new List<Bitmap>();
            imagenes = AsignarImagenes(imagenes);
            for (int i = 0; i < Puntuacion; i++)
            {
                switch (Puntuacion)
                {
                    case var x when Puntuacion < 1:
                        posicion = 0;
                        break;
                    case var x when Puntuacion >= 1 && posicion < 1:
                        pbStar11.Image = imagenes[10];
                        posicion = 1;
                        break;
                    case var x when Puntuacion >= 2 && posicion < 2:
                        pbStar12.Image = imagenes[10];
                        posicion = 2;
                        break;
                    case var x when Puntuacion >= 3 && posicion < 3:
                        pbStar13.Image = imagenes[10];
                        posicion = 3;
                        break;
                    case var x when Puntuacion >= 4 && posicion < 4:
                        pbStar14.Image = imagenes[10];
                        posicion = 4;
                        break;
                    case var x when Puntuacion >= 5 && posicion < 5:
                        pbStar15.Image = imagenes[10];
                        posicion = 5;
                        break;
                    case var x when Puntuacion >= 6 && posicion < 6:
                        pbStar16.Image = imagenes[10];
                        posicion = 6;
                        break;
                    case var x when Puntuacion >= 7 && posicion < 7:
                        pbStar17.Image = imagenes[10];
                        posicion = 7;
                        break;
                    case var x when Puntuacion >= 8 && posicion < 8:
                        pbStar18.Image = imagenes[10];
                        posicion = 8;
                        break;
                    case var x when Puntuacion >= 9 && posicion < 9:
                        pbStar19.Image = imagenes[10];
                        posicion = 9;
                        break;
                    case var x when Puntuacion == 10:
                        pbStar20.Image = imagenes[10];
                        posicion = 10;
                        break;
                }
            }
            switch (posicion)
            {
                case 0:
                    pbStar11.Image = imagenes[dec];
                    break;
                case 1:
                    pbStar12.Image = imagenes[dec];
                    break;
                case 2:
                    pbStar13.Image = imagenes[dec];
                    break;
                case 3:
                    pbStar14.Image = imagenes[dec];
                    break;
                case 4:
                    pbStar15.Image = imagenes[dec];
                    break;
                case 5:
                    pbStar16.Image = imagenes[dec];
                    break;
                case 6:
                    pbStar17.Image = imagenes[dec];
                    break;
                case 7:
                    pbStar18.Image = imagenes[dec];
                    break;
                case 8:
                    pbStar19.Image = imagenes[dec];
                    break;
                case 9:
                    pbStar20.Image = imagenes[dec];
                    break;
            }
        }
        public static List<Bitmap> AsignarImagenes(List<Bitmap> imagenes)
        {
            imagenes.Add(Properties.Resources.Star0);
            imagenes.Add(Properties.Resources.Star1);
            imagenes.Add(Properties.Resources.Star2);
            imagenes.Add(Properties.Resources.Star3);
            imagenes.Add(Properties.Resources.Star4);
            imagenes.Add(Properties.Resources.Star5);
            imagenes.Add(Properties.Resources.Star6);
            imagenes.Add(Properties.Resources.Star7);
            imagenes.Add(Properties.Resources.Star8);
            imagenes.Add(Properties.Resources.Star9);
            imagenes.Add(Properties.Resources.Star10);
            return imagenes;
        }
        private void scaleFont(Label lab)
        {
            Image fakeImage = new Bitmap(1, 1);
            Graphics graphics = Graphics.FromImage(fakeImage);

            SizeF extent = graphics.MeasureString(lab.Text, lab.Font);

            float hRatio = lab.Height / extent.Height;
            float wRatio = lab.Width / extent.Width;
            float ratio = (hRatio < wRatio) ? hRatio : wRatio;

            float newSize = lab.Font.Size * ratio;

            lab.Font = new Font(lab.Font.FontFamily, newSize, lab.Font.Style);
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
