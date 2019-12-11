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
    public class CompanyController : Controller
    {
        private readonly NoNullProjectContext _context;

        public CompanyController(NoNullProjectContext context)
        {
            _context = context;
        }

        // GET: Company
        public async Task<IActionResult> Index()
        {
            var noNullProjectContext = _context.Companies.Include(c => c.Destination).Include(c => c.Generalarea);
            return View(await noNullProjectContext.ToListAsync());
        }

        // GET: Company/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companies = await _context.Companies
                .Include(c => c.Destination)
                .Include(c => c.Generalarea)
                .FirstOrDefaultAsync(m => m.CompId == id);
            if (companies == null)
            {
                return NotFound();
            }

            return View(companies);
        }

        // GET: Company/Create
        public IActionResult Create()
        {
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name");
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name");
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompId,Name,Type,Address,City,Region,Postalcode,DestinationId,GeneralareaId,Mission")] Company companies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", companies.DestinationId);
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name", companies.GeneralareaId);
            return View(companies);
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companies = await _context.Companies.FindAsync(id);
            if (companies == null)
            {
                return NotFound();
            }
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", companies.DestinationId);
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name", companies.GeneralareaId);
            return View(companies);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompId,Name,Type,Address,City,Region,Postalcode,DestinationId,GeneralareaId,Mission")] Company companies)
        {
            if (id != companies.CompId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompaniesExists(companies.CompId))
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
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", companies.DestinationId);
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name", companies.GeneralareaId);
            return View(companies);
        }

        // GET: Company/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companies = await _context.Companies
                .Include(c => c.Destination)
                .Include(c => c.Generalarea)
                .FirstOrDefaultAsync(m => m.CompId == id);
            if (companies == null)
            {
                return NotFound();
            }

            return View(companies);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var companies = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(companies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompaniesExists(int id)
        {
            return _context.Companies.Any(e => e.CompId == id);
        }
    }
}
