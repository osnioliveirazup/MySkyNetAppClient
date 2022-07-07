using System;
using System.Threading.Tasks;
using ApiClient;
using ApiClient.Models;

namespace MySkyNetAppClient
{
    class Program
    {
        private static readonly AutoresApiClient client = new AutoresApiClient("https://localhost:5001/");

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Create a new Autor
            var createAutorRequest = new CreateAutorRequest
            {
                Nome = "Autor 1",
                Email = "autor1@zup.com.br",
                Descricao = "Autor número um"
            };

            var autor = await client.CreateAutorAsync(createAutorRequest);

            if (autor is CreateAutorResponse)
            {
                Console.WriteLine($"Id: {autor.Id}");
                Console.WriteLine($"Nome: {autor.Nome}");
                Console.WriteLine($"Email: {autor.Email}");
                Console.WriteLine($"Descricao: {autor.Descricao}");
                Console.WriteLine($"Instante criação: {autor.InstanteCriacao}");
            }
            else
            {
                Console.WriteLine("Erro na criação do autor.");
            }
        }
    }
}
