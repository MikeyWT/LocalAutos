using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LocalAutos.Models;

namespace LocalAutos.Pages.AutomobilesAll
{
    public class CreateAutoModels : PageModel
    {
        private readonly LocalAutos.Models.AutoContext _context;

        public CreateAutoModels(LocalAutos.Models.AutoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Automobiles Automobiles { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AutoNew.Add(Automobiles);
            await _context.SaveChangesAsync();

            return RedirectToPage("./AutomobilesNew");
        }
    }
}