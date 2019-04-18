using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab11_1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab11_1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly lab11_1.Models.ProfessorDbContext _context;
        public List<Professor> Professors {get; set;}

        public IndexModel(ProfessorDbContext context)
        {
            _context = context;
        }

       public void OnGetAsync()
       {
           Professors = _context.Professor.ToList();

           var professors = _context.Professor.Include(p => p.FirstName).Select(p => p);
       }
    }
}
