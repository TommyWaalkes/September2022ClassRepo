using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DonutsNDexsBackend.Models;

namespace DonutsNDexsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonutsController : ControllerBase
    {
        private readonly DonutsNdevsContext _context;

        public DonutsController(DonutsNdevsContext context)
        {
            _context = context;
        }

        // GET: api/Donuts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donut>>> GetDonuts()
        {
            return await _context.Donuts.ToListAsync();
        }

        // GET: api/Donuts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Donut>> GetDonut(int id)
        {
            var donut = await _context.Donuts.FindAsync(id);

            if (donut == null)
            {
                return NotFound();
            }

            return donut;
        }

        // PUT: api/Donuts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonut(int id, Donut donut)
        {
            if (id != donut.Id)
            {
                return BadRequest();
            }

            _context.Entry(donut).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonutExists(id))
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

        // POST: api/Donuts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Donut>> PostDonut(Donut donut)
        {
            _context.Donuts.Add(donut);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonut", new { id = donut.Id }, donut);
        }

        // DELETE: api/Donuts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDonut(int id)
        {
            var donut = await _context.Donuts.FindAsync(id);
            if (donut == null)
            {
                return NotFound();
            }

            _context.Donuts.Remove(donut);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DonutExists(int id)
        {
            return _context.Donuts.Any(e => e.Id == id);
        }
    }
}
