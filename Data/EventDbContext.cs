using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationASPNetCoreVersion2.Models;

namespace WebApplicationASPNetCoreVersion2.Data
{
    public class EventDbContext : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }

        public void ResetAndSeed()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            Attendee[] attendees = new Attendee[] {
                new Attendee()
                {
                    Name = "Johan Svensson",
                    PhoneNumber = "12345",
                    Email = "johan.svensson@gmail.com",
                },
            };

            Organizer[] organizers = new Organizer[] {
                new Organizer(){
                    Name = "Organizer",
                    Email = "organizer@gmail.com",
                    PhoneNumber = "54321",
                },
            };

            Event[] events = new Event[] {
                new Event(){
                    Title="HBK-MFF Allsvenskan",
                    Description="Se Allsvenskan live",
                    Place="Halmstad",
                    Address="Örjans Vall",
                    Date=DateTime.Now.AddDays(34),
                    SpotsAvailable=8,
                    Organizer= organizers[0],
                },
                new Event(){
                    Title="Per Gessle On Tour",
                    Description="Se Per Gessle live",
                    Place="Tylösand",
                    Address="Tylövägen",
                    Date=DateTime.Now.AddDays(12),
                    SpotsAvailable=8,
                    Organizer= organizers[0],
                },
            };

            AddRange(attendees);
            AddRange(organizers);
            AddRange(events);

            SaveChanges();
        }
    }
}