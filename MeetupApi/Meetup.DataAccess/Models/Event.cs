using System.ComponentModel.DataAnnotations;

namespace Meetup.DataAccess.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Organizer { get; set; } = null!;

        public string Location { get; set; } = null!;

        public DateTime Time { get; set; }
    }
}