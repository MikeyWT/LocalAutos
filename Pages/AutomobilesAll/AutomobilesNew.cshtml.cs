using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using LocalAutos.Models;


namespace LocalAutos.Pages.AutomobilesAll
{

public class AutoModels : PageModel
    {
        private readonly AutoContext _context;     //This replaces .db
        private readonly ILogger<AutoModels> _logger;

        public List<Automobiles> AutoTwo {get; set;}     //This will Create a list that will give access to information stored in the Automobiles class

        public AutoModels(AutoContext context, ILogger<AutoModels> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IList<Automobiles> AutomboliesTwo { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum      {get; set;} = 1;
        public int PageSize     {get; set;} = 10;

        [BindProperty(SupportsGet = true)]

        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.AutoNew.Select(p => p);

            switch (CurrentSort)
            {
                case "first_asc":
                query = query.OrderBy(p => p.Make);
                break;
                case "first_desc":
                query = query.OrderBy(p => p.Make);
                break;

            }
            AutoTwo = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}