using System.Threading.Tasks;
using AutoresApi.Models;

namespace AutoresApi.Example
{
    public class AutoresApiClientExample
    {
        private readonly AutoresApiClient _client = new AutoresApiClient("https://localhost:5001/");

        public async Task<CreateAutorResponse> CreateAutorAsync(string nome, string email, string descricao) =>
            await _client.CreateAutorAsync(new CreateAutorRequest
            {
                Nome = nome,
                Email = email,
                Descricao = descricao
            });
    }
}
