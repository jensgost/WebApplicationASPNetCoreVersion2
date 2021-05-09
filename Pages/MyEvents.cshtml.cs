using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationASPNetCoreVersion2.Data;
using WebApplicationASPNetCoreVersion2.Models;

namespace WebApplicationASPNetCoreVersion2.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly WebApplicationASPNetCoreVersion2.Data.EventDbContext _context;

        public MyEventsModel(WebApplicationASPNetCoreVersion2.Data.EventDbContext context)
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