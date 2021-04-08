using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEFDBFIRST21Starter.Interfaces;
using RazorEFDBFIRST21Starter.Models;

namespace RazorEFDBFIRST21Starter.Pages.Countries
{
    public class IndexCountryModel : PageModel
    {
        ICountryService repo;

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexCountryModel(ICountryService repository)
        {
            repo = repository;
        }

        public List<Country> Countries { get; private set; }
        public IActionResult OnGet()
        {
            Countries = repo.GetAllCountries();
            return Page();
        }
    }
}
