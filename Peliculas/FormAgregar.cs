using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = "Esta opción permite al usuario añadir una pelicula directo desde la base de datos de IMDB \n\nSe puede editar antes de añadir la pelicula definitivamente.";
        }

        private void btnManual_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.Text == "Añadir Manualmente")
            {
                lblDescripcion.Text = "Esta opción permite al usuario añadir una pelicula desde cero en todos los aspectos, título, poster, rating, etc. \n\nSe recomienda utilizar si es que la opción automática no trae la película deseada.";
            }
            else
            {
                lblDescripcion.Text = "Esta opción permite al usuario añadir una pelicula directo desde la base de datos de IMDB \n\nSe puede editar antes de añadir la pelicula definitivamente.";
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            var form = new FormAgregarPelicula();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            var form = new FormBuscarIMDB();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
