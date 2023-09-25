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
    public class LibroService : ILibroService
    {

        //inyección de dependencias de HtttpClient
        private readonly HttpClient _httpClient;
        public LibroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Libro>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Libro");
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(resp, options);
        }

        public async Task<IEnumerable<Libro>> GetByAutor(int idLibro)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Libro/Buscar", new { idAutor = idLibro });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(respString, options); 
        }

        public async Task<IEnumerable<Libro>> GetByCategoria(int idLibro)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Libro/Buscar", new { idCategoria = idLibro });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(respString, options);
        }

        public async Task<IEnumerable<Libro>> GetByGenero(int idLibro)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Libro/Buscar", new { idGenero = idLibro });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Libro>>(respString, options);
        }

        public async Task<Libro> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Libro/{id}");
            return JsonSerializer.Deserialize<Libro>(resp, options);
        }
    }
}
