using Microsoft.EntityFrameworkCore;

namespace lab11_1.Models
{
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
            : base(options)
        {
        }

        public DbSet<lab11_1.Models.Professor> Professor { get; set; }
    }
}