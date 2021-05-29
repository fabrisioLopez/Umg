﻿using Microsoft.AspNetCore.Http;
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
    public class IngresoController : ControllerBase

    {
        private readonly DbContextSistema _context;

        public IngresoController(DbContextSistema context)
        {
            _context = context;
        }

        //GET api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ingreso>>> GetCategorias()
        {
            return await _context.Ingresos.ToListAsync();
        }

        // GET api/Categorias/2
        [HttpGet("{idIngreso")]

        public async Task<ActionResult<ingreso>> Getingreso(int id)
        {
            var ingreso = await _context.Ingresos.FindAsync(id);

            if (ingreso == null)
            {
                return NotFound();
            }

            return ingreso;
        }


        // put api/Categoria/2 
        [HttpPut("idIngreso")]
        public async Task<IActionResult> putIngreso(int id, ingreso ingreso)
        {
            if (id != ingreso.idIngreso)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADES QUE VOY A AGUARDAR EN MI BD
            _context.Entry(ingreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!IngresoExists(id))
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
        public async Task<ActionResult<ingreso>> PostCategoria(ingreso ingreso)
        {
            _context.Ingresos.Add(ingreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("getingreso", new { id = ingreso.idIngreso}, ingreso);
        }

        //Delete Api/Categoria 2 

        [HttpDelete("idIngreso")]
        public async Task<ActionResult<ingreso>> Deleteingreso(int id)
        {
            var ingreso = await _context.Ingresos.FindAsync(id);

            if (ingreso == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(ingreso);
            await _context.SaveChangesAsync();

            return ingreso;
        }

        private bool IngresoExists(int id)
        {
            return _context.Ingresos.Any(e => e.idIngreso == id);
        }
    }

}


