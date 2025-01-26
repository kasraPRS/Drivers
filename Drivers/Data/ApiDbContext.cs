using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Drivers.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<UserProfile> Profiles { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
        


    }

}
