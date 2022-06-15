using Meetup.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Meetup.DataAccess
{
    public class MeetupContext : DbContext
    {
        public DbSet<Event> Events { get; set; } = null!;

        public MeetupContext(DbContextOptions<MeetupContext> options) : base(options)
        {
        }
    }
}