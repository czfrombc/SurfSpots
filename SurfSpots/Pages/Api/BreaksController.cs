using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurfBreaks.Core;
using SurfBreaks.Data;

namespace SurfBreaks.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreaksController : ControllerBase
    {
        private readonly SurfBreaksDbContext _context;

        public BreaksController(SurfBreaksDbContext context)
        {
            _context = context;
        }

        // GET: api/SurfBreaks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurfBreak>>> GetSurfBreaks()
        {
            return await _context.SurfBreaks.ToListAsync();
        }

        // GET: api/SurfBreaks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SurfBreak>> GetSurfBreak(int id)
        {
            var surfBreak = await _context.SurfBreaks.FindAsync(id);

            if (surfBreak == null)
            {
                return NotFound();
            }

            return surfBreak;
        }

        // PUT: api/SurfBreaks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurfBreak(int id, SurfBreak surfBreak)
        {
            if (id != surfBreak.Id)
            {
                return BadRequest();
            }

            _context.Entry(surfBreak).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurfBreakExists(id))
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

        // POST: api/SurfBreaks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SurfBreak>> PostSurfBreak(SurfBreak surfBreak)
        {
            _context.SurfBreaks.Add(surfBreak);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSurfBreak", new { id = surfBreak.Id }, surfBreak);
        }

        // DELETE: api/SurfBreaks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SurfBreak>> DeleteSurfBreak(int id)
        {
            var surfBreak = await _context.SurfBreaks.FindAsync(id);
            if (surfBreak == null)
            {
                return NotFound();
            }

            _context.SurfBreaks.Remove(surfBreak);
            await _context.SaveChangesAsync();

            return surfBreak;
        }

        private bool SurfBreakExists(int id)
        {
            return _context.SurfBreaks.Any(e => e.Id == id);
        }
    }
}
