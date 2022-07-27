using System;
using System.Threading.Tasks;
using AutoresApi.Example;
using AutoresApi.Models;

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
            var nome = "Autor 1";
            var email = "autor1@zup.com.br";
            var descricao = "Autor número um";

            if (await _clientExample.CreateAutorAsync(nome, email, descricao) is CreateAutorResponse autorResponse)
            {
                Console.WriteLine($"Id: {autorResponse.Id}");
                Console.WriteLine($"Nome: {autorResponse.Nome}");
                Console.WriteLine($"Email: {autorResponse.Email}");
                Console.WriteLine($"Descricao: {autorResponse.Descricao}");
                Console.WriteLine($"Instante criação: {autorResponse.InstanteCriacao}");
            }
            else
            {
                Console.WriteLine("Erro na criação do autor.");
            }
        }
    }
}
