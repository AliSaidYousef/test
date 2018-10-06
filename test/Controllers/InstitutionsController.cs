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
    [Route("api/Institutions")]
    public class InstitutionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstitutionsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/Institutions
        [HttpGet]
        //public IList<Institution> GetInstitutions()
        //{
        //    var instList = _context.Institutions.Include(i => i.Departments).ToList();
        //    return instList;
        //    //return _context.Institutions;
        //}
        public IEnumerable<Institution> GetInstitutions()
        {
            //var instList = _context.Institutions.Include(i => i.Departments).ToList();
            //return instList;
            //  original  return _context.Institutions.Include(i => i.Departments).ToList();
            return _context.Institutions.Include(i => i.Departments).ToList();
        }


        // GET: api/Institutions
        [HttpGet("/instswithprocesses")]
        public IEnumerable<Institution> GetDrilledInstitutions()
        {
            return _context.Institutions.Include(i => i.Departments).ThenInclude(p =>p.Processes).ToList();
        }

        // GET: api/Institutions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInstitution([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var institution = await _context.Institutions.Include(i => i.Departments).SingleOrDefaultAsync(m => m.InstitutionID == id);

            if (institution == null)
            {
                return NotFound();
            }

            return Ok(institution);
        }

        // PUT: api/Institutions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstitution([FromRoute] int id, [FromBody] Institution institution)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != institution.InstitutionID)
            {
                return BadRequest();
            }

            _context.Entry(institution).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstitutionExists(id))
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

        // POST: api/Institutions
        [HttpPost]
        public async Task<IActionResult> PostInstitution([FromBody] Institution institution)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Institutions.Add(institution);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstitution", new { id = institution.InstitutionID }, institution);
        }

        // DELETE: api/Institutions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstitution([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var institution = await _context.Institutions.SingleOrDefaultAsync(m => m.InstitutionID == id);
            if (institution == null)
            {
                return NotFound();
            }

            _context.Institutions.Remove(institution);
            await _context.SaveChangesAsync();

            return Ok(institution);
        }

        private bool InstitutionExists(int id)
        {
            return _context.Institutions.Any(e => e.InstitutionID == id);
        }
    }
}