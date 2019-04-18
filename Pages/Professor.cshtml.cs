using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab11_1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab11_1.Pages
{
    public class ProfessorModel : PageModel
    {
        private readonly ProfessorDbContext _context;
        public List<Professor> Professors {get; set;}
        public SelectList ProfessorsDropDown {get; set;}
        public string CurrentProfessor {get; set;}


        public ProfessorModel(ProfessorDbContext context)
        {
            _context = context;
        }
        public void OnGetAsync()
        {
            Professors = _context.Professor.ToList();

            ProfessorsDropDown = new SelectList(Professors, "ID", "FirstName", "LastName");

            switch (CurrentProfessor)
            {
                case "Kareem":
                    break;
            }
        }
    }
}