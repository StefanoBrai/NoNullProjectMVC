using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.Repositories.Implementations
{
    public class EfSkillRepository : SkillRepository
    {
        private NoNullProjectContext ctx;
        public EfSkillRepository(NoNullProjectContext ctx)
        {
            this.ctx = ctx;
        }
        public async Task<List<Skill>> AllAsync()
        {
            return await ctx.Skills.ToListAsync();
        }
    }
}
