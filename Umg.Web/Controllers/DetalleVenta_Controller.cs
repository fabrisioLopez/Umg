using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umg.Datos;
using Umg.Entidades.Ventas;

namespace Umg.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleVenta_Controller : ControllerBase
    {
        private readonly DbContextSistema _context;

        public DetalleVenta_Controller(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalleventa_>>> GetDetallesVentass_()
        {
            return await _context.DetallesVentass_.ToListAsync();
        }

        // GET api/Categorias/2
        [HttpGet("{idDetalleIngreso")]

        public async Task<ActionResult<Detalleventa_>> GetDetalleventa_(int id)
        {
            var Detalleventa_ = await _context.DetallesVentass_.FindAsync(id);

            if (Detalleventa_ == null)
            {
                return NotFound();
            }

            return Detalleventa_;
        }


        // put api/Categoria/2 
        [HttpPut("idDetallleventa_")]
        public async Task<IActionResult> putDetalleventa_(int id,Detalleventa_ detalleventa_)
        {
            if (id != detalleventa_.idDetalleventa_)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(detalleventa_).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!Detalleventa_Exists(id))
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
        public async Task<ActionResult<Detalleventa_>> PostdetalleIngrso(Detalleventa_ detalleventa_)
        {
            _context.DetallesVentass_.Add(detalleventa_);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getDetalleventa_", new { id = detalleventa_.idDetalleventa_ }, detalleventa_);
        }

        //Delete Api/Categoria 2 

        [HttpDelete("idDetalleventaa_")]
        public async Task<ActionResult<Detalleventa_>> DeleteDetalleventa_(int id)
        {
            var Detalleventa_ = await _context.DetallesVentass_.FindAsync(id);

            if (Detalleventa_ == null)
            {
                return NotFound();
            }

            _context.DetallesVentass_.Remove(Detalleventa_);
            await _context.SaveChangesAsync();

            return Detalleventa_;
        }

        private bool Detalleventa_Exists(int id)
        {
            return _context.DetallesVentass_.Any(e => e.idDetalleventa_ == id);
        }
    }

}
