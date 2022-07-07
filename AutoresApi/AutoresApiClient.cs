using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoresApi.Models;

namespace AutoresApi
{
    public class AutoresApiClient
    {
        private readonly HttpClient _client = new HttpClient();

        private readonly string _endpoint = "Autores";

        public AutoresApiClient(string baseUri)
        {
            _client.BaseAddress = new Uri(baseUri);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        public async Task<CreateAutorResponse> CreateAutorAsync(CreateAutorRequest createAutorRequest)
        {
            // Alternative: manual Json serialization/use PostAsync() method
            // var requestBody = new StringContent(JsonConvert.SerializeObject(createAutorRequest).ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsJsonAsync(
                _endpoint,
                createAutorRequest
            );

            CreateAutorResponse createAutorResponse = null;

            if (response.IsSuccessStatusCode)
            {
                createAutorResponse = await response.Content.ReadAsAsync<CreateAutorResponse>();
            }

            return createAutorResponse;
        }
    }
}
