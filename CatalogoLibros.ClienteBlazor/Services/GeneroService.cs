using CatalogoLibros.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace CatalogoLibros.ClienteBlazor.Services
{
    public class GeneroService : IGeneroService
    {
        //Inyeccion de independencia de HttpClient
        private readonly HttpClient _httpClient;
        public GeneroService(HttpClient httpClient)
        {
            _httpClient = new HttpClient();
        }
        //COnfigurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public async Task<IEnumerable<Genero>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Genero");
            return JsonSerializer.Deserialize<IEnumerable<Genero>>(resp, options);

        }

    }
}
