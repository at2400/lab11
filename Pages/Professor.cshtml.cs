using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab11_1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace lab11_1.Pages
{
    public class ProfessorModel : PageModel
    {
        private readonly ProfessorDbContext _context;
        public List<Professor> Professors {get; set;}
       [BindProperty]
        public string ID {get; set;}
        public string FirstName {get; set;}
        [BindProperty]
        public string LastName {get; set;}
        public SelectList ProfessorsDropDown {get; set;}


        public ProfessorModel(ProfessorDbContext context)
        {
            _context = context;
        }



        public void OnGet()
        {
            Professors = _context.Professor.ToList();



            ProfessorsDropDown = new SelectList(Professors, "ID", "FirstName", "LastName");
        }
    }
}