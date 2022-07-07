using System;
using System.Text.Json.Serialization;

namespace AutoresApi.Models
{
    public class CreateAutorResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("instanteCriacao")]
        public DateTime InstanteCriacao { get; set; }
    }
}
