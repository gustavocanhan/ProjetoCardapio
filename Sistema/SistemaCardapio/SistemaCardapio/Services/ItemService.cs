using SistemaCardapio.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http.Json;
using System.Text;

namespace SistemaCardapio.Services
{
    internal class ItemService
    {
        private readonly HttpClient _httpClient;

        public ItemService()
        {
            var baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"] ?? throw new Exception("ApiBaseUrl is not configured in app settings.");

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }

        public async Task<List<ItemDTO>> ObterTodosAsync()
        {
            var itens = await _httpClient.GetFromJsonAsync<List<ItemDTO>>("Item");

            return itens ?? new List<ItemDTO>();
        }

        public async Task CriarAsync(ItemDTO item)
        {
            await _httpClient.PostAsJsonAsync("Item", item);
        }

        public async Task AtualizarAsync(Guid publicId, ItemDTO item)
        {
            await _httpClient.PutAsJsonAsync($"Item/{publicId}", item);
        }

        public async Task ExcluirAsync(Guid publicId)
        {
            await _httpClient.DeleteAsync($"Item/{publicId}");
        }
    }
}
