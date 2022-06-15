using Meetup.DataAccess.Models;

namespace Meetup.DataAccess.Interfaces
{
    public interface IRepository
    {
        List<Event> GetAll();

        Event? GetById(int id);

        void Create(Event anyEvent);

        void Update(Event anyEvent);

        void Delete(int id);
    }
}