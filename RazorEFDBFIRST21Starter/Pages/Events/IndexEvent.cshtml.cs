using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEFDBFIRST21Starter.Interfaces;
using RazorEFDBFIRST21Starter.Models;

namespace RazorEFDBFIRST21Starter.Pages.Events
{
    public class IndexEventModel : PageModel
    {
        IEventService repo;

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public IndexEventModel(IEventService repository)
        {
            repo = repository;
        }
        public List<Event> Events { get; private set; }
        public IActionResult OnGet()
        {
            Events = repo.GetAllEvents();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Events = repo.FilterEventsByCity(FilterCriteria);
            }
            return Page();
        }
        public IActionResult OnGetMyEvents(string code)
        {
            Events = new List<Event>();
            if (code == null)
            {
                return NotFound();
            }
            Events = repo.SearchEventsByCountryCode(code);
            return Page();
        }
    }
}
