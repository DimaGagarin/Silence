using Meetup.DataAccess.Models;

namespace Meetup.Business.Interfaces
{
    public interface IService
    {
        List<Event> GetAll();

        Event? GetById(int id);

        void Create(Event anyEvent);

        void Update(Event anyEvent);

        void Delete(int id);
    }
}