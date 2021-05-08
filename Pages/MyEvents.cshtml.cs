using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebbApplicationASPNetCoreVersion2.Data;
using WebbApplicationASPNetCoreVersion2.Models;

namespace WebbApplicationASPNetCoreVersion2.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly WebbApplicationASPNetCoreVersion2.Data.EventDbContext _context;

        public MyEventsModel(WebbApplicationASPNetCoreVersion2.Data.EventDbContext context)
        {
            _context = context;
        }

        public IList<Event> Events { get; set; }

        public async Task OnGetAsync()
        {
            var attendee = await _context.Attendees.Include(a => a.Events).FirstOrDefaultAsync();
            Events = attendee.Events;
        }
    }
}