using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoLibros.ClienteBlazor.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public int IdAutor { get; set; }
        public int IdCategoria { get; set; }
        public int IdGenero { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public int NumPaginas { get; set; }
        public string FechaPublicacion { get; set; }
        public string Descripcion { get; set; }

       
    }
}
