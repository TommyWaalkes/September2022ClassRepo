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
    public class DevsController : ControllerBase
    {
        private readonly DonutsNdevsContext _context;

        public DevsController(DonutsNdevsContext context)
        {
            _context = context;
        }

        // GET: api/Devs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dev>>> GetDevs()
        {
            return await _context.Devs.ToListAsync();
        }

        // GET: api/Devs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dev>> GetDev(int id)
        {
            var dev = await _context.Devs.FindAsync(id);

            if (dev == null)
            {
                return NotFound();
            }

            return dev;
        }

        // PUT: api/Devs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDev(int id, Dev dev)
        {
            if (id != dev.Id)
            {
                return BadRequest();
            }

            _context.Entry(dev).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DevExists(id))
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

        // POST: api/Devs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dev>> PostDev(Dev dev)
        {
            _context.Devs.Add(dev);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDev", new { id = dev.Id }, dev);
        }

        // DELETE: api/Devs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDev(int id)
        {
            var dev = await _context.Devs.FindAsync(id);
            if (dev == null)
            {
                return NotFound();
            }

            _context.Devs.Remove(dev);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DevExists(int id)
        {
            return _context.Devs.Any(e => e.Id == id);
        }
    }
}
