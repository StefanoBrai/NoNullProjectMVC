using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.Repositories.Implementations
{
    public class EFRequestRepository: EFCrudRepository<Request>, RequestRepository
    {
        public EFRequestRepository(NoNullProjectContext ctx) : base(ctx) { }
    }
}
