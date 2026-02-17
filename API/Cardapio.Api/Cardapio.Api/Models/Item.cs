namespace Cardapio.Api.Models
{
    public class Item
    {
        public int Id { get; set;  }
        public Guid PublicId { get; set;  } = Guid.NewGuid();
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }

        public Guid CategoriaPublicId { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
