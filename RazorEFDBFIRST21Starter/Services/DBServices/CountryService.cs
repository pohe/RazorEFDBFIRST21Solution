using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorEFDBFIRST21Starter.Interfaces;
using RazorEFDBFIRST21Starter.Models;

namespace RazorEFDBFIRST21Starter.Services.DBServices
{
    public class CountryService : ICountryService
    {
        private Eventmakerdb21Context _context;

        public CountryService(Eventmakerdb21Context context)
        {
            _context = context;
        }


        public List<Country> GetAllCountries()
        {
            //return _context.Countries.ToList();
            return _context.Countries.Include(e=>e.Events).AsNoTracking().ToList();
        }

        public Country GetCountry(string code)
        {
            return _context.Countries.Find(code);
        }

        public void DeleteCountry(string code)
        {
            Country countryToRemove= _context.Countries.Find(code);
            _context.Countries.Remove(countryToRemove);
            _context.SaveChanges();
        }

        public void AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }
    }
}
