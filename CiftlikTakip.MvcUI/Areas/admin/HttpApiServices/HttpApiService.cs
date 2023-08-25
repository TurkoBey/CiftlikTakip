using Microsoft.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace CiftlikTakip.MvcUI.Areas.admin.HttpApiServices
{
    public class HttpApiService : IHttpApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string baseAddress = "http://localhost:5162/api";
        public HttpApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<T> GetData<T>(string endPoint)
        {
            var client = _httpClientFactory.CreateClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers =
                {
                    {HeaderNames.Accept , "application/json"}
                }
            };

            var responseMessage = await client.SendAsync(requestMessage);
            var jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<T> PostData<T>(string endPoint, string jsonData)
        {
            var client = _httpClientFactory.CreateClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers =
                {
                    {HeaderNames.Accept , "application/json"}
                },
                Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
            };

            var responseMessage = await client.SendAsync(requestMessage);
            var jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<T> DeleteData<T>(string endPoint)
        {
            var client = _httpClientFactory.CreateClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers =
                {
                    {HeaderNames.Accept , "application/json"}
                }
            };

            var responseMessage = await client.SendAsync(requestMessage);
            var jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return response;
        }
        public async Task<T> PutData<T>(string endPoint, string jsonData)
        {
            var client = _httpClientFactory.CreateClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers =
                {
                    {HeaderNames.Accept , "application/json"}
                },
                Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
            };

            var responseMessage = await client.SendAsync(requestMessage);
            var jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }

        public async Task<T> PostOrPutData<T>(string endPoint, string jsonData, HttpMethod httpMethod)
        {
            var client = _httpClientFactory.CreateClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = httpMethod,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers =
                {
                    {HeaderNames.Accept , "application/json"}
                },
                Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
            };

            var responseMessage = await client.SendAsync(requestMessage);
            var jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return response;
        }
    }
}
