using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TransportModule1.Models;

namespace TransportModule1.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Bills> Bills { get; set; } // Add this line to manage bills
    }
}
