using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;

namespace Peliculas
{
    public partial class FormBuscarIMDB : Form
    {
        List<JsonByName.MovieResult> _listaPeliculas = new List<JsonByName.MovieResult>();
        JsonByName.Root _listbyName = new JsonByName.Root();
        JsonByID.Root _listbyID = new JsonByID.Root();
        JsonImage.Root _movieposter = new JsonImage.Root();
        public FormBuscarIMDB()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await CallAPIbyName(txtSearch.Text);
            GridPeliculas.DataSource = null;
            GridPeliculas.DataSource = _listaPeliculas;
            GridPeliculas.Columns["title"].HeaderText = "Película";
            GridPeliculas.Columns["title"].Width = 335;
            GridPeliculas.Columns["year"].HeaderText = "Año de estreno";
            GridPeliculas.Columns["imdb_id"].Visible = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, new EventArgs());
            }
        }
        private async void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GridPeliculas.SelectedCells.Count == 1)
            {
                string imdb_id = GridPeliculas.Rows[GridPeliculas.SelectedCells[0].RowIndex].Cells[2].Value.ToString();
                await CallAPIbyID(imdb_id);
                var form = new FormAgregarPelicula(_listbyID, _movieposter);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Close();
            }
            else if (GridPeliculas.SelectedCells.Count > 1)
            {
                MessageBox.Show("Solo puede seleccionar una pelicula para añadir a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Seleccione al menos una película para añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async Task CallAPIbyName(string nombrePelicula)
        {
            var form = new FormWait();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            _listaPeliculas.Clear();
            string body;
            nombrePelicula = nombrePelicula.Replace(" ", "%20");
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://movies-tv-shows-database.p.rapidapi.com/?title=" + nombrePelicula),
                Headers =
                {
                    { "Type", "get-movies-by-title" },
                    { "X-RapidAPI-Key", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" },
                    { "X-RapidAPI-Host", "movies-tv-shows-database.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            _listbyName = JsonConvert.DeserializeObject<JsonByName.Root>(body);
            for (int i = 0; i < _listbyName.movie_results.Count; i++)
            {
                if (_listbyName.movie_results[i].title != "") { _listaPeliculas.Add(_listbyName.movie_results[i]); }
            }
            form.Close();
        }

        private async Task CallAPIbyID(string ID)
        {
            string body;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://movies-tv-shows-database.p.rapidapi.com/?movieid=" + ID + ""),
                Headers =
                {
                    { "Type", "get-movie-details" },
                    { "X-RapidAPI-Key", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" },
                    { "X-RapidAPI-Host", "movies-tv-shows-database.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            _listbyID = JsonConvert.DeserializeObject<JsonByID.Root>(body);

            request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://movies-tv-shows-database.p.rapidapi.com/?movieid=" + ID + ""),
                Headers =
                {
                    { "Type", "get-movies-images-by-imdb" },
                    { "X-RapidAPI-Key", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" },
                    { "X-RapidAPI-Host", "movies-tv-shows-database.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
            }
            _movieposter = JsonConvert.DeserializeObject<JsonImage.Root>(body);
        }
    }
}
