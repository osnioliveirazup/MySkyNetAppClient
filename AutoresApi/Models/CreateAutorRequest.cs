using System.Text.Json.Serialization;

namespace AutoresApi.Models
{
    public class CreateAutorRequest
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
    }
}
