using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicalExaminationWebApi.Models;

namespace MedicalExaminationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationController : ControllerBase
    {
        private readonly ExaminationDbContext _context;

        public ExaminationController(ExaminationDbContext context)
        {
            _context = context;
        }

        // GET: api/Examination
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Examination>>> GetExaminations()
        {
            return await _context.Examinations.ToListAsync();
        }

        // GET: api/Examination/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Examination>> GetExamination(int id)
        {
            var examination = await _context.Examinations.FindAsync(id);

            if (examination == null)
            {
                return NotFound();
            }

            return examination;
        }

        // PUT: api/Examination/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExamination(int id, Examination examination)
        {
            examination.id = id;

            _context.Entry(examination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExaminationExists(id))
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

        // POST: api/Examination
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Examination>> PostExamination(Examination examination)
        {
            _context.Examinations.Add(examination);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExamination", new { id = examination.id }, examination);
        }

        // DELETE: api/Examination/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Examination>> DeleteExamination(int id)
        {
            var examination = await _context.Examinations.FindAsync(id);
            if (examination == null)
            {
                return NotFound();
            }

            _context.Examinations.Remove(examination);
            await _context.SaveChangesAsync();

            return examination;
        }

        private bool ExaminationExists(int id)
        {
            return _context.Examinations.Any(e => e.id == id);
        }
    }
}