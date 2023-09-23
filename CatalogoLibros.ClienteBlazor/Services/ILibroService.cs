using CatalogoLibros.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoLibros.ClienteBlazor.Services
{
    public interface ILibroService
    {
        Task<IEnumerable<Libro>> GetAll();
        Task<IEnumerable<Libro>> GetByAutor(int idLibro);
        Task<IEnumerable<Libro>> GetByCategoria(int idLibro);
        Task<IEnumerable<Libro>> GetByGenero(int idLibro);
        Task<Libro> GetById(int id);
    }
}
