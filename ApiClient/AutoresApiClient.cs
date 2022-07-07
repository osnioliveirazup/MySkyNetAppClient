using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Models;

namespace ApiClient
{
    public class AutoresApiClient
    {
        private readonly HttpClient client = new HttpClient();

        private readonly string _endpoint = "Autores";

        public AutoresApiClient(string baseUri)
        {
            client.BaseAddress = new Uri(baseUri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        public async Task<Autor> CreateAutorAsync(CreateAutorRequest createAutorRequest)
        {
            // Alternative: manual Json serialization/use PostAsync() method
            // var requestBody = new StringContent(JsonConvert.SerializeObject(createAutorRequest).ToString(), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsJsonAsync(
                _endpoint,
                createAutorRequest
            );

            Autor autor = null;

            if (response.IsSuccessStatusCode)
            {
                autor = await response.Content.ReadAsAsync<Autor>();
            }

            return autor;
        }
    }
}
