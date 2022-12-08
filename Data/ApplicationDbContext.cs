using Control_de_personal.Models;
using Microsoft.EntityFrameworkCore;

namespace Control_de_personal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
    }
}
