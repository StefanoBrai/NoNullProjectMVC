using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.DTOs;

namespace WebApplication1.Controllers.API
{
    [Route("api/professionist")]
    [ApiController]
    public class ProfessionistController : ControllerBase
    {
        private readonly NoNullProjectContext _context;

        public ProfessionistController(NoNullProjectContext context)
        {
            _context = context;
        }

        // GET: api/Professionist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessionistDTO>>> GetProfessionists()
        {
            List<Professionist> proList = await _context.Professionists.ToListAsync();
            return Ok(proList.Select(p => new ProfessionistDTO(p)));
           
        }

        // GET: api/Professionist/5
        [HttpGet("{id}")]
        [ResponseType(typeof(ProfessionistDTO))]
        public async Task<ActionResult<Professionist>> GetProfessionist(int id)
        {  
            var professionist = await _context.Professionists.FindAsync(id);

            if (professionist == null)
            {
                return NotFound();
            }

            return professionist;
        }

        // PUT: api/Professionist/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessionist(int id, Professionist professionist)
        {
            if (id != professionist.ProfId)
            {
                return BadRequest();
            }

            _context.Entry(professionist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessionistExists(id))
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

        // POST: api/Professionist
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Professionist>> PostProfessionist(Professionist professionist)
        {
            _context.Professionists.Add(professionist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessionist", new { id = professionist.ProfId }, professionist);
        }

        // DELETE: api/Professionist/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Professionist>> DeleteProfessionist(int id)
        {
            var professionist = await _context.Professionists.FindAsync(id);
            if (professionist == null)
            {
                return NotFound();
            }

            _context.Professionists.Remove(professionist);
            await _context.SaveChangesAsync();

            return professionist;
        }

        private bool ProfessionistExists(int id)
        {
            return _context.Professionists.Any(e => e.ProfId == id);
        }
    }
}
