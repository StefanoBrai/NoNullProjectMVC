using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfessionistController : Controller
    {
        private readonly NoNullProjectContext _context;

        public ProfessionistController(NoNullProjectContext context)
        {
            _context = context;
        }

        // GET: Professionist
        public async Task<IActionResult> Index()
        {
            var noNullProjectContext = _context.Professionists.Include(p => p.Destination);
            return View(await noNullProjectContext.ToListAsync());
        }

        // GET: Professionist/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionist = await _context.Professionists
                .Include(p => p.Destination)
                .FirstOrDefaultAsync(m => m.ProfId == id);
            if (professionist == null)
            {
                return NotFound();
            }

            return View(professionist);
        }

        // GET: Professionist/Create
        public IActionResult Create()
        {
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name");
            return View();
        }

        // POST: Professionist/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfId,Lastname,Firstname,Profession,Birthdate,Address,City,Region,Postalcode,DestinationId,Phone,Mail,Minavailability,Maxavailability")] Professionist professionist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(professionist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", professionist.DestinationId);
            return View(professionist);
        }

        // GET: Professionist/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionist = await _context.Professionists.FindAsync(id);
            if (professionist == null)
            {
                return NotFound();
            }
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", professionist.DestinationId);
            return View(professionist);
        }

        // POST: Professionist/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfId,Lastname,Firstname,Profession,Birthdate,Address,City,Region,Postalcode,DestinationId,Phone,Mail,Minavailability,Maxavailability")] Professionist professionist)
        {
            if (id != professionist.ProfId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professionist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessionistExists(professionist.ProfId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", professionist.DestinationId);
            return View(professionist);
        }

        // GET: Professionist/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionist = await _context.Professionists
                .Include(p => p.Destination)
                .FirstOrDefaultAsync(m => m.ProfId == id);
            if (professionist == null)
            {
                return NotFound();
            }

            return View(professionist);
        }

        // POST: Professionist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professionist = await _context.Professionists.FindAsync(id);
            _context.Professionists.Remove(professionist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfessionistExists(int id)
        {
            return _context.Professionists.Any(e => e.ProfId == id);
        }
    }
}
