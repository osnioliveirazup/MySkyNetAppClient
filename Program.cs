using System;
using System.Threading.Tasks;
using AutoresApi.Example;

namespace MySkyNetAppClient
{
    class Program
    {
        private static readonly AutoresApiClientExample _clientExample = new AutoresApiClientExample();

        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Create a new Autor
            var autor = await _clientExample.CreateAutorAsync(
                "Autor 1",
                "autor1@zup.com.br",
                "Autor número um"
            );

            if (autor != null)
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
