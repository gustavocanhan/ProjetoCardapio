using Cardapio.Api.Data;
using Cardapio.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cardapio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/itens
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var itens = await _context.Itens.Include(i => i.Categoria).ToListAsync();
            return Ok(itens);
        }

        // GET: api/itens/{publicId}
        [HttpGet("{publicId:guid}")]
        public async Task<IActionResult> GetByPublicId(Guid publicId)
        {
            var item = await _context.Itens.Include(i => i.Categoria).FirstOrDefaultAsync(i => i.PublicId == publicId);

            if(item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // POST: api/itens
        [HttpPost]
        public async Task<IActionResult> Create(Item item)
        {
            if(item.PublicId == Guid.Empty)
            {
                item.PublicId = Guid.NewGuid();
            }

            _context.Itens.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetByPublicId), new { publicId = item.PublicId }, item);
        }

        // PUT: api/itens/{publicId}
        [HttpPut("{publicId:guid}")]
        public async Task<IActionResult> Update(Guid publicId, Item item)
        {
            var itemDb = await _context.Itens.FirstOrDefaultAsync(i => i.PublicId == publicId);

            if(itemDb == null)
            {
                return NotFound();
            }

            itemDb.Nome = item.Nome;
            itemDb.Descricao = item.Descricao;
            itemDb.Preco = item.Preco;
            itemDb.CategoriaPublicId = item.CategoriaPublicId;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/itens/{publicId}
        [HttpDelete("{publicId:guid}")]
        public async Task<IActionResult> Delete(Guid publicId)
        {
            var item = await _context.Itens.FirstOrDefaultAsync(i => i.PublicId == publicId);

            if(item == null)
            {
                return NotFound();

            }

            _context.Itens.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
