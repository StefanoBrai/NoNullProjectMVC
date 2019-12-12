using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Controllers
{
    public class SkillController : Controller
    {
        private readonly NoNullProjectContext _context;
        private readonly SkillRepository repo;

        public SkillController(NoNullProjectContext context, SkillRepository repo)
        {
            this.repo = repo;
            _context = context;
        }

        // GET: Skill
        public async Task<IActionResult> Index()
        {
            //var skillsQuery = _context.Skills.Include(s => s.Generalarea).Include(s => s.Prof);
            return View(await repo.AllAsync());
        }

        // GET: Skill/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills
                .Include(s => s.Generalarea)
                .Include(s => s.Prof)
                .FirstOrDefaultAsync(m => m.SkillId == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        // GET: Skill/Create
        public IActionResult Create()
        {
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name");
            ViewData["ProfId"] = new SelectList(_context.Professionists, "ProfId", "Lastname" + "Firstname");
            return View();
        }

        // POST: Skill/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SkillId,GeneralareaId,ProfId,Level,Description")] Skill skill)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name", skill.GeneralareaId);
            ViewData["ProfId"] = new SelectList(_context.Professionists, "ProfId", "Lastname" + "Firstname", skill.ProfId);
            return View(skill);
        }

        // GET: Skill/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name", skill.GeneralareaId);
            ViewData["ProfId"] = new SelectList(_context.Professionists, "ProfId", "Lastname" + "Firstname", skill.ProfId);
            return View(skill);
        }

        // POST: Skill/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkillId,GeneralareaId,ProfId,Level,Description")] Skill skill)
        {
            if (id != skill.SkillId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillExists(skill.SkillId))
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
            ViewData["GeneralareaId"] = new SelectList(_context.GeneralArea, "GeneralareaId", "Name", skill.GeneralareaId);
            ViewData["ProfId"] = new SelectList(_context.Professionists, "ProfId", "Lastname" + "Firstname", skill.ProfId);
            return View(skill);
        }

        // GET: Skill/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills
                .Include(s => s.Generalarea)
                .Include(s => s.Prof)
                .FirstOrDefaultAsync(m => m.SkillId == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        // POST: Skill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillExists(int id)
        {
            return _context.Skills.Any(e => e.SkillId == id);
        }
    }
}
