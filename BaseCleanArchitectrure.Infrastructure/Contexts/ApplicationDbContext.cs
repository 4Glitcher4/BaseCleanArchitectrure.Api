using BaseCleanArchitectrure.Core.Interfaces.ContextInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BaseCleanArchitectrure.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
