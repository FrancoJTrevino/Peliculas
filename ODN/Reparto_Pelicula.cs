//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODN
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reparto_Pelicula
    {
        public int Id { get; set; }
        public Nullable<int> Id_Datos_Pelicula { get; set; }
        public string Direccion { get; set; }
        public string Guion { get; set; }
        public string Actores { get; set; }
        public string Personajes { get; set; }
    
        public virtual Datos_Pelicula Datos_Pelicula { get; set; }
    }
}
