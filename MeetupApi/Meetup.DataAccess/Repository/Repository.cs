using Meetup.DataAccess.Interfaces;
using Meetup.DataAccess.Models;

namespace Meetup.DataAccess.Repository
{
    public class Repository : IRepository
    {
        private readonly MeetupContext meetupContext;

        public Repository(MeetupContext context)
        {
            meetupContext = context;
        }

        public List<Event> GetAll()
        {
            return meetupContext.Events.ToList();
        }

        public Event? GetById(int id)
        {
            return meetupContext.Events.Find(id);
        }

        public void Create(Event anyEvent)
        {
            meetupContext.Events.Add(anyEvent);
            meetupContext.SaveChanges();
        }

        public void Update(Event anyEvent)
        {
            meetupContext.Events.Update(anyEvent);
            meetupContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var anyEvent = meetupContext.Events.Find(id);
            if (anyEvent != null)
            {
                meetupContext.Events.Remove(anyEvent);
                meetupContext.SaveChanges();
            }
        }
    }
}