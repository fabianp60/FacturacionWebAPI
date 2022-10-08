﻿using Facturacion.DAL;
using Facturacion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FacturacionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemVentaController : ControllerBase
    {
        private FacturacionDBContext _context;

        public ItemVentaController(FacturacionDBContext context)
        {
            _context = context;
        }

        // GET: api/<ItemVentaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _context.ItemsVentas.ToListAsync());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<ItemVentaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                ItemVenta itemventa = await _context.ItemsVentas
                    .Where(c => c.Id == id)
                    .Include(iv => iv.Producto)
                    .FirstOrDefaultAsync();
                if (itemventa != null)
                    return Ok(itemventa);
                else
                    return NotFound();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // POST api/<ItemVentaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ItemVenta itemventa)
        {
            try
            {
                _context.ItemsVentas.Add(itemventa);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // PUT api/<ItemVentaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ItemVenta itemventa)
        {
            try
            {

                var actual = _context.ItemsVentas.Find(id);
                if (actual != null)
                {
                    actual.NumeroFactura = itemventa.NumeroFactura;
                    actual.ProductoId = itemventa.ProductoId;
                    actual.PrecioUnitario = itemventa.PrecioUnitario;
                    actual.CantidadVendida = itemventa.CantidadVendida;
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<ItemVentaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var actual = _context.ItemsVentas.Find(id);
                if (actual != null)
                {
                    _context.Remove(actual);
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
