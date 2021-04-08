using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorEFDBFIRST21Starter.Models;

namespace RazorEFDBFIRST21Starter.Interfaces
{
    public interface ICountryService
    {
        List<Country> GetAllCountries();
        Country GetCountry(string code);
        void DeleteCountry(string code);
        void AddCountry(Country country);
    }
}
