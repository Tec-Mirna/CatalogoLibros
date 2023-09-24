using CatalogoLibros.ClienteBlazor.Models;

namespace CatalogoLibros.ClienteBlazor.Services
{
    public interface IAutorService
    {
        Task<IEnumerable<Autor>> GetAll();
    }
}
