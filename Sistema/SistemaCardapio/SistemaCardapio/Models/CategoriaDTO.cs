using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCardapio.Models
{
    internal class CategoriaDTO
    {
        public Guid PublicId { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
