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
    public class IndexModels : PageModel
    {
        private readonly LocalAutos.Models.AutoContext _context;

        public IndexModels(LocalAutos.Models.AutoContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum      {get; set;} = 1;
        public int PageSize     {get; set;} = 10;

        [BindProperty(SupportsGet = true)]

        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.UserNew.Select(p => p);

            switch (CurrentSort)
            {
                case "first_asc":
                query = query.OrderBy(p => p.FirstName);
                break;
                case "first_desc":
                query = query.OrderBy(p => p.FirstName);
                break;

            }
            User = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
