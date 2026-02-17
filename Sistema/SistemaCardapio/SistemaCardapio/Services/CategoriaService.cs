using SistemaCardapio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http.Json;
using System.Text;

namespace SistemaCardapio.Services
{
    internal class CategoriaService
    {
        private readonly HttpClient _httpClient;

        public CategoriaService()
        {
            var baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"] ?? throw new Exception("ApiBaseUrl is not configured in app settings.");

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }

        public async Task<List<CategoriaDTO>> ObterTodasAsync()
        {
            var categorias = await _httpClient.GetFromJsonAsync<List<CategoriaDTO>>("Categorias");

            return categorias ?? new List<CategoriaDTO>();
        }

        public async Task CriarAsync(CategoriaDTO categoria)
        {
            await _httpClient.PostAsJsonAsync("Categorias", categoria);
        }

        public async Task AtualizarAsync(Guid publicId, CategoriaDTO categoria)
        {
            await _httpClient.PutAsJsonAsync($"Categorias/{publicId}", categoria);
        }

        public async Task ExcluirAsync(Guid publicId)
        {
            await _httpClient.DeleteAsync($"Categorias/{publicId}");
        }
    }
}
