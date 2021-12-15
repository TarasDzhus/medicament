using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendApp.Models;
using BackendApp.Interfaces;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentController : ControllerBase
    {
        private readonly IMedicamentService _medicamentService;
        public MedicamentController(IMedicamentService medicamentService)
        {
            _medicamentService = medicamentService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Medicament/GetMedicament")]
        public IEnumerable<Medicament> GetMedicament()
        {
            return _medicamentService.GetMedicament();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Medicament/GetMedicamentId")]
        public Medicament GetMedicamentId(int id)
        {
            return _medicamentService.GetMedicamentById(id);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Medicament/AddMedicament")]
        public Medicament AddMedicament(Medicament medicament)
        {
            return _medicamentService.AddMedicament(medicament);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/Medicament/EditMedicament")]
        public Medicament EditMedicament(Medicament medicament)
        {
            return _medicamentService.UpdateMedicament(medicament);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Medicament/DeleteMedicament")]
        public Medicament DeleteMedicament(int id)
        {
            return _medicamentService.DeleteMedicament(id);
        }

        /*
        // GET: api/Medicaments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicament>>> GetMedicaments()
        {
            return await _context.Medicaments.ToListAsync();
        }

        // GET: api/Medicaments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medicament>> GetMedicament(int id)
        {
            var medicament = await _context.Medicaments.FindAsync(id);

            if (medicament == null)
            {
                return NotFound();
            }

            return medicament;
        }

        // PUT: api/Medicaments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicament(int id, Medicament medicament)
        {
            if (id != medicament.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicament).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicamentExists(id))
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

        // POST: api/Medicaments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Medicament>> PostMedicament(Medicament medicament)
        {
            _context.Medicaments.Add(medicament);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetMedicament", new { id = medicament.Id }, medicament);
            return CreatedAtAction(nameof(GetMedicament), new { id = medicament.Id }, medicament);
        }

        // DELETE: api/Medicaments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Medicament>> DeleteMedicament(int id)
        {
            var medicament = await _context.Medicaments.FindAsync(id);
            if (medicament == null)
            {
                return NotFound();
            }

            _context.Medicaments.Remove(medicament);
            await _context.SaveChangesAsync();

            return medicament;
        }

        private bool MedicamentExists(int id)
        {
            return _context.Medicaments.Any(e => e.Id == id);
        }*/
    }
}
