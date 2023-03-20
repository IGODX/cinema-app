using System.Text.Json;
using CinemaApp.Controllers;

namespace CinemaApp.Services
{
    public class JsonParser : IJsonParser
    {
        public JsonParser()
        {

        }

        public async Task<T> GetDeserializedObject<T>(string url, ILogger<HomeController> logger)
        {
            T deserializedResult = default!;
            try
            {
                using HttpClient client = new();
                using HttpRequestMessage requestMessage = new();
                requestMessage.Method = HttpMethod.Get;
                requestMessage.RequestUri = new Uri(url);
                HttpResponseMessage httpResponse = await client.SendAsync(requestMessage);
                string content = await httpResponse.Content.ReadAsStringAsync();
                deserializedResult = JsonSerializer.Deserialize<T>(content)!;
            }
            catch (JsonException ex)
            {
                logger.LogInformation(ex.Message);
                return default!;
            }
            return deserializedResult;
        }
    }
}
