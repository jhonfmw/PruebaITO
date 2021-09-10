using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SwaggerAPI.Utilidades
{
    public class ConnectionAPI : Controller
    {
        private readonly string urlAPI;

        public ConnectionAPI(string apiURl)
        {
            urlAPI = apiURl;
        }

        public async Task<T> GetRequest<T>(string id = "")
        {
            using var request = new HttpRequestMessage();
            var httpClient = new HttpClient();
            request.Method = new HttpMethod("GET");
            var url = string.IsNullOrEmpty(id) ? urlAPI : $"{urlAPI}/{id}";
            request.RequestUri = new Uri(url);
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseText);
        }

        public async Task<T> PostRequest<T>(T model)
        {
            var json = JsonSerializer.Serialize(model);
            var dataString = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using var request = new HttpRequestMessage();
            var httpClient = new HttpClient();
            request.Method = new HttpMethod("POST");
            request.RequestUri = new Uri(urlAPI);
            request.Content = dataString;

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseText);
        }

        public async Task<T> PutRequest<T>(T model, int id)
        {
            var json = JsonSerializer.Serialize(model);
            var dataString = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            using var request = new HttpRequestMessage();
            var httpClient = new HttpClient();
            request.Method = new HttpMethod("PUT");
            request.RequestUri = new Uri($"{urlAPI}/{id}");
            request.Content = dataString;

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseText);
        }
    }
}
