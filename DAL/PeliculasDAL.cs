using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODN;

namespace DAL
{
    public class PeliculasDAL
    {
        private static PeliculasEntities contexto = new PeliculasEntities();

        //public static List<Peliculas> PeliculaById(int IdPelicula)
        //{
        //    var res = new List<Peliculas>();
        //    res = contexto.Peliculas.Join(contexto.Datos_Pelicula,
        //        x => x.Id,
        //        y => y.Id_Pelicula,
        //        ( x, y ) => new { x, y })
        //        .Join(contexto.Reparto_Pelicula,
        //        dp => dp.y.Id,
        //        rp => rp.Id_Datos_Pelicula,
        //        ( dp, rp )=> new {dp,rp})
        //        .Where(o => o.dp.x.Id == IdPelicula && o.dp.y.Id_Pelicula == IdPelicula && o.rp.Id_Datos_Pelicula == o.dp.y.Id).Select(o => o.dp.x).ToList();
        //    return res;
        //}
        public static Peliculas PeliculaById(int IdPelicula)
        {
            var res = new List<Peliculas>();
            res = contexto.Peliculas.Where(x => x.Id == IdPelicula).ToList();
            return res[0];
        }
        public static List<Peliculas> PeliculasByNombre(string NombrePelicula)
        {
            var res = new List<Peliculas>();
            res = contexto.Peliculas.Where(x => x.Nombre.Contains(NombrePelicula)).ToList();
            return res;
        }
        public static List<Peliculas> PeliculasById(int[] IdPeliculas)
        {
            var res = new List<Peliculas>();
            res = contexto.Peliculas.Where(x => IdPeliculas.Contains(x.Id)).ToList();
            return res;
        }
        public static List<Peliculas> PeliculasIdReversed()
        {
            var res = new List<Peliculas>();
            res = contexto.Peliculas.OrderByDescending(x => x.Id).ToList();
            return res;
        }

        public static bool Add(Peliculas Pelicula)
        {
            var res = false;
            contexto.Peliculas.Add(Pelicula);
            var x = contexto.SaveChanges();
            if (x > 0) { res = true; }
            return res;
        }
        public static bool Delete(int ID)
        {
            var res = false;
            List<Peliculas> lista = contexto.Peliculas.Where(x => x.Id == ID).ToList();
            if (lista.Count > 0)
            {
                contexto.Peliculas.Remove(lista[0]);
                var x = contexto.SaveChanges();
                if (x > 0) { res = true; }
            }
            return res;
        }
        public static bool Update(Peliculas Pelicula)
        {
            var res = false;
            Peliculas movie = PeliculaById(Pelicula.Id);
            if (movie == null)
            {
                return res;
            }
            movie = UpdateMovie(movie, Pelicula);
            var x = contexto.SaveChanges();
            if (x > 0) { res = true; }
            return res;
        }
        public static Peliculas UpdateMovie(Peliculas movie, Peliculas Pelicula)
        {
            movie.Clasificacion = Pelicula.Clasificacion;
            movie.Duracion = Pelicula.Duracion;
            movie.Fecha_Salida = Pelicula.Fecha_Salida;
            movie.Generos = Pelicula.Generos;
            movie.Nombre = Pelicula.Nombre;
            movie.Poster = Pelicula.Poster;
            movie.Puntuacion_IMDB = Pelicula.Puntuacion_IMDB;
            movie.Datos_Pelicula.ToList()[0].Descripcion = Pelicula.Datos_Pelicula.ToList()[0].Descripcion;
            movie.Datos_Pelicula.ToList()[0].Opinion_Usuario = Pelicula.Datos_Pelicula.ToList()[0].Opinion_Usuario;
            movie.Datos_Pelicula.ToList()[0].Puntuacion_Usuario = Pelicula.Datos_Pelicula.ToList()[0].Puntuacion_Usuario;
            movie.Datos_Pelicula.ToList()[0].Reparto_Pelicula = Pelicula.Datos_Pelicula.ToList()[0].Reparto_Pelicula;
            movie.Datos_Pelicula.ToList()[0].Trailer = Pelicula.Datos_Pelicula.ToList()[0].Trailer;
            movie.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Actores = Pelicula.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Actores;
            movie.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Direccion = Pelicula.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Direccion;
            movie.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Guion = Pelicula.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Guion;
            movie.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Personajes = Pelicula.Datos_Pelicula.ToList()[0].Reparto_Pelicula.ToList()[0].Personajes;
            return movie;
        }
    }
}
