using CatalogoLibros.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CatalogoLibros.ClienteBlazor.Services
{
    public interface IGeneroService
    {
        Task<IEnumerable<Genero>> GetAll();


    }
}
