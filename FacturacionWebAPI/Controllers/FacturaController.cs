﻿using Facturacion.DAL;
using Facturacion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FacturacionWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private FacturacionDBContext _context;

        public FacturaController(FacturacionDBContext context)
        {
            _context = context;
        }

        // GET: api/<FacturaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _context.Facturas.ToListAsync());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // GET api/<FacturaController>/5
        [HttpGet("{numfactura}")]
        public async Task<IActionResult> Get(int numfactura)
        {
            try
            {
                Factura factura = await _context.Facturas.Where(f => f.NumeroFactura == numfactura)
                    .Include(f => f.Cliente)
                    .Include(f => f.ItemsVenta)
                    .FirstOrDefaultAsync();
                if (factura != null)
                    return Ok(factura);
                else
                    return NotFound();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // POST api/<FacturaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Factura factura)
        {
            try
            {
                _context.Facturas.Add(factura);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // PUT api/<FacturaController>/5
        [HttpPut("{numfactura}")]
        public async Task<IActionResult> Put(int numfactura, [FromBody] Factura factura)
        {
            try
            {

                var actual = _context.Facturas.Find(numfactura);
                if (actual != null)
                {
                    actual.FechaExpedicion = factura.FechaExpedicion;
                    actual.ClienteId = factura.ClienteId;
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

        // DELETE api/<FacturaController>/5
        [HttpDelete("{numfactura}")]
        public async Task<IActionResult> Delete(int numfactura)
        {
            try
            {
                var actual = _context.Facturas.Find(numfactura);
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