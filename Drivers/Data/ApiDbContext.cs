using Drivers.Models.DTO_s.Bank_Cards;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Drivers.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<UserServiceModel> Profiles { get; set; }
        public DbSet<BankCardServiceModel> BankCardServices { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }


    }

}
