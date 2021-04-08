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
    public class CreateCountryModel : PageModel
    {
        ICountryService repo;
        [BindProperty]
        public Country Country { get; set; }
        public CreateCountryModel(ICountryService repository)
        {
            repo = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            repo.AddCountry(Country);
            return RedirectToPage("IndexCountry");
        }
    }
}
