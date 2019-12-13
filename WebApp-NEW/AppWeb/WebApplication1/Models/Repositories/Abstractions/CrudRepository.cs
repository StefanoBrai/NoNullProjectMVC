using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Repositories.Abstractions
{
    public interface CrudRepository<T> where T : class
    {
        Task<T> FindByIdAsync(int id);
        Task<bool> DeleteAsync(int id);
        T Insert(T toInsert);
        Task<bool> UpdateAsync(int id, T toUpdate);
        IEnumerable<T> FindAll();
    }
}
