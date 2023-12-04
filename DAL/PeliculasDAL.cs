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
            var movie = PeliculaById(Pelicula.Id);
            movie = Pelicula;
            var x = contexto.SaveChanges();
            if (x > 0) { res = true; }
            return res;
        }
    }
}
