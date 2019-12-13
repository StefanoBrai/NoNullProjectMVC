using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.Repositories.Implementations
{
    public class EFCrudRepository<T> : CrudRepository<T> where T : class
    {
        NoNullProjectContext ctx;
        public EFCrudRepository(NoNullProjectContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var x = await FindByIdAsync(id);
            if (x == null)
            {
                return false;
            }
            ctx.Set<T>().Remove(x);
            return true;
        }

        public IEnumerable<T> FindAll()
        {
            return ctx.Set<T>();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await ctx.Set<T>().FindAsync(id);
        }

        public T Insert(T toInsert)
        {
            ctx.Set<T>().Add(toInsert);
            return toInsert;
        }

        public async Task<bool> UpdateAsync(int id, T toUpdate)
        {
            var x = await FindByIdAsync(id);
            if (x == null)
            {
                return false;
            }
            ctx.Set<T>().Update(toUpdate);
            return true;
        }
    }
}
