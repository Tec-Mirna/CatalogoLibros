using CatalogoLibros.ClienteBlazor.Models;
using System.Text.Json;

using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace CatalogoLibros.ClienteBlazor.Services
{
    public class AutorService : IAutorService
    {
        //Inyección de dependencias de HttpClient
        private readonly HttpClient _httpClient;
        public AutorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Autor>> GetAll()
        {                                           //Le decimos al serializador que procese los nombre de las propiedades sin importar si son mayúsculas o no.
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Autor");
            return JsonSerializer.Deserialize<IEnumerable<Autor>>(resp, options);


        }
    }
}
