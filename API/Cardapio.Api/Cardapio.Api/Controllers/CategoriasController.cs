using Cardapio.Api.Data;
using Cardapio.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cardapio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/categorias
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categorias = await _context.Categorias.ToListAsync();
            return Ok(categorias);
        }

        // GET: api/categorias/{publicId}
        [HttpGet("{publicId:guid}")]
        public async Task<IActionResult> GetByPublicId(Guid publicId)
        {
            var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.PublicId == publicId);

            if(categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }

        // POST: api/categorias
        [HttpPost]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            if(categoria.PublicId == Guid.Empty)
            {
                categoria.PublicId = Guid.NewGuid();
            }

            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetByPublicId), new { publicId = categoria.PublicId }, categoria);
        }

        // PUT: api/categorias/{publicId}
        [HttpPut("{publicId:guid}")]
        public async Task<IActionResult> Update(Guid publicId, Categoria categoria)
        {
         
            var categoriaDb = await _context.Categorias.FirstOrDefaultAsync(c => c.PublicId == publicId);

            if(categoriaDb == null)
            {
                return NotFound();
            }

            categoriaDb.Nome = categoria.Nome;
            categoriaDb.Descricao = categoria.Descricao;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/categorias/{publicId}
        [HttpDelete("{publicId:guid}")]
        public async Task<IActionResult> Delete(Guid publicId)
        {
            var categoria = await _context.Categorias.FirstOrDefaultAsync(c => c.PublicId == publicId);

            if(categoria == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
