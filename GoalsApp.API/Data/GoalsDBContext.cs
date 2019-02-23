using GoalsApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GoalsApp.API.Data
{
    public class GoalsDBContext : DbContext
    {
        public GoalsDBContext(DbContextOptions<GoalsDBContext> options) : base(options) { }

        public DbSet<Plan> Plans { get; set; }
    }
}