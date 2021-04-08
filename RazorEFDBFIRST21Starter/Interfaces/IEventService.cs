using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorEFDBFIRST21Starter.Models;

namespace RazorEFDBFIRST21Starter.Interfaces
{
    public interface IEventService
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void DeleteEvent(int id);
        void UpdateEvent(Event ev);
        List<Event> FilterEventsByCity(string city);
        List<Event> SearchEventsByCountryCode(string code);
    }
}
