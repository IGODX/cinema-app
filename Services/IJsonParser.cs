using CinemaApp.Controllers;

namespace CinemaApp.Services
{
    public interface IJsonParser
    {

        public Task<T> GetDeserializedObject<T>(string url, ILogger<HomeController> logger);
    }
}
