using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Models;

namespace test.Controllers
{
    [Produces("application/json")]
    [Route("api/Processes")]
    public class ProcessesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProcessesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Processes
        [HttpGet]
        public IEnumerable<Process> GetProcesses()
        {
            return _context.Processes;
        }

        // GET: api/Processes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProcess([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var process = await _context.Processes.SingleOrDefaultAsync(m => m.ProcessID == id);

            if (process == null)
            {
                return NotFound();
            }

            return Ok(process);
        }

        // PUT: api/Processes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProcess([FromRoute] int id, [FromBody] Process process)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != process.ProcessID)
            {
                return BadRequest();
            }

            _context.Entry(process).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessExists(id))
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

        // POST: api/Processes
        [HttpPost]
        public async Task<IActionResult> PostProcess([FromBody] Process process)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Processes.Add(process);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProcess", new { id = process.ProcessID }, process);
        }

        // DELETE: api/Processes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProcess([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var process = await _context.Processes.SingleOrDefaultAsync(m => m.ProcessID == id);
            if (process == null)
            {
                return NotFound();
            }

            _context.Processes.Remove(process);
            await _context.SaveChangesAsync();

            return Ok(process);
        }

        private bool ProcessExists(int id)
        {
            return _context.Processes.Any(e => e.ProcessID == id);
        }
    }
}