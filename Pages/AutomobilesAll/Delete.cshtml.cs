using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LocalAutos.Models;

namespace LocalAutos.Pages.AutomobilesAll
{
    public class DeleteModels : PageModel
    {
        private readonly LocalAutos.Models.AutoContext _context;

        public DeleteModels(LocalAutos.Models.AutoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.UserNew.FirstOrDefaultAsync(m => m.UserID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.UserNew.FindAsync(id);

            if (User != null)
            {
                _context.UserNew.Remove(User);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
