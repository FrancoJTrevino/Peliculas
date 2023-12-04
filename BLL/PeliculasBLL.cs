using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODN;
using DAL;

namespace BLL
{
    public class PeliculasBLL
    {
        public static Peliculas PeliculaById(int IdPelicula)
        {
            var res = new Peliculas();
            res = PeliculasDAL.PeliculaById(IdPelicula);
            return res;
        }
        public static List<Peliculas> PeliculasByNombre(string NombrePelicula)
        {
            var res = new List<Peliculas>();
            res = PeliculasDAL.PeliculasByNombre(NombrePelicula);
            return res;
        }
        public static List<Peliculas> PeliculasById(int[] IdPeliculas)
        {
            var res = new List<Peliculas>();
            res = PeliculasDAL.PeliculasById(IdPeliculas);
            return res;
        }
        public static List<Peliculas> PeliculasIdReversed()
        {
            var res = new List<Peliculas>();
            res = PeliculasDAL.PeliculasIdReversed();
            return res;
        }

        public static bool Add(Peliculas Pelicula)
        {
            var res = false;
            res = PeliculasDAL.Add(Pelicula);
            return res;
        }

        public static bool Delete(int ID)
        {
            var res = false;
            res = PeliculasDAL.Delete(ID);
            return res;
        }

        public static bool Update(Peliculas Pelicula)
        {
            var res = false;
            res = PeliculasDAL.Update(Pelicula);
            return res;
        }
    }
}
