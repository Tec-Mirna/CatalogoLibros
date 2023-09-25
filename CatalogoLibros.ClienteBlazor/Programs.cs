using CatalogoLibros.ClienteBlazor;
using CatalogoLibros.ClienteBlazor.Services;// quita error en ICategoriaService y CategoriaService
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace CatalogoLibros.ClienteBlazor
{
    public class Programs
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7233/api/") });//url que conecta con el backend

            builder.Services.AddScoped<ICategoriaService, CategoriaService>();
          //  builder.Services.AddScoped<IGeneroService, GeneroService>();
            builder.Services.AddScoped<IAutorService, AutorService>();
            builder.Services.AddScoped<ILibroService, LibroService>();//En esta van los dos la de Interfas y la clase de libro.

            builder.Services.AddMudServices(); /*Importacion de los servicios de MudBlazor*/

            await builder.Build().RunAsync();
        }
        
    }
}
