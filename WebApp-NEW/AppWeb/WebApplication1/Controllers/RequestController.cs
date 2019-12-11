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
    public class RequestController : Controller
    {
        private readonly NoNullProjectContext _context;

        public RequestController(NoNullProjectContext context)
        {
            _context = context;
        }

        // GET: Request
        public async Task<IActionResult> Index()
        {
            var noNullProjectContext = _context.Requests.Include(r => r.Comp).Include(r => r.Destination).Include(r => r.Proj).Include(r => r.Skill);
            return View(await noNullProjectContext.ToListAsync());
        }

        // GET: Request/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Requests
                .Include(r => r.Comp)
                .Include(r => r.Destination)
                .Include(r => r.Proj)
                .Include(r => r.Skill)
                .FirstOrDefaultAsync(m => m.ReqId == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // GET: Request/Create
        public IActionResult Create()
        {
            ViewData["CompId"] = new SelectList(_context.Companies, "CompId", "Address");
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name");
            ViewData["ProjId"] = new SelectList(_context.Projects, "ProjId", "Description");
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "Description");
            return View();
        }

        // POST: Request/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReqId,CompId,ProjId,SkillId,DestinationId,BeginningDate,EndingDate,Description")] Request request)
        {
            if (ModelState.IsValid)
            {
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompId"] = new SelectList(_context.Companies, "CompId", "Address", request.CompId);
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", request.DestinationId);
            ViewData["ProjId"] = new SelectList(_context.Projects, "ProjId", "Description", request.ProjId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "Description", request.SkillId);
            return View(request);
        }

        // GET: Request/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Requests.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }
            ViewData["CompId"] = new SelectList(_context.Companies, "CompId", "Address", request.CompId);
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", request.DestinationId);
            ViewData["ProjId"] = new SelectList(_context.Projects, "ProjId", "Description", request.ProjId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "Description", request.SkillId);
            return View(request);
        }

        // POST: Request/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReqId,CompId,ProjId,SkillId,DestinationId,BeginningDate,EndingDate,Description")] Request request)
        {
            if (id != request.ReqId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(request);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestExists(request.ReqId))
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
            ViewData["CompId"] = new SelectList(_context.Companies, "CompId", "Address", request.CompId);
            ViewData["DestinationId"] = new SelectList(_context.Destinations, "DestinationId", "Name", request.DestinationId);
            ViewData["ProjId"] = new SelectList(_context.Projects, "ProjId", "Description", request.ProjId);
            ViewData["SkillId"] = new SelectList(_context.Skills, "SkillId", "Description", request.SkillId);
            return View(request);
        }

        // GET: Request/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Requests
                .Include(r => r.Comp)
                .Include(r => r.Destination)
                .Include(r => r.Proj)
                .Include(r => r.Skill)
                .FirstOrDefaultAsync(m => m.ReqId == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // POST: Request/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestExists(int id)
        {
            return _context.Requests.Any(e => e.ReqId == id);
        }
    }
}
