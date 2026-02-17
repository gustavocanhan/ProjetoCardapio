using System.Text.Json.Serialization;

namespace Cardapio.Api.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public Guid PublicId { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }

        [JsonIgnore]
        public ICollection<Item> Itens { get; set; } = new List<Item>();
    }
}
