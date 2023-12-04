using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Peliculas
{
    public partial class FormListaPeliculas : Form
    {
        public FormListaPeliculas()
        {
            InitializeComponent();
        }

        private void FormListaPeliculas_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var Nombre = txtSearch.Text;
            var ListaPeliculas = PeliculasBLL.PeliculasByNombre(Nombre);
            CargarLinks(ListaPeliculas);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new FormAgregar();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void ClickLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Label = (LinkLabel)sender;
            string NombrePelicula = Label.Text;
            SelecPelicula(NombrePelicula);
        }

        private void ClickImagen(object sender, EventArgs e)
        {
            var PictureBox = (PictureBox)sender;
            var pbNombre = PictureBox.Name;
            var NombrePelicula = "";

            switch (pbNombre)
            {
                case "pb1":
                    NombrePelicula = lb1.Text;
                    break;
                case "pb2":
                    NombrePelicula = lb2.Text;
                    break;
                case "pb3":
                    NombrePelicula = lb3.Text;
                    break;
                case "pb4":
                    NombrePelicula = lb4.Text;
                    break;
                case "pb5":
                    NombrePelicula = lb5.Text;
                    break;
                case "pb6":
                    NombrePelicula = lb6.Text;
                    break;
                case "pb7":
                    NombrePelicula = lb7.Text;
                    break;
                case "pb8":
                    NombrePelicula = lb8.Text;
                    break;
                case "pb9":
                    NombrePelicula = lb9.Text;
                    break;
                case "pb10":
                    NombrePelicula = lb10.Text;
                    break;
            }

            SelecPelicula(NombrePelicula);
        }

        private void CargarLinks(List<ODN.Peliculas> ListaPeliculas)
        {
            if (ListaPeliculas.Count == 0)
            {
                lb1.Text = lb2.Text = lb3.Text = lb4.Text = lb5.Text = lb6.Text = lb7.Text = lb8.Text = lb9.Text = lb10.Text = "";
                pb1.Image = pb2.Image = pb3.Image = pb4.Image = pb5.Image = pb6.Image = pb7.Image = pb8.Image = pb9.Image = pb10.Image = null;
            }

            for (int i = 0; i < ListaPeliculas.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        lb1.Text = ListaPeliculas[i].Nombre;
                        pb1.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb1.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 1:
                        lb2.Text = ListaPeliculas[i].Nombre;
                        pb2.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        lb3.Text = ListaPeliculas[i].Nombre;
                        pb3.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb3.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        lb4.Text = ListaPeliculas[i].Nombre;
                        pb4.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb4.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 4:
                        lb5.Text = ListaPeliculas[i].Nombre;
                        pb5.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb5.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 5:
                        lb6.Text = ListaPeliculas[i].Nombre;
                        pb6.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb6.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 6:
                        lb7.Text = ListaPeliculas[i].Nombre;
                        pb7.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb7.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 7:
                        lb8.Text = ListaPeliculas[i].Nombre;
                        pb8.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb8.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 8:
                        lb9.Text = ListaPeliculas[i].Nombre;
                        pb9.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb9.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 9:
                        lb10.Text = ListaPeliculas[i].Nombre;
                        pb10.LoadAsync(@"" + ListaPeliculas[i].Poster + "");
                        pb10.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
            }
        }

        private void SelecPelicula(string NombrePelicula)
        {
            if (NombrePelicula == "")
            {
                MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var form = new FormPelicula(NombrePelicula);
                form.ShowDialog();
            }
        }

        private void ActualizarLista()
        {
            var ListaPeliculas = PeliculasBLL.PeliculasIdReversed();
            CargarLinks(ListaPeliculas);
        }


    }
}
