using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Almacen;

namespace Umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Articulo_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public Articulo_Controller(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<articulo_>>> GetArticulos_()
        {
            return await _context.Articulos_.ToListAsync();
        }

        // GET api/Categorias/2
        [HttpGet("{idCodigoArticulo")]

        public async Task<ActionResult<articulo_>> Getarticulo_(int id)
        {
            var articulo_ = await _context.Articulos_.FindAsync(id);

            if (articulo_ == null)
            {
                return NotFound();
            }

            return articulo_;
        }


        // put api/Categoria/2 
        [HttpPut("idCodigoArticulo")]
        public async Task<IActionResult> putarticulo_(int id, articulo_ articulo_)

        {
            if (id != articulo_.idCodigoArticulo)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(articulo_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!articulo_Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }

            return NoContent();

        }

        //POst api/Categorias
        [HttpPost]
        public async Task<ActionResult<articulo_>> PostCategoria(articulo_ articulo_)
        {
            _context.Articulos_.Add(articulo_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getarticulo_", new { id = articulo_.idCodigoArticulo }, articulo_);
        }

        //Delete Api/Categoria 2 

        [HttpDelete("idCodigoArticulo")]
        public async Task<ActionResult<articulo_>> Deletearticulo_(int id)
        {
            var articulo_ = await _context.Articulos_.FindAsync(id);

            if (articulo_ == null)
            {
                return NotFound();
            }

            _context.Articulos_.Remove(articulo_);
            await _context.SaveChangesAsync();

            return articulo_;
        }

        private bool articulo_Exists(int id)
        {
            return _context.Articulos_.Any(e => e.idCodigoArticulo == id);
        }
    }

}
