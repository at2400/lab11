using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace lab11_1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProfessorDbContext>>()))
            {
                // Look for any movies.
                if (context.Professor.Any())
                {
                    return;   // DB has been seeded
                }

                context.Professor.AddRange(
                    new Professor
                    {
                        FirstName = "Kareem",
                        LastName = "Dana"
                    },

                    new Professor
                    {
                        FirstName = "Jeffry",
                        LastName = "Babb"
                    },

                    new Professor
                    {
                        FirstName = "Shawn",
                        LastName = "Humphries"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}                