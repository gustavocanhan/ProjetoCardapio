using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCardapio.Models
{
    internal class ItemDTO
    {
        public Guid PublicId { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public Guid CategoriaPublicId { get; set; }
        public CategoriaDTO Categoria { get; set; }
    }
}
